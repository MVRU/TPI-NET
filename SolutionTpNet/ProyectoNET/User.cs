using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNET
{
    internal class User
    {
        [Key]
        [EmailAddress]
        public string Id {  get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Name { get; set; }

        // Dirección
        public string Dir { get; set; }
    }
}
