namespace SharedModels.Models
{
    public class Course
    {
        public int Id { get; set; }
        required public DateTime StartDate { get; set; }
        required public DateTime EndDate { get; set; }
        required public int Quota { get; set; }

        // Relación con Subject
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        // Relación muchos a muchos con Professor
        public ICollection<Professor> Professors { get; set; } = new List<Professor>();

        // Relación muchos a muchos con Schedule
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

        // Relación uno a muchos con Enrollment
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
