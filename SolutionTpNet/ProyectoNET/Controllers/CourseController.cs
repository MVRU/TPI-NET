using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    public class CourseController
    {
        public readonly CourseRepository _repository;

        public CourseController(CourseRepository repository)
        {
            _repository = repository;
        }

        // Método para crear un nuevo curso
        public int? CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId, List<int> scheduleIds, List<string> professorFiles)
        {
            return _repository.CreateCourse(year, startDate, endDate, quota, subjectId, scheduleIds, professorFiles);
        }

        // Método para obtener un curso por ID
        public Course GetCourseById(int id)
        {
            return _repository.GetCourseById(id);
        }

        // Método para actualizar un curso
        public void UpdateCourse(int courseId, int year, DateTime startDate, DateTime endDate, int quota, int? subjectId, List<int> scheduleIds, List<string> professorFiles)
        {
            _repository.UpdateCourse(courseId, year, startDate, endDate, quota, subjectId, scheduleIds, professorFiles);
        }

        // Método para eliminar un curso
        public void DeleteCourse(int id)
        {
            _repository.DeleteCourse(id);
        }

        // Método para obtener todos los cursos
        public List<Course> GetAllCourses()
        {
            return _repository.GetAllCourses();
        }

        //// Método para obtener el total de clases del curso con ADO.NET
        //public int GetTotalClassesByCourse(int courseId)
        //{
        //    return _repository.GetTotalClassesByCourse(courseId);
        //}

        // Método para obtener el total de clases del curso con Entity Framework (EF)
        public int GetTotalClassesByCourseEF(int courseId)
        {
            return _repository.GetTotalClassesByCourseEF(courseId);
        }

        // Método para obtener el total de asistencias por curso
        public int GetTotalAttendanceByCourse(int courseId)
        {
            try
            {
                return _repository.GetTotalAttendanceByCourseEF(courseId);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (si es necesario)
                throw new Exception("Error al obtener el total de asistencias", ex);
            }
        }

        // Método para obtener el cumplimiento de cupo de un curso
        public (int totalEnrollments, int quota, double percentageFulfilled, double percentageAvailable) GetQuotaCompliance(int courseId)
        {
            try
            {
                // Llamamos al repositorio para obtener el cumplimiento de cupo
                return _repository.GetQuotaComplianceByCourse(courseId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cumplimiento de cupo", ex);
            }
        }
    }
}