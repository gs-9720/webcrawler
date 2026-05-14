namespace Portal.Application.Queries.Users;

public class UserReadModel
{
    public Guid Id { get; init; }
    public string Name { get; init; }= string.Empty;
    public string Email { get; init; } = string.Empty;
}