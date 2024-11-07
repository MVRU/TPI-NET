using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProyectoNET.Data;

namespace ProyectoNET.Design
{
    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<UniversityContext>
    {
        public UniversityContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=true");

            return new UniversityContext(optionsBuilder.Options);
        }
    }
}