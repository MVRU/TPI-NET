using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa una asignatura o materia en el sistema.
    /// La clase Subject contiene información sobre la descripción de la asignatura,
    /// el porcentaje de asistencia requerido y el promedio de asistencia, además
    /// de los cursos asociados a esa asignatura.
    /// </summary>
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }

        [Range(0, 100, ErrorMessage = "El porcentaje de asistencia debe estar entre 0 y 100")]
        public float RequiredAttendancePercentage { get; set; }

        // Este atributo no tiene ningún sentido
        // [Range(0, 100, ErrorMessage = "El porcentaje promedio de asistencia debe estar entre 0 y 100")]
        // public float AverageAttendancePercentage { get; set; }

        // Relación con cursos
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
