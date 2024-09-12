using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNET
{
    internal abstract class User
    {
        [Key]
        [EmailAddress]
        public string Id { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
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