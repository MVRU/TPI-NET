using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.DbContext
{
    public class UniversityDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
            : base(options)
        { }

        // Definir los DbSet para cada entidad
        public DbSet<User> Users { get; set; }

        // Configuración adicional de entidades y sus relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}