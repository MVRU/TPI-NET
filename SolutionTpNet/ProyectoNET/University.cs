using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Logging;

namespace ProyectoNET
{
    internal class UniversityContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=true");
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

        }
        public UniversityContext()
        {
            this.Database.EnsureCreated();
        }
    }
}
