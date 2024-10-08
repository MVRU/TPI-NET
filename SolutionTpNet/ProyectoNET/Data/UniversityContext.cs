﻿using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;

namespace ProyectoNET.Data
{
    internal class UniversityContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar la relación muchos a muchos entre Course y User (como profesores)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Users)
                .WithMany(u => u.Courses) // El rol de profesor se distingue por el atributo Role
                .UsingEntity<Dictionary<string, object>>(
                    "CourseProfessor", // Nombre de la tabla intermedia
                    j => j.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    j =>
                    {
                        j.HasKey("CourseId", "UserId");
                        j.ToTable("CourseProfessor"); // Nombre de la tabla intermedia
                    }
                );

            // Definir la relación entre Course y Schedule
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Subject)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SubjectId);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Schedules)
                .HasForeignKey(s => s.CourseId);

            // Relación uno a muchos entre Enrollment y Status
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Status)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StatusId);

            // Relación uno a muchos entre Enrollment y Attendance
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Enrollment)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EnrollmentId);

            // Relación uno a muchos entre Course y Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            // Relación uno a muchos entre User (Estudiante) y Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(u => u.Enrollments)
                .HasForeignKey(e => e.StudentId);

            // Definiciones adicionales de configuración si es necesario
            modelBuilder.Entity<Status>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Enrollment>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Attendance>()
                .HasKey(a => a.Id);

            base.OnModelCreating(modelBuilder);
        }

        // Constructor vacío para compatibilidad con las pruebas y migraciones
        public UniversityContext()
        {
        }
    }
}
