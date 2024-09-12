using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNET
{
    internal class CourseController
    {
        // crear curso
        static void CreateCourse(int year, DateTime fechaIni, DateTime fechaFin, int quota)
        {
            using (var context = new UniversityContext())
            {
                var course = new Course
                {
                    Year = year,
                    FechaIni = fechaIni,
                    FechaFin = fechaFin,
                    Quota = quota
                };

                context.Courses.Add(course);
                context.SaveChanges();

                // cambiar en la implementacion

                Console.WriteLine($"Curso del año {year} creado con éxito.");
            }
        }

        // Método para leer un curso por su Id
        static void GetCourseById(int id)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);


                // cambiar en la implementacion
                if (course != null)
                {
                    Console.WriteLine($"Curso encontrado: Año {course.Year}");
                    Console.WriteLine($"Fecha Inicio: {course.FechaIni}");
                    Console.WriteLine($"Fecha Fin: {course.FechaFin}");
                    Console.WriteLine($"Cupo: {course.Quota}");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        // actualizar curso
        static void UpdateCourse(int id, int newQuota)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);

                // cambiar en implementacion

                if (course != null)
                {
                    course.Quota = newQuota;
                    context.SaveChanges();

                    Console.WriteLine($"Cupo del curso con Id {id} actualizado a {newQuota}.");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        // Método para eliminar un curso
        static void DeleteCourse(int id)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);

                // cambiar en implementacion

                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();

                    Console.WriteLine($"Curso con Id {id} eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }
    }
}

