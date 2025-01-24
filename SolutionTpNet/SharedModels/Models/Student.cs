namespace SharedModels.Models
{
    public class Student
    {
        public int Id { get; set; } // Legajo
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string Password { get; set; }

        // Relación uno a muchos con Enrollment (matrícula)
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
