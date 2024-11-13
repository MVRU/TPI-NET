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


        // Método para verificar si ya existe un curso con los mismos parámetros
        public bool CourseExists(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId, int? excludedId = null)
        {
            return _context.Courses
                .Any(c => c.Year == year
                       && c.StartDate.Date == startDate.Date // Comparar solo la fecha sin la hora
                       && c.EndDate.Date == endDate.Date // Comparar solo la fecha sin la hora
                       && c.Quota == quota
                       && c.SubjectId == subjectId
                       && (!excludedId.HasValue || c.Id != excludedId.Value));
        }

        public void CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId)
        {
            // Verificar si ya existe un curso con los mismos parámetros
            if (CourseExists(year, startDate, endDate, quota, subjectId))
            {
                throw new InvalidOperationException("Ya existe un curso con los mismos parámetros.");
            }

            // Verificar si el SubjectId existe en la base de datos
            if (subjectId.HasValue && !_context.Subjects.Any(s => s.Id == subjectId.Value))
            {
                throw new ArgumentException("El SubjectId proporcionado no es válido.");
            }

            var course = new Course
            {
                Year = year,
                StartDate = startDate,
                EndDate = endDate,
                Quota = quota,
                SubjectId = subjectId // Puede ser null si no se seleccionó una asignatura
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
                .Include(c => c.Subject) // Incluye la relación con Subject para acceder a Id y Description
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
                // Verificar si ya existe un curso con los mismos parámetros (sin contar el curso actual)
                if (CourseExists(year, startDate, endDate, quota, subjectId, courseId))
                {
                    throw new InvalidOperationException("Ya existe un curso con los mismos parámetros.");
                }

                course.Year = year;
                course.StartDate = startDate;
                course.EndDate = endDate;
                course.Quota = quota;
                course.SubjectId = subjectId;

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
