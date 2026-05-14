
namespace Portal.Domain.Users;
public class User : Entity
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public User() { }

    public static User Create(string name, string email)
    {
        return new User
        {
           
            Name = name,
            Email = email
        };
    }
}