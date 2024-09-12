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
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=true");
            // optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar herencia utilizando un discriminador para el tipo de usuario
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("Role")
                .HasValue<Student>("Student")
                .HasValue<Professor>("Professor")
                .HasValue<Admin>("Admin");

            // Agregar restricciones adicionales: Legajo es requerido (ver más adelante)
            // modelBuilder.Entity<Alumno>().Property(a => a.Legajo).IsRequired();
            // modelBuilder.Entity<Profesor>().Property(p => p.Legajo).IsRequired();
        }

        public UniversityContext()
        {
            this.Database.EnsureCreated();
        }
    }
}
