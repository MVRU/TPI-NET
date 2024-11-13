using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    public class ScheduleController
    {
        private readonly ScheduleRepository _scheduleRepository;

        public ScheduleController(ScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public void CreateSchedule(string day, TimeSpan startTime, TimeSpan endTime)
        {
            // Verificar si ya existe un horario con los mismos parámetros
            if (_scheduleRepository.ScheduleExists(day, startTime, endTime))
            {
                Console.WriteLine("Ya existe un horario con el mismo día, hora de inicio y hora de fin.");
                throw new InvalidOperationException("Ya existe un horario con esos mismos parámetros.");
            }

            var schedule = new Schedule
            {
                Day = day,
                StartTime = startTime,
                EndTime = endTime
            };

            _scheduleRepository.CreateSchedule(schedule);
            Console.WriteLine("Horario creado con éxito.");
        }

        // Obtener todos los horarios
        public List<Schedule> GetAllSchedules()
        {
            return _scheduleRepository.GetAllSchedules().ToList();
        }

        // Obtener un horario por ID
        public Schedule GetScheduleById(int id)
        {
            return _scheduleRepository.GetScheduleById(id);
        }

        // Actualizar un horario existente
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

        // Eliminar un horario
        public void DeleteSchedule(int id)
        {
            _scheduleRepository.DeleteSchedule(id);
            Console.WriteLine($"Horario con Id {id} eliminado con éxito.");
        }

        // Obtener horarios de un curso específico
        public List<Schedule> GetSchedulesByCourseId(int courseId)
        {
            return _scheduleRepository.GetSchedulesByCourseId(courseId).ToList();
        }
    }
}
