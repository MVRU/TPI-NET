using ProyectoNET.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;

namespace ProyectoNET.Repositories
{
    public class CourseRepository
    {
        public readonly UniversityContext _context;

        public CourseRepository(UniversityContext context)
        {
            _context = context;
        }


        // Método para verificar si ya existe un curso con los mismos parámetros
        public bool CourseExists(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId, int? excludedId = null)
        {
            return _context.Courses
                .Any(c => c.Year == year
                       && c.StartDate.Date == startDate.Date // Comparar solo la fecha sin la hora
                       && c.EndDate.Date == endDate.Date // Comparar solo la fecha sin la hora
                       && c.Quota == quota
                       && c.SubjectId == subjectId
                       && (!excludedId.HasValue || c.Id != excludedId.Value));
        }

        public int? CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId, List<int> scheduleIds)
        {
            // Verificar si ya existe un curso con los mismos parámetros
            if (CourseExists(year, startDate, endDate, quota, subjectId))
            {
                throw new InvalidOperationException("Ya existe un curso con los mismos parámetros.");
            }

            // Verificar si el SubjectId existe en la base de datos
            if (subjectId.HasValue && !_context.Subjects.Any(s => s.Id == subjectId.Value))
            {
                throw new ArgumentException("El SubjectId proporcionado no es válido.");
            }

            var course = new Course
            {
                Year = year,
                StartDate = startDate,
                EndDate = endDate,
                Quota = quota,
                SubjectId = subjectId // Puede ser null si no se seleccionó una asignatura
            };

            // Obtener los horarios seleccionados por el usuario
            var schedules = _context.Schedules.Where(s => scheduleIds.Contains(s.Id)).ToList();
            course.Schedules = schedules;

            _context.Courses.Add(course);
            _context.SaveChanges();

            // Devuelve el ID del curso recién creado
            return course.Id;
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses
                .FirstOrDefault(c => c.Id == id); // Aquí no incluimos las relaciones
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses
                .Include(c => c.Subject) // Incluye la relación con Subject para acceder a Id y Description
                .Include(c => c.Schedules)
                .Include(c => c.Users)
                .Include(c => c.Enrollments)
                .ToList();
        }

        public void UpdateCourse(int courseId, int year, DateTime startDate, DateTime endDate, int quota, int? subjectId, List<int> scheduleIds)
        {
            var course = GetCourseById(courseId);
            if (course != null)
            {
                // Verificar si ya existe un curso con los mismos parámetros (sin contar el curso actual)
                if (CourseExists(year, startDate, endDate, quota, subjectId, courseId))
                {
                    throw new InvalidOperationException("Ya existe un curso con los mismos parámetros.");
                }

                course.Year = year;
                course.StartDate = startDate;
                course.EndDate = endDate;
                course.Quota = quota;
                course.SubjectId = subjectId;

                // Obtener los horarios seleccionados
                var schedules = _context.Schedules.Where(s => scheduleIds.Contains(s.Id)).ToList();
                course.Schedules = schedules; // Actualizar la relación de horarios

                _context.Courses.Update(course);
                _context.SaveChanges();
            }
        }

        public void DeleteCourse(int id)
        {
            var course = GetCourseById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public int GetTotalAttendanceByCourseEF(int courseId)
        {
            // Obtener el total de enrollments asociados al curso
            var totalAttendances = _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .Count();

            return totalAttendances;
        }

        // Método para obtener el cumplimiento de cupo de un curso
        public (int totalEnrollments, int quota, double percentageFulfilled, double percentageAvailable) GetQuotaComplianceByCourse(int courseId)
        {
            // Obtener el curso junto con la cuota asignada
            var course = _context.Courses
                .FirstOrDefault(c => c.Id == courseId);

            if (course == null)
            {
                throw new Exception("Curso no encontrado.");
            }

            // Obtener el total de inscripciones (enrollments) para este curso
            var totalEnrollments = _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .Count();

            // Calcular el porcentaje de cumplimiento del cupo
            double percentageFulfilled = 0;
            if (course.Quota > 0)
            {
                percentageFulfilled = (double)totalEnrollments / course.Quota * 100;
            }

            // Calcular el porcentaje de cupo disponible
            double percentageAvailable = 0;
            if (course.Quota > 0)
            {
                percentageAvailable = ((double)(course.Quota - totalEnrollments) / course.Quota) * 100;
            }

            // Retornar los resultados en una tupla
            return (totalEnrollments, course.Quota, percentageFulfilled, percentageAvailable);
        }


//// Método para calcular el total de clases con ADO.NET
//public int GetTotalClassesByCourse(int courseId)
//{
//    // Mapeo de los días de la semana a valores numéricos
//    var daysOfWeek = new Dictionary<string, int>
//    {
//        { "Lunes", 1 },
//        { "Martes", 2 },
//        { "Miércoles", 3 },
//        { "Jueves", 4 },
//        { "Viernes", 5 },
//        { "Sábado", 6 },
//        { "Domingo", 7 }
//    };

//    string query = @"
//        SELECT COUNT(DISTINCT s.Day) AS UniqueDaysCount
//        FROM Courses c
//        JOIN Schedules s ON c.Id = s.CourseId
//        WHERE c.Id = @CourseId
//        AND s.Day BETWEEN @StartDate AND @EndDate
//    ";

//    using (var connection = new SqlConnection(_connectionString))
//    {
//        SqlCommand command = new SqlCommand(query, connection);
//        command.Parameters.AddWithValue("@CourseId", courseId);

//        // Obtener la fecha de inicio y fin del curso
//        var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
//        if (course == null)
//        {
//            throw new Exception("Curso no encontrado.");
//        }

//        command.Parameters.AddWithValue("@StartDate", course.StartDate);
//        command.Parameters.AddWithValue("@EndDate", course.EndDate);

//        try
//        {
//            connection.Open();
//            int totalClasses = 0;
//            using (var reader = command.ExecuteReader())
//            {
//                if (reader.Read())
//                {
//                    totalClasses = reader.GetInt32(reader.GetOrdinal("UniqueDaysCount"));
//                }
//            }
//            return totalClasses;
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error al calcular las clases del curso: {ex.Message}");
//            throw;
//        }
//    }
//}


// Método para calcular el total de clases con Entity Framework (EF)
public int GetTotalClassesByCourseEF(int courseId)
        {
            // Mapeo de los días de la semana a valores numéricos (en español)
            var daysOfWeek = new Dictionary<string, int>
    {
        { "Lunes", 1 },
        { "Martes", 2 },
        { "Miércoles", 3 },
        { "Jueves", 4 },
        { "Viernes", 5 },
        { "Sábado", 6 },
        { "Domingo", 7 }
    };

            var course = _context.Courses
                .Include(c => c.Schedules)
                .FirstOrDefault(c => c.Id == courseId);

            if (course == null)
            {
                throw new Exception("Curso no encontrado.");
            }

            // Convertir el DayOfWeek de C# (que es en inglés) al nombre en español
            string startDay = course.StartDate.DayOfWeek.ToString();
            string endDay = course.EndDate.DayOfWeek.ToString();

            // Mapeo para obtener el nombre en español
            string startDayInSpanish = GetDayInSpanish(startDay);
            string endDayInSpanish = GetDayInSpanish(endDay);

            // Filtramos los días únicos en los que se imparten clases (convertimos Day a número)
            var uniqueDays = course.Schedules
                .Where(s =>
                    daysOfWeek.ContainsKey(s.Day) &&
                    daysOfWeek[s.Day] >= daysOfWeek[startDayInSpanish] &&
                    daysOfWeek[s.Day] <= daysOfWeek[endDayInSpanish]
                )
                .Select(s => s.Day)
                .Distinct()
                .ToList();

            return uniqueDays.Count();
        }

        // Función para mapear el DayOfWeek de C# (en inglés) al día en español
        private string GetDayInSpanish(string day)
        {
            switch (day)
            {
                case "Monday": return "Lunes";
                case "Tuesday": return "Martes";
                case "Wednesday": return "Miércoles";
                case "Thursday": return "Jueves";
                case "Friday": return "Viernes";
                case "Saturday": return "Sábado";
                case "Sunday": return "Domingo";
                default: throw new ArgumentException("Día no válido");
            }
        }
    }
}