using SharedModels.Interfaces; 

namespace SharedModels.Models
{
    public class Professor : IUser
    {
        public int Id { get; set; } // Legajo
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string? Speciality { get; set; } // Opcional

        public Professor()
        {
            Role = "Professor"; // Inicializar el rol
        }

        // Relación muchos a muchos con Course
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
