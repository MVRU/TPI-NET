using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa la asistencia de un estudiante a un curso en una matrícula específica.
    /// La clase Attendance contiene información sobre la fecha de asistencia,
    /// el estado de presencia y la relación con la matrícula del estudiante.
    /// </summary>
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Obtiene si el estudiante está presente en función de la fecha de asistencia.
        /// Si se proporciona una fecha en el campo Timestamp, se considera que el estudiante asistió.
        /// </summary>
        public bool IsPresent
        {
            get => Timestamp != default;
        }

        // Relación con matrícula
        [Required]
        public int EnrollmentId { get; set; } // Clave foránea

        [ForeignKey("EnrollmentId")]
        public Enrollment Enrollment { get; set; } // Propiedad de navegación
    }
}
