using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNET
{
    internal class EnrollmentController
    {
        // Método para crear una inscripción (Enrollment)
        static void CreateEnrollment(DateTime fechaInscripcion)
        {
            using (var context = new UniversityContext())
            {
                var enrollment = new Enrollment
                {
                    FechaInscripcion = fechaInscripcion
                };

                context.Enrollments.Add(enrollment);
                context.SaveChanges();

                Console.WriteLine("Inscripción creada con éxito.");
            }
        }

        // Método para leer una inscripción por su Id
        static void GetEnrollmentById(int id)
        {
            using (var context = new UniversityContext())
            {
                var enrollment = context.Enrollments.FirstOrDefault(e => e.Id == id);

                if (enrollment != null)
                {
                    Console.WriteLine($"Inscripción encontrada: Fecha de inscripción {enrollment.FechaInscripcion}");
                }
                else
                {
                    Console.WriteLine("Inscripción no encontrada.");
                }
            }
        }

        // Método para actualizar la fecha de inscripción
        static void UpdateEnrollment(int id, DateTime nuevaFechaInscripcion)
        {
            using (var context = new UniversityContext())
            {
                var enrollment = context.Enrollments.FirstOrDefault(e => e.Id == id);

                if (enrollment != null)
                {
                    enrollment.FechaInscripcion = nuevaFechaInscripcion;
                    context.SaveChanges();

                    Console.WriteLine($"Fecha de inscripción del Enrollment con Id {id} actualizada.");
                }
                else
                {
                    Console.WriteLine("Inscripción no encontrada.");
                }
            }
        }

        // Método para eliminar una inscripción
        static void DeleteEnrollment(int id)
        {
            using (var context = new UniversityContext())
            {
                var enrollment = context.Enrollments.FirstOrDefault(e => e.Id == id);

                if (enrollment != null)
                {
                    context.Enrollments.Remove(enrollment);
                    context.SaveChanges();

                    Console.WriteLine($"Inscripción con Id {id} eliminada.");
                }
                else
                {
                    Console.WriteLine("Inscripción no encontrada.");
                }
            }
        }
    }
}
