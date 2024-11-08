using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    public class SubjectController
    {
        private readonly SubjectRepository _subjectRepository;

        public SubjectController(SubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void CreateSubject(string description, float requiredAttendancePercentage, float averageAttendancePercentage)
        {
            if (requiredAttendancePercentage < 0 || requiredAttendancePercentage > 100 ||
                averageAttendancePercentage < 0 || averageAttendancePercentage > 100)
            {
                Console.WriteLine("Error: Los porcentajes de asistencia deben estar entre 0 y 100.");
                return;
            }

            var subject = new Subject
            {
                Description = description,
                RequiredAttendancePercentage = requiredAttendancePercentage,
                AverageAttendancePercentage = averageAttendancePercentage
            };

            _subjectRepository.CreateSubject(subject);
            Console.WriteLine($"Asignatura '{description}' fue creada con éxito.");
        }

        public void GetSubjectById(int id)
        {
            var subject = _subjectRepository.GetSubjectById(id);

            if (subject != null)
            {
                Console.WriteLine($"Asignatura encontrada: {subject.Description}");
                Console.WriteLine($"Porcentaje de asistencia requerido: {subject.RequiredAttendancePercentage}%");
                Console.WriteLine($"Promedio de asistencia: {subject.AverageAttendancePercentage}%");
            }
            else
            {
                Console.WriteLine("Asignatura no encontrada.");
            }
        }

        public void UpdateSubject(int id, string newDescription, float newRequiredAttendancePercentage, float newAverageAttendancePercentage)
        {
            if (newRequiredAttendancePercentage < 0 || newRequiredAttendancePercentage > 100 ||
                newAverageAttendancePercentage < 0 || newAverageAttendancePercentage > 100)
            {
                Console.WriteLine("Error: Los porcentajes de asistencia deben estar entre 0 y 100.");
                return;
            }

            var subject = _subjectRepository.GetSubjectById(id);

            if (subject != null)
            {
                subject.Description = newDescription;
                subject.RequiredAttendancePercentage = newRequiredAttendancePercentage;
                subject.AverageAttendancePercentage = newAverageAttendancePercentage;
                _subjectRepository.UpdateSubject(subject);

                Console.WriteLine($"Asignatura con Id {id} fue actualizada con éxito.");
            }
            else
            {
                Console.WriteLine("Asignatura no encontrada.");
            }
        }

        public void DeleteSubject(int id)
        {
            _subjectRepository.DeleteSubject(id);
            Console.WriteLine($"Asignatura con Id {id} fue eliminada con éxito.");
        }

        public void GetCoursesBySubjectId(int subjectId)
        {
            var courses = _subjectRepository.GetCoursesBySubjectId(subjectId);

            if (courses.Any())
            {
                Console.WriteLine($"Cursos para la asignatura con Id {subjectId}:");
                foreach (var course in courses)
                {
                    Console.WriteLine($"Año: {course.Year}, Fecha Inicio: {course.StartDate}, Fecha Fin: {course.EndDate}, Cupo: {course.Quota}");
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron cursos para la asignatura con Id {subjectId}.");
            }
        }

        // Obtener todas las asignaturas
        public List<Subject> GetAllSubjects()
        {
            return _subjectRepository.GetAllSubjects().ToList();
        }
    }
}