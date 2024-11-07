using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    internal class User
    {
        [Key]
        [Required(ErrorMessage = "El legajo es obligatorio.")]
        public string File { get; set; } // El legajo será el Id

        [EmailAddress(ErrorMessage = "El email debe tener un formato válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(200, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^(Professor|Admin|Student)$", ErrorMessage = "El rol debe ser 'Professor', 'Admin' o 'Student'.")]
        public string Role { get; set; } // Campo para especificar el rol del usuario (Professor, Admin o Student)


        // Atributos específicos de cada tipo de usuario:
        public string? Specialization { get; set; } // Solo para profesores
        public ICollection<Course> Courses { get; set; } = new List<Course>(); // Relación con Course (solo profesores)
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // Relación con Enrollment (solo estudiantes)
        public string? Position { get; set; } // Solo para administradores (profesor, bedel, administrador, etc.)
    }
}