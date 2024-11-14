using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    public class EnrollmentRepository
    {
        private readonly UniversityContext _context;

        public EnrollmentRepository(UniversityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

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

        public void DeleteEnrollment(int id)
        {
            try
            {
                // Buscar la matrícula por su ID, incluir el estado para evitar problemas de navegación.
                var enrollment = _context.Enrollments
                    .Include(e => e.Status) // Asegúrate de incluir el estado.
                    .FirstOrDefault(e => e.Id == id);

                if (enrollment != null)
                {
                    // Buscar el estado "Libre".
                    var libreStatus = _context.Statuses.FirstOrDefault(s => s.Description == "Libre");

                    if (libreStatus != null)
                    {
                        // Eliminar la relación actual de Status
                        enrollment.Status = libreStatus; // Asociar la matrícula con el estado "Libre".
                        _context.SaveChanges(); // Guardar los cambios.
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
        public Enrollment GetEnrollmentsByStudentAndCourse(string studentId, int courseId)
        {
            try
            {
                // Accede a las inscripciones y filtra por el estudiante y el curso
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

        // Método para obtener todas las matrículas
        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Status)
                .Include(e => e.Student)
                .ToList();
        }

        // Método para obtener matrículas por curso
        public IEnumerable<Enrollment> GetEnrollmentsByCourse(int courseId)
        {
            return _context.Enrollments
                .Where(e => e.CourseId == courseId)
                .Include(e => e.Course)
                .Include(e => e.Status)
                .Include(e => e.Student)
                .ToList();
        }

    }
}
