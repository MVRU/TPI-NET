namespace DataAccess.Entities;
using SharedModels.Enums;

public class User
{
    public int File { get; set; }  // Legajo es el Id
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Password { get; set; }
    public UserRole UserRole { get; set; }  // Enum que define el rol (Student, Professor, Admin)
}