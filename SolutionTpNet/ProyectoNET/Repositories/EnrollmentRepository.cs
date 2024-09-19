using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    internal class EnrollmentRepository
    {
        private readonly UniversityContext _context;

        public EnrollmentRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }

        public Enrollment GetEnrollmentById(int id)
        {
            return _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Attendances)
                .Include(e => e.Status)
                .Include(e => e.Student) // Incluye el estudiante (User)
                .FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            _context.SaveChanges();
        }

        public void DeleteEnrollment(int id)
        {
            var enrollment = _context.Enrollments.Find(id);
            if (enrollment != null)
            {
                _context.Enrollments.Remove(enrollment);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Attendance> GetAttendancesByEnrollmentId(int enrollmentId)
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Attendances)
                .FirstOrDefault(e => e.Id == enrollmentId);

            return enrollment?.Attendances ?? Enumerable.Empty<Attendance>();
        }
    }
}
