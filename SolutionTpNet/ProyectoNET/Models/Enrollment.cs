using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa una matrícula de un estudiante en un curso específico.
    /// La clase Enrollment contiene información sobre el curso, el estado de la matrícula,
    /// el estudiante y sus asistencias.
    /// </summary>
    internal class Enrollment
    {
        [Key]
        public int Id { get; set; }

        public DateTime EnrollmentDate { get; set; }

        // Relación con curso
        [ForeignKey("CourseId")]
        public int CourseId { get; set; } // Clave foránea
        public Course Course { get; set; } // Propiedad de navegación

        // Relación con estado
        [ForeignKey("StatusId")]
        public int StatusId { get; set; } // Clave foránea
        public Status Status { get; set; } // Propiedad de navegación

        // Relación con estudiante
        [ForeignKey("StudentId")]
        public string StudentId { get; set; } // Clave foránea
        public User Student { get; set; } // Propiedad de navegación

        // Relación con asistencias
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
