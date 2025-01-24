namespace SharedModels.DTOs;

public class SignInRequest
{
    public string Role { get; set; } // "Student", "Professor", "Admin"
    public int Id { get; set; } // Legajo
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string? Specialization { get; set; } // Atributo adicional para Professor
    public string? Position { get; set; } // Atributo adicional para Admin
}