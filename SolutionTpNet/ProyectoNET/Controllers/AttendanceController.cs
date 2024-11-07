using System;
using System.Collections.Generic;
using ProyectoNET.Repositories;
using ProyectoNET.Models;

namespace ProyectoNET.Controllers
{
    internal class AttendanceController
    {
        private readonly AttendanceRepository _attendanceRepository;

        public AttendanceController(AttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public void CreateAttendance(DateTime timestamp, int enrollmentId)
        {
            _attendanceRepository.CreateAttendance(timestamp, enrollmentId);
            Console.WriteLine("Asistencia creada con éxito.");
        }

        public void GetAttendanceById(int id)
        {
            var attendance = _attendanceRepository.GetAttendanceById(id);

            if (attendance != null)
            {
                Console.WriteLine($"Asistencia encontrada: Id {attendance.Id}");
                Console.WriteLine($"Fecha y Hora: {attendance.Timestamp}");
                Console.WriteLine($"Inscripción asociada: {attendance.EnrollmentId}");
            }
            else
            {
                Console.WriteLine("Asistencia no encontrada.");
            }
        }

        public void UpdateAttendance(int id, DateTime newTimestamp)
        {
            _attendanceRepository.UpdateAttendance(id, newTimestamp);
            Console.WriteLine("Asistencia actualizada con éxito.");
        }

        public void DeleteAttendance(int id)
        {
            _attendanceRepository.DeleteAttendance(id);
            Console.WriteLine("Asistencia eliminada con éxito.");
        }

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
    }
}
