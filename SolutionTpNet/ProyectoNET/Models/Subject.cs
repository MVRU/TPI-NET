using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    internal class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }

        [Range(0, 100, ErrorMessage = "El porcentaje de asistencia debe estar entre 0 y 100")]
        public float RequiredAttendancePercentage { get; set; }

        [Range(0, 100, ErrorMessage = "El porcentaje promedio de asistencia debe estar entre 0 y 100")]
        public float AverageAttendancePercentage { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>(); // Lista de Cursos de la Asignatura
    }
}
