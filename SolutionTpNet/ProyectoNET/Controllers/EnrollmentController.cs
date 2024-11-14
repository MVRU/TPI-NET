using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    public class EnrollmentController
    {
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly CourseRepository _courseRepository;

        public EnrollmentController(EnrollmentRepository enrollmentRepository, CourseRepository courseRepository)
        {
            _enrollmentRepository = enrollmentRepository;
            _courseRepository = courseRepository;
        }

        public void CreateEnrollment(string studentId, int courseId, DateTime enrollmentDate, int statusId)
        {
            try
            {
                var enrollment = new Enrollment
                {
                    StudentId = studentId,
                    CourseId = courseId,
                    EnrollmentDate = enrollmentDate,
                    StatusId = statusId
                };

                _enrollmentRepository.CreateEnrollment(enrollment);
                Console.WriteLine($"Inscripción creada con éxito para el curso con Id {courseId} y estudiante con Legajo {studentId}.");
            }
            catch (Exception ex)
            {
                // Loguear error y manejar la excepción
                Console.WriteLine($"Error al crear la inscripción: {ex.Message}");
                throw;
            }
        }

        // Obtener la descripción del Subject para un Enrollment dado
        public string GetCourseDescription(int enrollmentId)
        {
            var enrollment = _enrollmentRepository.GetEnrollmentById(enrollmentId);
            if (enrollment != null && enrollment.Course != null && enrollment.Course.Subject != null)
            {
                return enrollment.Course.Subject.Description;
            }
            return "Sin descripción"; // Valor predeterminado si no se encuentra la descripción
        }

        public Enrollment GetEnrollmentById(int id)
        {
            try
            {
                var enrollment = _enrollmentRepository.GetEnrollmentById(id);

                if (enrollment != null)
                {
                    return enrollment;
                }

                Console.WriteLine("Inscripción no encontrada.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la inscripción: {ex.Message}");
                throw;
            }
        }


        public void UpdateEnrollment(int enrollmentId, DateTime enrollmentDate, int courseId, int statusId)
        {
            try
            {
                var enrollment = _enrollmentRepository.GetEnrollmentById(enrollmentId); // Usamos enrollmentId aquí
                if (enrollment != null)
                {
                    enrollment.EnrollmentDate = enrollmentDate;
                    enrollment.CourseId = courseId;
                    enrollment.StatusId = statusId;

                    _enrollmentRepository.UpdateEnrollment(enrollment);
                    Console.WriteLine($"Inscripción con Id {enrollmentId} actualizada con éxito.");
                }
                else
                {
                    Console.WriteLine("Inscripción no encontrada.");
                }
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
                _enrollmentRepository.DeleteEnrollment(id);
                Console.WriteLine($"Inscripción con Id {id} eliminada con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la inscripción: {ex.Message}");
                throw;
            }
        }

        public List<Enrollment> GetEnrollmentsByStudentId(string studentId)
        {
            try
            {
                return _enrollmentRepository.GetEnrollmentsByStudentId(studentId).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las matrículas: {ex.Message}");
                throw;
            }
        }

        public Enrollment GetEnrollmentByStudentAndCourse(string studentId, int courseId, DateTime enrollmentDate)
        {
            // Utilizamos el repositorio para obtener las inscripciones del estudiante en el curso específico
            return _enrollmentRepository.GetEnrollmentsByStudentAndCourse(studentId, courseId);
        }

        // Método que obtiene todas las matrículas
        public List<Enrollment> GetAllEnrollments()
        {
            try
            {
                return _enrollmentRepository.GetAllEnrollments().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las matrículas: {ex.Message}");
                throw;
            }
        }

        // Método que obtiene matrícula por curso (sin necesidad de estudiante específico)
        public Enrollment GetEnrollmentByCourse(int courseId)
        {
            try
            {
                return _enrollmentRepository.GetEnrollmentsByCourse(courseId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar matrícula para el curso: {ex.Message}");
                throw;
            }
        }

        // Todos los cursos habilitados para inscripción
        public List<Course> GetAllCourses(DateTime enrollmentDate)
        {
            var allCourses = _courseRepository.GetAllCourses();

            // Filtrar los cursos en base al cupo y al rango de fechas
            return allCourses.Where(course =>
                course.Quota > _enrollmentRepository.GetEnrollmentsByCourse(course.Id).Count() && // Asegura que no se exceda el cupo
                enrollmentDate >= course.StartDate && enrollmentDate <= course.EndDate // Fecha de matrícula entre el rango de fechas del curso
            ).ToList();
        }

        public List<StudentEnrollmentStatus> GetEnrollmentStatsByCourse(int courseId)
        {
            try
            {
                return _enrollmentRepository.GetEnrollmentStatsByCourse(courseId).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las estadísticas de matrícula para el curso con Id {courseId}: {ex.Message}");
                throw;
            }
        }

        public List<StudentEnrollmentStatus> GetEnrollmentStatsByCourseEF(int courseId)
        {
            try
            {
                return _enrollmentRepository.GetEnrollmentStatsByCourseEF(courseId).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las estadísticas de matrícula para el curso con Id {courseId}: {ex.Message}");
                throw;
            }
        }

        // Método agregado: Obtener matrículas con usuarios (estudiantes) por curso
        public List<EnrollmentWithUser> GetEnrollmentsWithUsersByCourse(int courseId)
        {
            var enrollments = _enrollmentRepository.GetEnrollmentsByCourse(courseId)
                .Select(e => new EnrollmentWithUser
                {
                    Enrollment = e,
                    User = e.Student // Cambié Student a User aquí
                })
                .ToList();

            return enrollments;
        }
    }

    // Clase auxiliar para devolver matrícula junto con el usuario (estudiante)
    public class EnrollmentWithUser
    {
        public Enrollment Enrollment { get; set; }
        public User User { get; set; }

        public string StatusDescription
        {
            get
            {
                return Enrollment?.Status?.Description; // Acceso al estado de la matrícula
            }
        }
    }
}