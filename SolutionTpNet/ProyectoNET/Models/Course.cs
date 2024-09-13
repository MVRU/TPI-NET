using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "El Id de la Asignatura es obligatoria")]
        public int SubjectId { get; set; } // Foreign Key
        public Subject Subject { get; set; } // Propiedad de navegación
        public List<Schedule> Schedules { get; set; } = new List<Schedule>(); // Lista de horarios asociados al curso
    }
}