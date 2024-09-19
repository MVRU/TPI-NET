/* DATOS DE PRUEBA

ADMIN:
admin@example.com
@Password123

*/

using ProyectoNET.Models;
using ProyectoNET.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProyectoNET.Data
{
    internal static class DataSeeder
    {
        public static void Seed(UniversityContext context)
        {
            // Asegurarse de que la base de datos está creada
            context.Database.Migrate();

            // Verificar si ya existen los usuarios
            if (!context.Users.Any())
            {
                // Crear usuarios de prueba
                var admin = new Admin
                {
                    Id = "admin@example.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("@Password123"),
                    Name = "Admin",
                    LastName = "User",
                    Address = "Dirección 123",
                    Role = "Admin",
                    Position = "Administrador"
                };

                // Agregar usuarios a la base de datos
                context.Users.AddRange(admin);
                context.SaveChanges();
            }

            // Verificar si ya existen las asignaturas
            if (!context.Subjects.Any())
            {
                // Crear asignaturas de prueba sin Id explícito
                var subjects = new[]
                {
                    new Subject
                    {
                        Description = "Tecnologías de Desarrollo de Software IDE",
                        RequiredAttendancePercentage = 75,
                        AverageAttendancePercentage = 60
                    },
                    new Subject
                    {
                        Description = "Diseño de Sistemas de Información",
                        RequiredAttendancePercentage = 70,
                        AverageAttendancePercentage = 55
                    },
                    new Subject
                    {
                        Description = "Bases de Datos",
                        RequiredAttendancePercentage = 75,
                        AverageAttendancePercentage = 80
                    },
                    new Subject
                    {
                        Description = "Desarrollo de Software",
                        RequiredAttendancePercentage = 60,
                        AverageAttendancePercentage = 50
                    }
                };

                // Agregar asignaturas a la base de datos
                context.Subjects.AddRange(subjects);
                context.SaveChanges();
            }
        }
    }
}