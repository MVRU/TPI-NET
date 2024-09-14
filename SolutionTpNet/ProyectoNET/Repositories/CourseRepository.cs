using ProyectoNET.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;

namespace ProyectoNET.Repositories
{
    internal class CourseRepository
    {
        private readonly UniversityContext _context;

        public CourseRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses
                .Include(c => c.Subject)      
                .Include(c => c.Schedules)    
                .Include(c => c.Professors)       
                .Include(c => c.Enrollments)      
                .FirstOrDefault(c => c.Id == id);
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses
                .Include(c => c.Subject)
                .Include(c => c.Schedules)
                .Include(c => c.Professors)
                .Include(c => c.Enrollments)
                .ToList();
        }

        public void UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
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
