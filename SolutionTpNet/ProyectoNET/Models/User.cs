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

        // Dirección
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^(Professor|Admin|Student)$", ErrorMessage = "El rol debe ser 'Professor', 'Admin' o 'Student'.")]
        public string Role { get; set; }
    }

    // Clase Student
    internal class Student : User
    {
        public int StudentFile { get; set; }
    }

    // Clase Professor
    internal class Professor : User
    {
        public int ProfessorFile { get; set; }

        public string Specialization { get; set; }
    }

    // Clase Admin
    internal class Admin : User
    {
        public string Position { get; set; }
    }
}