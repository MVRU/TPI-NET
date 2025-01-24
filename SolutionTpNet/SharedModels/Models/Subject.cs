namespace SharedModels.Models
{
    public class Subject
    {
        public int Id { get; set; }
        required public string Description { get; set; }
        required public float RequiredAttendancePercentage { get; set; }

        // Relación uno a muchos con Course
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
