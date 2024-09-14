using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    internal abstract class User
    {
        [Key]
        [EmailAddress(ErrorMessage = "El email debe tener un formato válido.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(200, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^(Professor|Admin|Student)$", ErrorMessage = "El rol debe ser 'Professor', 'Admin' o 'Student'.")]
        public string Role { get; set; }
    }

    // Subclase Student
    internal class Student : User
    {
        public string StudentFile { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

    // Subclase Professor
    internal class Professor : User
    {
        public string ProfessorFile { get; set; }
        public string Specialization { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>(); // Relación muchos a muchos con Course
    }

    // Subclase Admin
    internal class Admin : User
    {
        public string Position { get; set; }
    }
}