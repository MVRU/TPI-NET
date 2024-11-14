using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    public class AttendanceRepository
    {
        private readonly UniversityContext _context;

        // Constructor con inyección de dependencias
        public AttendanceRepository(UniversityContext context)
        {
            _context = context;
        }

        // Crear nueva asistencia
        public void CreateAttendance(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
        }

        // Obtener una asistencia por ID
        public Attendance GetAttendanceById(int id)
        {
            return _context.Attendances
                .Include(a => a.Enrollment)  // Incluir la relación de inscripción (Enrollment)
                .FirstOrDefault(a => a.Id == id);  // Buscar por ID
        }

        // Actualizar una asistencia
        public void Update(Attendance attendance)
        {
            try
            {
                // Verificar que la asistencia existe
                var existingAttendance = _context.Attendances.FirstOrDefault(a => a.Id == attendance.Id);
                if (existingAttendance != null)
                {
                    // Actualizar los datos de la asistencia
                    existingAttendance.Timestamp = attendance.Timestamp;
                    existingAttendance.EnrollmentId = attendance.EnrollmentId; // Asegurarse de que la relación sea correcta

                    _context.SaveChanges(); // Guardar cambios en la base de datos
                }
                else
                {
                    throw new Exception("Asistencia no encontrada.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar la asistencia: {ex.Message}");
            }
        }

        // Eliminar una asistencia por ID
        public void DeleteAttendance(int id)
        {
            var attendance = _context.Attendances.FirstOrDefault(a => a.Id == id);
            if (attendance != null)
            {
                _context.Attendances.Remove(attendance);
                _context.SaveChanges();
            }
        }

        // Obtener asistencias de una inscripción específica
        public IEnumerable<Attendance> GetAttendancesByEnrollmentId(int enrollmentId)
        {
            return _context.Attendances
                .Where(a => a.EnrollmentId == enrollmentId)
                .ToList();
        }

        // Obtener todas las asistencias
        public IEnumerable<Attendance> GetAllAttendances()
        {
            return _context.Attendances
                .Include(a => a.Enrollment)  // Incluir la relación de inscripción
                .ToList();
        }

        // Obtener todas las inscripciones para un curso
        public IEnumerable<Enrollment> GetEnrollmentsByCourse(int courseId)
        {
            return _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .Include(e => e.Student)  // Incluir al estudiante en la inscripción
                .ToList();
        }

        // Obtener asistencias por ID de usuario
        public IEnumerable<Attendance> GetAttendancesByUserId(string userId)
        {
            return _context.Attendances
                .Include(a => a.Enrollment)
                .ThenInclude(e => e.Student)  // Incluir al estudiante (User)
                .Where(a => a.Enrollment.StudentId == userId)
                .ToList();
        }
    }
}
