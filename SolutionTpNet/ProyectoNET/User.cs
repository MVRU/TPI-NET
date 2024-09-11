using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNET
{
    internal class User
    {
        public string Id {  get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Dir { get; set; }
    }
}
