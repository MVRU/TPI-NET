using BusinessLogic.Interfaces;
using DataAccess.Repositories;
using SharedModels.Models;
using SharedModels.DTOs;

namespace BusinessLogic.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<CourseResponse>> GetAllCoursesAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            return courses.Select(c => new CourseResponse
            {
                Id = c.Id,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Quota = c.Quota,
                SubjectId = c.SubjectId
            });
        }

        public async Task<CourseResponse?> GetCourseByIdAsync(int id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                return null;
            }

            return new CourseResponse
            {
                Id = course.Id,
                StartDate = course.StartDate,
                EndDate = course.EndDate,
                Quota = course.Quota,
                SubjectId = course.SubjectId
            };
        }

        public async Task<CourseResponse> AddCourseAsync(CourseRequest request)
        {
            var course = new Course
            {
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Quota = request.Quota,
                SubjectId = request.SubjectId
            };

            await _courseRepository.AddAsync(course);

            return new CourseResponse
            {
                Id = course.Id,
                StartDate = course.StartDate,
                EndDate = course.EndDate,
                Quota = course.Quota,
                SubjectId = course.SubjectId
            };
        }

        public async Task UpdateCourseAsync(CourseRequest request)
        {
            var course = await _courseRepository.GetByIdAsync(request.Id);
            if (course == null)
            {
                throw new KeyNotFoundException("Curso no encontrado.");
            }

            course.StartDate = request.StartDate;
            course.EndDate = request.EndDate;
            course.Quota = request.Quota;
            course.SubjectId = request.SubjectId;

            await _courseRepository.UpdateAsync(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                throw new KeyNotFoundException("Curso no encontrado.");
            }

            await _courseRepository.DeleteAsync(id);
        }
    }
}