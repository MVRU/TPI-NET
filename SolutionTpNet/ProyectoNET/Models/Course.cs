using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quota { get; set; }

        [Required(ErrorMessage = "El Id de la Asignatura es obligatorio")]
        public int? SubjectId { get; set; } // Foreign Key

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; } // Propiedad de navegación

        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>(); // Relación uno a muchos con Schedules
        public ICollection<Professor> Professors { get; set; } = new List<Professor>(); // Relación muchos a muchos con Professor/s
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // Relación uno a muchos con Enrollments
    }
}