using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    public class SubjectRepository
    {
        private readonly UniversityContext _context;

        public SubjectRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }

        public Subject GetSubjectById(int id)
        {
            return _context.Subjects
                .Include(s => s.Courses) // Incluir Courses si es necesario
                .FirstOrDefault(s => s.Id == id);
        }

        public void UpdateSubject(Subject subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges();
        }

        public void DeleteSubject(int id)
        {
            var subject = _context.Subjects.Find(id);
            if (subject != null)
            {
                _context.Subjects.Remove(subject);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Course> GetCoursesBySubjectId(int subjectId)
        {
            var subject = _context.Subjects
                .Include(s => s.Courses)
                .FirstOrDefault(s => s.Id == subjectId);

            return subject?.Courses ?? Enumerable.Empty<Course>();
        }

        // Método para obtener todas las asignaturas
        public IEnumerable<Subject> GetAllSubjects()
        {
            return _context.Subjects.ToList();
        }
    }
}