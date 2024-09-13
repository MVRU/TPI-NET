using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;
using System;
using System.Linq;

namespace ProyectoNET.Controllers
{
    internal class ScheduleController
    {
        // Crear un nuevo Schedule
        static void CreateSchedule(string day, TimeSpan startTime, TimeSpan endTime, int courseId)
        {
            using (var context = new UniversityContext())
            {
                var schedule = new Schedule
                {
                    Day = day,
                    StartTime = startTime,
                    EndTime = endTime,
                    CourseId = courseId
                };

                context.Schedules.Add(schedule);
                context.SaveChanges();

                Console.WriteLine($"Horario para el curso {courseId} creado con éxito.");
            }
        }

        // Método para leer un Schedule por su Id
        static void GetScheduleById(int id)
        {
            using (var context = new UniversityContext())
            {
                var schedule = context.Schedules.FirstOrDefault(s => s.Id == id);

                if (schedule != null)
                {
                    Console.WriteLine($"Horario encontrado: Día {schedule.Day}");
                    Console.WriteLine($"Hora de inicio: {schedule.StartTime}");
                    Console.WriteLine($"Hora de fin: {schedule.EndTime}");
                    Console.WriteLine($"Curso asociado: {schedule.CourseId}");
                }
                else
                {
                    Console.WriteLine("Horario no encontrado.");
                }
            }
        }

        // Actualizar un Schedule existente
        static void UpdateSchedule(int id, string newDay, TimeSpan newStartTime, TimeSpan newEndTime)
        {
            using (var context = new UniversityContext())
            {
                var schedule = context.Schedules.FirstOrDefault(s => s.Id == id);

                if (schedule != null)
                {
                    schedule.Day = newDay;
                    schedule.StartTime = newStartTime;
                    schedule.EndTime = newEndTime;
                    context.SaveChanges();

                    Console.WriteLine($"Horario con Id {id} actualizado con éxito.");
                }
                else
                {
                    Console.WriteLine("Horario no encontrado.");
                }
            }
        }

        // Eliminar un Schedule por su Id
        static void DeleteSchedule(int id)
        {
            using (var context = new UniversityContext())
            {
                var schedule = context.Schedules.FirstOrDefault(s => s.Id == id);

                if (schedule != null)
                {
                    context.Schedules.Remove(schedule);
                    context.SaveChanges();

                    Console.WriteLine($"Horario con Id {id} eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Horario no encontrado.");
                }
            }
        }

        // Obtener todos los horarios de un curso específico
        static void GetSchedulesByCourseId(int courseId)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses
                    .Include(c => c.Schedules) // Incluir la lista de Schedules
                    .FirstOrDefault(c => c.Id == courseId);

                if (course != null && course.Schedules.Count > 0)
                {
                    Console.WriteLine($"Horarios para el curso {courseId}:");
                    foreach (var schedule in course.Schedules)
                    {
                        Console.WriteLine($"Día: {schedule.Day}, Hora de inicio: {schedule.StartTime}, Hora de fin: {schedule.EndTime}");
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontraron horarios para el curso {courseId}.");
                }
            }
        }
    }
}