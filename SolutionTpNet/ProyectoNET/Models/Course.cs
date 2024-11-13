using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa un curso que se ofrece en un año específico, con detalles sobre
    /// las fechas de inicio y fin, la asignatura asociada, la cuota de estudiantes
    /// y las relaciones con los horarios, usuarios y matrículas.
    /// </summary>
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public int Year { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Quota { get; set; }

        // Relación con asignatura
        public int? SubjectId { get; set; } // Clave foránea

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; } // Propiedad de navegación

        // Relación con horarios
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

        // Relación con usuarios
        public ICollection<User> Users { get; set; } = new List<User>(); 

        // Relación con matrículas
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        // Esta propiedad solo se utilizará para la visualización (no se almacenará en la db)
        [NotMapped]
        public string SubjectDescription
        {
            get
            {
                // Si la asignatura está relacionada, concatenar Id y Descripción
                return Subject != null ? $"{Subject.Id} ({Subject.Description})" : "N/A";
            }
        }
    }
}
