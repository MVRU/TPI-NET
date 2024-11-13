using ProyectoNET.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;

namespace ProyectoNET.Repositories
{
    public class CourseRepository
    {
        public readonly UniversityContext _context;

        public CourseRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId)
        {
            var course = new Course
            {
                Year = year,
                StartDate = startDate,
                EndDate = endDate,
                Quota = quota,
                SubjectId = subjectId // Puede ser null
            };

            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses
                .FirstOrDefault(c => c.Id == id); // Aquí no incluimos las relaciones
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses
                .Include(c => c.Subject) // Solo se incluyen cuando realmente se necesitan
                .Include(c => c.Schedules)
                .Include(c => c.Users)
                .Include(c => c.Enrollments)
                .ToList();
        }

        public void UpdateCourse(int courseId, int year, DateTime startDate, DateTime endDate, int quota, int? subjectId)
        {
            var course = GetCourseById(courseId);
            if (course != null)
            {
                course.Year = year;
                course.StartDate = startDate;
                course.EndDate = endDate;
                course.Quota = quota;
                course.SubjectId = subjectId; // Puede ser null

                _context.Courses.Update(course);
                _context.SaveChanges();
            }
        }

        public void DeleteCourse(int id)
        {
            var course = GetCourseById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}
