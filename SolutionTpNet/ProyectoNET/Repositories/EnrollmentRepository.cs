using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace ProyectoNET.Repositories
{
    public class EnrollmentRepository
    {
        private readonly UniversityContext _context;
        private readonly string _connectionString;

        // Constructor que recibe el contexto de EF y la cadena de conexión
        public EnrollmentRepository(UniversityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _connectionString = _context.Database.GetConnectionString();
        }

        // Crear matrícula con Entity Framework
        public void CreateEnrollment(Enrollment enrollment)
        {
            try
            {
                _context.Enrollments.Add(enrollment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la inscripción: {ex.Message}");
                throw;
            }
        }

        // Obtener matrícula por ID con Entity Framework
        public Enrollment GetEnrollmentById(int id)
        {
            try
            {
                return _context.Enrollments
                    .Include(e => e.Course)
                    .Include(e => e.Attendances)
                    .Include(e => e.Status)
                    .Include(e => e.Student) // Incluye el estudiante (User)
                    .FirstOrDefault(e => e.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la inscripción: {ex.Message}");
                throw;
            }
        }

        // Actualizar matrícula con Entity Framework
        public void UpdateEnrollment(Enrollment enrollment)
        {
            try
            {
                _context.Enrollments.Update(enrollment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la inscripción: {ex.Message}");
                throw;
            }
        }

        // Eliminar matrícula (cambiar estado a "Libre") con Entity Framework
        public void DeleteEnrollment(int id)
        {
            try
            {
                var enrollment = _context.Enrollments
                    .Include(e => e.Status) // Asegúrate de incluir el estado
                    .FirstOrDefault(e => e.Id == id);

                if (enrollment != null)
                {
                    var libreStatus = _context.Statuses.FirstOrDefault(s => s.Description == "Libre");

                    if (libreStatus != null)
                    {
                        enrollment.Status = libreStatus; // Cambiar el estado a "Libre"
                        _context.SaveChanges();
                    }
                    else
                    {
                        throw new InvalidOperationException("No se encontró el estado 'Libre'.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al dar de baja la inscripción: {ex.Message}");
                throw;
            }
        }

        // Obtener matrículas por ID de estudiante con Entity Framework
        public IEnumerable<Enrollment> GetEnrollmentsByStudentId(string studentId)
        {
            try
            {
                return _context.Enrollments
                    .Include(e => e.Course)
                    .Include(e => e.Status)
                    .Include(e => e.Student)
                    .Where(e => e.StudentId == studentId)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las matrículas: {ex.Message}");
                throw;
            }
        }

        // Obtener asistencias por ID de matrícula con Entity Framework
        public IEnumerable<Attendance> GetAttendancesByEnrollmentId(int enrollmentId)
        {
            try
            {
                var enrollment = _context.Enrollments
                    .Include(e => e.Attendances)
                    .FirstOrDefault(e => e.Id == enrollmentId);

                return enrollment?.Attendances ?? Enumerable.Empty<Attendance>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las asistencias: {ex.Message}");
                throw;
            }
        }

        // Obtener matrícula por estudiante y curso con Entity Framework
        public Enrollment GetEnrollmentsByStudentAndCourse(string studentId, int courseId)
        {
            try
            {
                return _context.Enrollments
                    .Include(e => e.Course)
                    .Include(e => e.Status)
                    .Include(e => e.Student)
                    .FirstOrDefault(e => e.StudentId == studentId && e.CourseId == courseId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la matrícula: {ex.Message}");
                throw;
            }
        }

        // Obtener todas las matrículas con Entity Framework
        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Status)
                .Include(e => e.Student)
                .ToList();
        }

        // Obtener matrículas por curso con Entity Framework
        public IEnumerable<Enrollment> GetEnrollmentsByCourse(int courseId)
        {
            return _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .Include(e => e.Course)
                .Include(e => e.Status)
                .Include(e => e.Student)
                .ToList();
        }

        // Consultas ADO.NET para obtener estadísticas de matrícula por estado
        public IEnumerable<StudentEnrollmentStatus> GetEnrollmentStatsByCourse(int courseId)
        {
            var stats = new List<StudentEnrollmentStatus>();

            string query = @"
                SELECT 
                    s.Description AS StatusDescription, 
                    COUNT(e.StudentId) AS StudentCount
                FROM 
                    Enrollments e
                JOIN 
                    Statuses s ON e.StatusId = s.Id
                WHERE 
                    e.CourseId = @CourseId
                GROUP BY 
                    s.Description
                ORDER BY 
                    StudentCount DESC;
            ";

            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseId", courseId);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var status = new StudentEnrollmentStatus
                            {
                                StatusDescription = reader["StatusDescription"].ToString(),
                                StudentCount = Convert.ToInt32(reader["StudentCount"])
                            };
                            stats.Add(status);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener las estadísticas de matrícula: {ex.Message}");
                    throw;
                }
            }

            return stats;
        }

        public IEnumerable<StudentEnrollmentStatus> GetEnrollmentStatsByCourseEF(int courseId)
        {
            var stats = _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .GroupBy(e => e.Status.Description)
                .Select(g => new StudentEnrollmentStatus
                {
                    StatusDescription = g.Key,
                    StudentCount = g.Count()
                })
                .OrderByDescending(s => s.StudentCount)
                .ToList();

            return stats;
        }
    }

    // Modelo para las estadísticas de matrícula
    public class StudentEnrollmentStatus
    {
        public string StatusDescription { get; set; }
        public int StudentCount { get; set; }
    }
}
