namespace SharedModels.DTOs
{
    public class CourseResponse
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quota { get; set; }
        public int SubjectId { get; set; }

    }
}
