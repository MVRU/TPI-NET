using System;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    internal class CourseController
    {
        private readonly CourseRepository _repository;

        public CourseController(CourseRepository repository)
        {
            _repository = repository;
        }

        public void CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int subjectId)
        {
            if (startDate >= endDate)
            {
                Console.WriteLine("Error: La fecha de inicio debe ser anterior a la fecha de finalización.");
                return;
            }

            if (quota <= 0)
            {
                Console.WriteLine("Error: El cupo debe ser mayor a cero.");
                return;
            }

            var course = new Course
            {
                Year = year,
                StartDate = startDate,
                EndDate = endDate,
                Quota = quota,
                SubjectId = subjectId
            };

            _repository.CreateCourse(course);
            Console.WriteLine($"Curso del año {year} fue creado con éxito.");
        }

        public void GetCourseById(int id)
        {
            var course = _repository.GetCourseById(id);
            if (course != null)
            {
                Console.WriteLine($"Curso encontrado: Año {course.Year}, Asignatura: {course.Subject.Description}");
            }
            else
            {
                Console.WriteLine("Curso no encontrado.");
            }
        }

        public void UpdateCourse(int id, int newYear, DateTime newStartDate, DateTime newEndDate, int newQuota, int newSubjectId)
        {
            var course = _repository.GetCourseById(id);

            if (course == null)
            {
                Console.WriteLine("Curso no encontrado.");
                return;
            }

            if (newStartDate >= newEndDate)
            {
                Console.WriteLine("Error: La fecha de inicio debe ser anterior a la fecha de finalización.");
                return;
            }

            if (newQuota <= 0)
            {
                Console.WriteLine("Error: El cupo debe ser mayor a cero.");
                return;
            }

            course.Year = newYear;
            course.StartDate = newStartDate;
            course.EndDate = newEndDate;
            course.Quota = newQuota;
            course.SubjectId = newSubjectId;

            _repository.UpdateCourse(course);
            Console.WriteLine($"Curso con Id {id} fue actualizado con éxito.");
        }

        public void DeleteCourse(int id)
        {
            _repository.DeleteCourse(id);
            Console.WriteLine($"Curso con Id {id} fue eliminado con éxito.");
        }
    }
}
