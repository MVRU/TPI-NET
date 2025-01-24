using SharedModels.Interfaces;

namespace SharedModels.Models
{
    public class Student : IUser
    {
        public int Id { get; set; } // Legajo
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string PasswordHash { get; set; }
        public string Role { get; set; }
        public Student()
        {
            Role = "Student";
        }

        // Relación uno a muchos con Enrollment (matrícula)
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
