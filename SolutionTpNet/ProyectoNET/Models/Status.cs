using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // Relación uno a muchos con Enrollment
    }
}