﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNET.Models
{
    internal class Schedule
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; } // Foreign Key
        public Course Course { get; set; } // Propiedad de navegación
    }
}
