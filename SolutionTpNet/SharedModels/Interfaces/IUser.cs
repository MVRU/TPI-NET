namespace SharedModels.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
