using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    internal class ScheduleRepository
    {
        private readonly UniversityContext _context;

        public ScheduleRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateSchedule(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }

        public Schedule GetScheduleById(int id)
        {
            return _context.Schedules
                .Include(s => s.Course) // Incluir Course si es necesario
                .FirstOrDefault(s => s.Id == id);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            _context.Schedules.Update(schedule);
            _context.SaveChanges();
        }

        public void DeleteSchedule(int id)
        {
            var schedule = _context.Schedules.Find(id);
            if (schedule != null)
            {
                _context.Schedules.Remove(schedule);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Schedule> GetSchedulesByCourseId(int courseId)
        {
            return _context.Schedules
                .Where(s => s.CourseId == courseId)
                .ToList();
        }
    }
}
