namespace SharedModels.DTOs;

public class SignInResponse
{
    public string Token { get; set; } // JWT
    public string Role { get; set; } // "Student", "Professor", "Admin"
}