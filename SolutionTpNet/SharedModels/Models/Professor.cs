namespace SharedModels.Models
{
    public class Professor
    {
        public int Id { get; set; } // Legajo
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string Password { get; set; }
        public string? Speciality { get; set; } // Opcional

        // Relación muchos a muchos con Course
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
