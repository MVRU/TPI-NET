using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    internal class EnrollmentController
    {
        private readonly EnrollmentRepository _enrollmentRepository;

        public EnrollmentController(EnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public void CreateEnrollment(int courseId, DateTime enrollmentDate, int statusId)
        {
            var enrollment = new Enrollment
            {
                CourseId = courseId,
                EnrollmentDate = enrollmentDate,
                StatusId = statusId
            };

            _enrollmentRepository.CreateEnrollment(enrollment);
            Console.WriteLine($"Inscripción creada con éxito para el curso con Id {courseId}.");
        }

        public void GetEnrollmentById(int id)
        {
            var enrollment = _enrollmentRepository.GetEnrollmentById(id);

            if (enrollment != null)
            {
                Console.WriteLine($"Inscripción encontrada con Id {enrollment.Id}:");
                Console.WriteLine($"Fecha de inscripción: {enrollment.EnrollmentDate}");
                Console.WriteLine($"Curso: {enrollment.Course?.Year}");
                Console.WriteLine($"Estado: {enrollment.Status?.Description}");

                Console.WriteLine("Asistencias asociadas:");
                foreach (var attendance in enrollment.Attendances)
                {
                    Console.WriteLine($"Fecha: {attendance.Timestamp}, Asistió: {(attendance.IsPresent ? "Sí" : "No")}");
                }
            }
            else
            {
                Console.WriteLine("Inscripción no encontrada.");
            }
        }

        public void UpdateEnrollment(int id, DateTime newEnrollmentDate, int newCourseId, int newStatusId)
        {
            var enrollment = _enrollmentRepository.GetEnrollmentById(id);

            if (enrollment != null)
            {
                enrollment.EnrollmentDate = newEnrollmentDate;
                enrollment.CourseId = newCourseId;
                enrollment.StatusId = newStatusId;
                _enrollmentRepository.UpdateEnrollment(enrollment);

                Console.WriteLine($"Inscripción con Id {id} actualizada con éxito.");
            }
            else
            {
                Console.WriteLine("Inscripción no encontrada.");
            }
        }

        public void DeleteEnrollment(int id)
        {
            _enrollmentRepository.DeleteEnrollment(id);
            Console.WriteLine($"Inscripción con Id {id} eliminada con éxito.");
        }

        public void GetAttendancesByEnrollmentId(int enrollmentId)
        {
            var attendances = _enrollmentRepository.GetAttendancesByEnrollmentId(enrollmentId);

            if (attendances.Any())
            {
                Console.WriteLine($"Asistencias para la inscripción con Id {enrollmentId}:");
                foreach (var attendance in attendances)
                {
                    Console.WriteLine($"Fecha: {attendance.Timestamp}, Asistió: {(attendance.IsPresent ? "Sí" : "No")}");
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron asistencias para la inscripción con Id {enrollmentId}.");
            }
        }
    }
}