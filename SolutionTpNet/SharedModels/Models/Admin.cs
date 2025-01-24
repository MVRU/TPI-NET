using SharedModels.Interfaces;

namespace SharedModels.Models
{
    public class Admin : IUser
    {
        public int Id { get; set; }
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string? Position { get; set; } // Opcional

        public Admin()
        {
            Role = "Admin"; // Inicializar el rol
        }
    }
}