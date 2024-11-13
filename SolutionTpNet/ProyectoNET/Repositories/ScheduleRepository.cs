using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    public class ScheduleRepository
    {
        private readonly UniversityContext _context;

        public ScheduleRepository(UniversityContext context)
        {
            _context = context;
        }

        // Verificar si ya existe un horario con el mismo día, hora de inicio y hora de fin (sin importar el ID)
        public bool ScheduleExists(string day, TimeSpan startTime, TimeSpan endTime, int? excludedId = null)
        {
            return _context.Schedules
                .Any(s => s.Day == day && s.StartTime == startTime && s.EndTime == endTime && (!excludedId.HasValue || s.Id != excludedId.Value));
        }

        public void CreateSchedule(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }

        public Schedule GetScheduleById(int id)
        {
            return _context.Schedules
                .Include(s => s.Courses) // Incluir Courses en caso de necesitar acceder a los cursos asignados
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

        // Obtener horarios de un curso específico a través de la relación muchos a muchos
        public IEnumerable<Schedule> GetSchedulesByCourseId(int courseId)
        {
            return _context.Schedules
                .Include(s => s.Courses)
                .Where(s => s.Courses.Any(c => c.Id == courseId))
                .ToList();
        }

        // Obtener todos los horarios
        public IQueryable<Schedule> GetAllSchedules()
        {
            return _context.Schedules;
        }

        public IEnumerable<Schedule> GetSchedulesByDay(string day)
        {
            try
            {
                return _context.Schedules
                   .Where(s => s.Day.Equals(day, StringComparison.OrdinalIgnoreCase))
                   .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener horarios para el día {day}: {ex.Message}");
                return new List<Schedule>(); // Retornar una lista vacía en caso de error
            }
        }
    }
}
