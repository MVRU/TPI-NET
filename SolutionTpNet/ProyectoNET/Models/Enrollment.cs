using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        public DateTime EnrollmentDate { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; } // Foreign Key
        public Course Course { get; set; } // Propiedad de navegación

        [ForeignKey("StatusId")]
        public int StatusId { get; set; } // Foreign Key
        public Status Status { get; set; } // Propiedad de navegación

        [ForeignKey("StudentId")]
        public string StudentId { get; set; } // Foreign Key
        public User Student { get; set; } // Propiedad de navegación
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
