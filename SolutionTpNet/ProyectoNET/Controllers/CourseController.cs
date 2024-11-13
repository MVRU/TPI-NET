using System;
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

        public void CreateCourse(int year, DateTime startDate, DateTime endDate, int quota, int? subjectId)
        {
            _repository.CreateCourse(year, startDate, endDate, quota, subjectId);
        }

        public Course GetCourseById(int id)
        {
            return _repository.GetCourseById(id);
        }

        public void UpdateCourse(int courseId, int year, DateTime startDate, DateTime endDate, int quota, int? subjectId)
        {
            _repository.UpdateCourse(courseId, year, startDate, endDate, quota, subjectId);
        }

        public void DeleteCourse(int id)
        {
            _repository.DeleteCourse(id);
        }

        public List<Course> GetAllCourses()
        {
            return _repository.GetAllCourses().ToList();
        }

    }
}
