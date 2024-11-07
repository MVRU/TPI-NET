using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa un usuario del sistema, que puede ser un profesor, administrador o estudiante.
    /// La clase User contiene la información básica del usuario como su nombre, apellido, dirección,
    /// email, contraseña, y su rol en el sistema. Además, contiene atributos específicos según el tipo de usuario.
    /// </summary>
    public class User
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

        /// <summary>
        /// Obtiene o establece el rol del usuario.
        /// El valor debe ser uno de los siguientes: 'Professor', 'Admin', o 'Student'.
        /// </summary>
        [Required]
        [RegularExpression(@"^(Professor|Admin|Student)$", ErrorMessage = "El rol debe ser 'Professor', 'Admin' o 'Student'.")]
        public string Role { get; set; }


        // Atributos específicos de cada tipo de usuario:

        // PROFESSOR
        public string? Specialization { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>(); // Relación con cursos

        // STUDENT
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // Relación con matrículas

        // ADMIN
        public string? Position { get; set; } // e.g.: profesor, bedel, administrador, etc.
    }
}