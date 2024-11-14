using System;
using System.Collections.Generic;
using ProyectoNET.Repositories;
using ProyectoNET.Models;

namespace ProyectoNET.Controllers
{
    public class AttendanceController
    {
        private readonly AttendanceRepository _attendanceRepository;

        // Constructor con inyección de dependencias
        public AttendanceController(AttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        // Crear nueva asistencia
        public void CreateAttendance(DateTime attendanceDate, int enrollmentId)
        {
            try
            {
                var attendance = new Attendance
                {
                    Timestamp = attendanceDate,
                    EnrollmentId = enrollmentId
                };

                _attendanceRepository.CreateAttendance(attendance);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar la asistencia: {ex.Message}");
            }
        }

        // Actualizar una asistencia existente
        public void UpdateAttendance(int attendanceId, DateTime attendanceDate, int enrollmentId)
        {
            try
            {
                // Buscar la asistencia existente por su ID utilizando el repositorio
                var attendance = _attendanceRepository.GetAttendanceById(attendanceId);

                if (attendance == null)
                {
                    throw new Exception("La asistencia no existe.");
                }

                // Actualizar los campos necesarios de la asistencia
                attendance.Timestamp = attendanceDate;
                attendance.EnrollmentId = enrollmentId;

                // Guardar los cambios utilizando el repositorio
                _attendanceRepository.Update(attendance);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar la asistencia: {ex.Message}");
            }
        }

        // Obtener una asistencia por ID
        public Attendance GetAttendanceById(int attendanceId)
        {
            try
            {
                return _attendanceRepository.GetAttendanceById(attendanceId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener la asistencia: {ex.Message}");
            }
        }

        // Eliminar una asistencia
        public void DeleteAttendance(int id)
        {
            _attendanceRepository.DeleteAttendance(id);
            Console.WriteLine("Asistencia eliminada con éxito.");
        }

        // Obtener todas las asistencias de una inscripción
        public void GetAttendancesByEnrollmentId(int enrollmentId)
        {
            var attendances = _attendanceRepository.GetAttendancesByEnrollmentId(enrollmentId);

            if (attendances.Any())
            {
                Console.WriteLine($"Asistencias para la inscripción {enrollmentId}:");
                foreach (var attendance in attendances)
                {
                    Console.WriteLine($"Id: {attendance.Id}, Fecha y Hora: {attendance.Timestamp}");
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron asistencias para la inscripción {enrollmentId}.");
            }
        }

        // Obtener todas las asistencias
        public IEnumerable<Attendance> GetAllAttendances()
        {
            return _attendanceRepository.GetAllAttendances();
        }
    }
}
