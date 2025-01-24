namespace SharedModels.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        required public DateTime EnrollmentDate { get; set; }
        public double? Grade { get; set; }

        // Relación con Student
        required public int StudentId { get; set; }
        required public Student Student { get; set; }

        // Relación con Course
        public int CourseId { get; set; }
        public Course Course { get; set; }

        // Relación uno a muchos con Attendance
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

        // EnrollmentStatus calculado
        public EnrollmentStatus Status
        {
            get
            {
                if (DateTime.Now < Course.EndDate)
                {
                    return EnrollmentStatus.Pendiente;
                }
                else if (DateTime.Now > Course.EndDate)
                {
                    var attendancePercentage = (float)Attendances.Count / Course.Schedules.Count;
                    if (attendancePercentage >= Course.Subject.RequiredAttendancePercentage)
                    {
                        return Grade >= 6 ? EnrollmentStatus.Aprobado : EnrollmentStatus.Libre;
                    }
                }

                return EnrollmentStatus.Regular;
            }

        }

        public enum EnrollmentStatus
        {
            Pendiente,
            Regular,
            Aprobado,
            Libre
        }
    }
}
