using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    internal class AttendanceRepository
    {
        private readonly UniversityContext _context;

        public AttendanceRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateAttendance(DateTime timestamp, int enrollmentId)
        {
            var attendance = new Attendance
            {
                Timestamp = timestamp,
                EnrollmentId = enrollmentId
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();
        }

        public Attendance GetAttendanceById(int id)
        {
            return _context.Attendances
                .Include(a => a.Enrollment) // Incluir Enrollment para la navegación
                .FirstOrDefault(a => a.Id == id);
        }

        public void UpdateAttendance(int id, DateTime newTimestamp)
        {
            var attendance = _context.Attendances.FirstOrDefault(a => a.Id == id);

            if (attendance != null)
            {
                attendance.Timestamp = newTimestamp;
                _context.SaveChanges();
            }
        }

        public void DeleteAttendance(int id)
        {
            var attendance = _context.Attendances.FirstOrDefault(a => a.Id == id);

            if (attendance != null)
            {
                _context.Attendances.Remove(attendance);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Attendance> GetAttendancesByEnrollmentId(int enrollmentId)
        {
            return _context.Attendances
                .Where(a => a.EnrollmentId == enrollmentId)
                .ToList();
        }
    }
}
