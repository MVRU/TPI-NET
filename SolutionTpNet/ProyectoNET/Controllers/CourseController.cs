using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;
using System;
using System.Linq;

namespace ProyectoNET.Controllers
{
    internal class CourseController
    {
        public static void CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int subjectId)
        {
            if (startDate >= endDate) // Validar que la fecha de inicio sea menor que la de finalización
            {
                Console.WriteLine("Error: La fecha de inicio debe ser anterior a la fecha de finalización.");
                return;
            }

            if (quota <= 0) // Validar que el cupo sea un valor positivo
            {
                Console.WriteLine("Error: El cupo debe ser mayor a cero.");
                return;
            }

            using (var context = new UniversityContext())
            {
                var course = new Course
                {
                    Year = year,
                    StartDate = startDate,
                    EndDate = endDate,
                    Quota = quota,
                    SubjectId = subjectId
                };

                context.Courses.Add(course);
                context.SaveChanges();

                Console.WriteLine($"Curso del año {year} fue creado con éxito.");
            }
        }

        public static void GetCourseById(int id)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses
                    .Include(c => c.Subject) // Incluir la relación con Subject
                    .FirstOrDefault(c => c.Id == id);

                if (course != null)
                {
                    Console.WriteLine($"Curso encontrado: Año {course.Year}");
                    Console.WriteLine($"Fecha Inicio: {course.StartDate}");
                    Console.WriteLine($"Fecha Fin: {course.EndDate}");
                    Console.WriteLine($"Cupo: {course.Quota}");
                    Console.WriteLine($"Asignatura: {course.Subject.Description}"); // Accede directamente a la descripción

                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        public static void UpdateCourse(int id, int newYear, DateTime newStartDate, DateTime newEndDate, int newQuota, int newSubjectId)
        {
            if (newStartDate >= newEndDate) // Validar que la fecha de inicio sea menor que la de finalización
            {
                Console.WriteLine("Error: La fecha de inicio debe ser anterior a la fecha de finalización.");
                return;
            }

            if (newQuota <= 0) // Validar que el cupo sea un valor positivo
            {
                Console.WriteLine("Error: El cupo debe ser mayor a cero.");
                return;
            }

            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);

                if (course != null)
                {
                    course.Year = newYear;
                    course.StartDate = newStartDate;
                    course.EndDate = newEndDate;
                    course.Quota = newQuota;
                    course.SubjectId = newSubjectId;

                    context.SaveChanges();
                    Console.WriteLine($"Curso con Id {id} fue actualizado con éxito.");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        public static void DeleteCourse(int id)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);

                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();
                    Console.WriteLine($"Curso con Id {id} fue eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        // Método para obtener la descripción de una asignatura (Subject) a partir de su Id
        public string GetSubjectDescription(int subjectId, List<Subject> subjects)
        {
            var subject = subjects.FirstOrDefault(s => s.Id == subjectId);
            return subject != null ? subject.Description : "Asignatura no encontrada.";
        }
    }
}