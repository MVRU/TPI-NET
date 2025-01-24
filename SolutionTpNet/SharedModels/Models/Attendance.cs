namespace SharedModels.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }

        // Relación con Enrollment
        required public int EnrollmentId { get; set; }
        required public Enrollment Enrollment { get; set; }

    }
}
