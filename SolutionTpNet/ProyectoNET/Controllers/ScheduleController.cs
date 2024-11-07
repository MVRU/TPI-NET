using System;
using System.Collections.Generic;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    internal class ScheduleController
    {
        private readonly ScheduleRepository _scheduleRepository;

        public ScheduleController(ScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public void CreateSchedule(string day, TimeSpan startTime, TimeSpan endTime, int courseId)
        {
            var schedule = new Schedule
            {
                Day = day,
                StartTime = startTime,
                EndTime = endTime,
                CourseId = courseId
            };

            _scheduleRepository.CreateSchedule(schedule);
            Console.WriteLine($"Horario para el curso {courseId} creado con éxito.");
        }

        public void GetScheduleById(int id)
        {
            var schedule = _scheduleRepository.GetScheduleById(id);

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

        public void UpdateSchedule(int id, string newDay, TimeSpan newStartTime, TimeSpan newEndTime)
        {
            var schedule = _scheduleRepository.GetScheduleById(id);

            if (schedule != null)
            {
                schedule.Day = newDay;
                schedule.StartTime = newStartTime;
                schedule.EndTime = newEndTime;
                _scheduleRepository.UpdateSchedule(schedule);

                Console.WriteLine($"Horario con Id {id} actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("Horario no encontrado.");
            }
        }

        public void DeleteSchedule(int id)
        {
            _scheduleRepository.DeleteSchedule(id);
            Console.WriteLine($"Horario con Id {id} eliminado con éxito.");
        }

        public void GetSchedulesByCourseId(int courseId)
        {
            var schedules = _scheduleRepository.GetSchedulesByCourseId(courseId);

            if (schedules.Any())
            {
                Console.WriteLine($"Horarios para el curso {courseId}:");
                foreach (var schedule in schedules)
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
