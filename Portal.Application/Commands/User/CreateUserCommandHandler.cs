using MediatR;
using Portal.Domain.Shared;
using Portal.Domain.Users;

namespace Portal.Application.Commands.User;

public class CreateUserCommandHandler
    : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(
        IUserRepository repository,
        IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken)
    {
        var user = Portal.Domain.Users.User.Create(request.Name, request.Email);

        await _repository.AddAsync(user);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}