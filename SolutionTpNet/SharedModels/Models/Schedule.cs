namespace SharedModels.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Relación muchos a muchos con Course
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }

    public enum DayOfWeek
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }
}
