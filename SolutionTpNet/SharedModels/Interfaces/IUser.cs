namespace SharedModels.Interfaces;

public interface IUser
{
    int Id { get; set; } // Legajo
    string Name { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string PasswordHash { get; set; }
    string Role { get; set; }
}