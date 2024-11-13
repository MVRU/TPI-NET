using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;

namespace ProyectoNET.Data
{
    public class UniversityContext : DbContext
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
            // Configuración de la relación muchos a muchos entre Course y Schedule
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Schedules)
                .WithMany(s => s.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "CourseSchedule", // Nombre de la tabla intermedia
                    j => j.HasOne<Schedule>().WithMany().HasForeignKey("ScheduleId"),
                    j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    j =>
                    {
                        j.HasKey("CourseId", "ScheduleId");
                        j.ToTable("CourseSchedule");
                    }
                );

            // Relación entre Course y Subject
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Subject)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SubjectId);

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

            // Relación uno a muchos entre User (Student) y Enrollment
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

            // DB SEEDING (si es necesario)
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Description = "Pendiente" },
                new Status { Id = 2, Description = "Regular" },
                new Status { Id = 3, Description = "Libre" },
                new Status { Id = 4, Description = "Aprobada" }
            );

            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1, Day = "Lunes", StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(10, 0, 0) },
                new Schedule { Id = 2, Day = "Lunes", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                new Schedule { Id = 4, Day = "Martes", StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(10, 0, 0) },
                new Schedule { Id = 5, Day = "Martes", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                new Schedule { Id = 6, Day = "Miércoles", StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(10, 0, 0) },
                new Schedule { Id = 7, Day = "Miércoles", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                new Schedule { Id = 8, Day = "Jueves", StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(10, 0, 0) },
                new Schedule { Id = 9, Day = "Jueves", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                new Schedule { Id = 10, Day = "Viernes", StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(10, 0, 0) },
                new Schedule { Id = 11, Day = "Viernes", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(12, 0, 0) }
            );

            base.OnModelCreating(modelBuilder);
        }

        // Constructor vacío para compatibilidad con las pruebas y migraciones
        public UniversityContext()
        {
        }
    }
}
