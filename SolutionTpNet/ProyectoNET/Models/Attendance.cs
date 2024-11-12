using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        public bool IsPresent
        {
            get => Timestamp != default; // Si se proporciona una fecha, se considera que el alumno asistió
        }

        [Required]
        public int EnrollmentId { get; set; } // Foreign Key

        [ForeignKey("EnrollmentId")]
        public Enrollment Enrollment { get; set; } // Propiedad de navegación
    }
}
