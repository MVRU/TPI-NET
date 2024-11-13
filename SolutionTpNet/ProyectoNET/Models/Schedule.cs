using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    /// <summary>
    /// Representa un horario asociado a un curso específico.
    /// La clase Schedule contiene información sobre el día y las horas de inicio y fin de la clase.
    /// Además, tiene una relación con el curso al que pertenece este horario.
    /// </summary>
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Relación con curso
        public ICollection<Course> Courses { get; set; } = new List<Course>();

        public string DisplayText
        {
            get
            {
                // Verificar si StartTime y EndTime son válidos
                try
                {
                    return $"{Day} - {StartTime:hh\\:mm} a {EndTime:hh\\:mm}";
                }
                catch (FormatException)
                {
                    // Manejar el error si el formato de TimeSpan es incorrecto
                    return $"{Day} - Horario no válido";
                }
            }
        }
    }
}
