using System;
using System.Linq;
using System.Windows.Forms;
using ProyectoNET.Models;

namespace ProyectoNET
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            // Crea datos de prueba al iniciar la aplicación
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new frmMain());

                using (var context = new UniversityContext())
                {
                    // Crear datos de prueba
                    var subject1 = new Subject { Description = "Matemática Discreta", RequiredAttendancePercentage = 75 };
                    var subject2 = new Subject { Description = "Análisis de Sistemas", RequiredAttendancePercentage = 80 };

                    context.Subjects.AddRange(subject1, subject2);
                    context.SaveChanges();

                    int subject1Id = subject1.Id;
                    int subject2Id = subject2.Id;

                    var course1 = new Course
                    {
                        Year = 2024,
                        StartDate = new DateTime(2024, 1, 10),
                        EndDate = new DateTime(2024, 6, 15),
                        Quota = 30,
                        SubjectId = subject1Id
                    };

                    var course2 = new Course
                    {
                        Year = 2024,
                        StartDate = new DateTime(2024, 2, 1),
                        EndDate = new DateTime(2024, 7, 15),
                        Quota = 25,
                        SubjectId = subject2Id
                    };

                    context.Courses.AddRange(course1, course2);
                    context.SaveChanges();

                    int course1Id = course1.Id;
                    int course2Id = course2.Id;

                    var schedule1 = new Schedule
                    {
                        Day = "Lunes",
                        StartTime = new TimeSpan(9, 0, 0),
                        EndTime = new TimeSpan(11, 0, 0),
                        CourseId = course1Id
                    };

                    var schedule2 = new Schedule
                    {
                        Day = "Miércoles",
                        StartTime = new TimeSpan(14, 0, 0),
                        EndTime = new TimeSpan(16, 0, 0),
                        CourseId = course2Id
                    };

                    context.Schedules.AddRange(schedule1, schedule2);
                    context.SaveChanges();

                    Console.WriteLine("Datos de prueba creados con éxito.");
                }

                // Evitar que la consola se cierre inmediatamente
                Console.WriteLine("Presiona Enter para salir...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción que ocurra
                Console.WriteLine($"Se produjo un error: {ex.Message}");
                Console.WriteLine("Presiona Enter para salir...");
                Console.ReadLine();
            }
        }
    }
}