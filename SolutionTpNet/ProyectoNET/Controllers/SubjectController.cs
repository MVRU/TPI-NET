using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;
using System;
using System.Linq;

namespace ProyectoNET.Controllers
{
    internal class SubjectController
        {
        public static void CreateSubject(string description, float requiredAttendancePercentage, float averageAttendancePercentage)
        {
            if (requiredAttendancePercentage < 0 || requiredAttendancePercentage > 100 ||
                averageAttendancePercentage < 0 || averageAttendancePercentage > 100)
            {
                Console.WriteLine("Error: Los porcentajes de asistencia deben estar entre 0 y 100.");
                return;
            }

            using (var context = new UniversityContext())
            {
                var subject = new Subject
                {
                    Description = description,
                    RequiredAttendancePercentage = requiredAttendancePercentage,
                    AverageAttendancePercentage = averageAttendancePercentage
                };

                context.Subjects.Add(subject);
                context.SaveChanges();
                Console.WriteLine($"Asignatura '{description}' fue creada con éxito.");
            }
        }

        public static void GetSubjectById(int id)
        {
            using (var context = new UniversityContext())
            {
                var subject = context.Subjects.FirstOrDefault(s => s.Id == id);

                if (subject != null)
                {
                    Console.WriteLine($"Asignatura encontrada: {subject.Description}");
                    Console.WriteLine($"Porcentaje de asistencia requerido: {subject.RequiredAttendancePercentage}%");
                    Console.WriteLine($"Promedio de asistencia: {subject.AverageAttendancePercentage}%");
                }
                else
                {
                    Console.WriteLine("Asignatura no encontrada.");
                }
            }
        }

        public static void UpdateSubject(int id, string newDescription, float newRequiredAttendancePercentage, float newAverageAttendancePercentage)
        {
            if (newRequiredAttendancePercentage < 0 || newRequiredAttendancePercentage > 100 ||
                newAverageAttendancePercentage < 0 || newAverageAttendancePercentage > 100)
            {
                Console.WriteLine("Error: Los porcentajes de asistencia deben estar entre 0 y 100.");
                return;
            }

            using (var context = new UniversityContext())
            {
                var subject = context.Subjects.FirstOrDefault(s => s.Id == id);

                if (subject != null)
                {
                    subject.Description = newDescription;
                    subject.RequiredAttendancePercentage = newRequiredAttendancePercentage;
                    subject.AverageAttendancePercentage = newAverageAttendancePercentage;
                    context.SaveChanges();
                    Console.WriteLine($"Asignatura con Id {id} fue actualizada con éxito.");
                }
                else
                {
                    Console.WriteLine("Asignatura no encontrada.");
                }
            }
        }

        public static void DeleteSubject(int id)
        {
            using (var context = new UniversityContext())
            {
                var subject = context.Subjects.FirstOrDefault(s => s.Id == id);

                if (subject != null)
                {
                    context.Subjects.Remove(subject);
                    context.SaveChanges();
                    Console.WriteLine($"Asignatura con Id {id} fue eliminada con éxito.");
                }
                else
                {
                    Console.WriteLine("Asignatura no encontrada.");
                }
            }
        }

        // Obtener todos los cursos asociados a una asignatura específica
        public static void GetCoursesBySubjectId(int subjectId)
        {
            using (var context = new UniversityContext())
            {
                var subject = context.Subjects
                    .Include(s => s.Courses)
                    .FirstOrDefault(s => s.Id == subjectId);

                if (subject != null && subject.Courses.Any())
                {
                    Console.WriteLine($"Cursos para la asignatura '{subject.Description}':");
                    foreach (var course in subject.Courses)
                    {
                        Console.WriteLine($"Año: {course.Year}, Fecha Inicio: {course.StartDate}, Fecha Fin: {course.EndDate}, Cupo: {course.Quota}");
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontraron cursos para la asignatura con Id {subjectId}.");
                }
            }
        }
    }
}