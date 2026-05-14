
using Portal.Common.Exceptions;

namespace Portal.Domain.Users;

public record UserEmail
{
    public string Value { get; }

    public UserEmail(string value)
    {
        if (!value.Contains("@"))
            throw new DomainException("Invalid email");

        Value = value;
    }
}