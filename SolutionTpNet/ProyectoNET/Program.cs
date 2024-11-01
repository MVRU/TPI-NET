using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProyectoNET.Controllers;
using ProyectoNET.Repositories;
using ProyectoNET.Data;
using LogIn;
using Signin;
using tomarAsistencia;
using ProyectoNET.Forms;
using Microsoft.EntityFrameworkCore;

namespace ProyectoNET
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        private static void Main()
        {
            // Configurar el host y la inyección de dependencias
            var serviceCollection = new ServiceCollection()
                .AddDbContext<UniversityContext>(options =>
                    options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=true"))
                .AddScoped<AttendanceRepository>()
                .AddScoped<CourseRepository>()
                .AddScoped<EnrollmentRepository>()
                .AddScoped<ScheduleRepository>()
                .AddScoped<StatusRepository>()
                .AddScoped<SubjectRepository>()
                .AddScoped<UserRepository>()
                .AddScoped<AttendanceController>()
                .AddScoped<CourseController>()
                .AddScoped<EnrollmentController>()
                .AddScoped<ScheduleController>()
                .AddScoped<StatusController>()
                .AddScoped<SubjectController>()
                .AddScoped<UserController>()
                .AddTransient<DashboardForm>()
                .AddTransient<frmLogIn>()
                .AddTransient<MainForm>()
                .AddTransient<frmSignIn>()
                .AddTransient<TakeAttendanceForm>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<UniversityContext>();
                DataSeeder.Seed(context); // Llamar a la función Seed para agregar datos de prueba
            }

            try
            {
                ApplicationConfiguration.Initialize();
                var mainForm = ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción que ocurra
                Console.WriteLine($"Se produjo un error: {ex.Message}");
                Console.WriteLine("Presiona Enter para salir...");
                Console.ReadLine();
            }
        }
    }
}
