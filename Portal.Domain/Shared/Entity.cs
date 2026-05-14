public class Entity
{
    public Guid Id { get; private set; }
    public string CreatedBy { get; private set; }
    public string UpdatedBy { get; private set; }
    public string CreatedOn { get; private set; }
    public string UpdatedOn { get; private set; }


    public Entity()
    {
        Id = Guid.NewGuid();
        CreatedOn = DateTime.UtcNow.ToString("o");  
        UpdatedOn = DateTime.UtcNow.ToString("o");
    }

    // public static User Create(string name, string email)
    // {
    //     return new User
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = name,
    //         Email = new UserEmail(email)
    //     };
    // }
}