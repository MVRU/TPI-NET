using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa el estado de una matrícula de un estudiante.
    /// La clase Status contiene información sobre la descripción del estado
    /// y las matrículas asociadas a ese estado.
    /// </summary>
    internal class Status
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        // Relación con matrículas
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}