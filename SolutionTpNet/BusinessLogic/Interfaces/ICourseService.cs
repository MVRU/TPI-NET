using SharedModels.Models;
using SharedModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseResponse>> GetAllCoursesAsync();
        Task<CourseResponse?> GetCourseByIdAsync(int id);
        Task<CourseResponse> AddCourseAsync(CourseRequest request);
        Task UpdateCourseAsync(CourseRequest request);
        Task DeleteCourseAsync(int id);
    }
}
