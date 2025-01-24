using Microsoft.EntityFrameworkCore;
using SharedModels.Models;

namespace DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
            : base(options)
        { }

        // DbSet para cada entidad
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        // Configuración adicional de entidades y sus relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación muchos a muchos entre Professor y Course
            modelBuilder.Entity<Professor>()
                .HasMany(p => p.Courses)
                .WithMany(c => c.Professors)
                .UsingEntity(j =>
                {
                    j.ToTable("ProfessorCourses"); // Nombre de la tabla de unión
                });

            // Relación muchos a muchos entre Course y Schedule
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Schedules)
                .WithMany(s => s.Courses)
                .UsingEntity(j =>
                {
                    j.ToTable("CourseSchedules"); // Nombre de la tabla de unión
                });

            // Relación uno a muchos entre Student y Enrollment
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            // Relación uno a muchos entre Course y Enrollment
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Enrollments)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId);

            // Relación uno a muchos entre Subject y Course
            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Courses)
                .WithOne(c => c.Subject)
                .HasForeignKey(c => c.SubjectId);

            // Relación uno a muchos entre Enrollment y Attendance
            modelBuilder.Entity<Enrollment>()
                .HasMany(e => e.Attendances)
                .WithOne(a => a.Enrollment)
                .HasForeignKey(a => a.EnrollmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}