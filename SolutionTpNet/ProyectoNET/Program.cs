using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ProyectoNET.Controllers;
using ProyectoNET.Repositories;
using ProyectoNET.Data;
using LogIn;
using Signin;
using tomarAsistencia;
using ProyectoNET.Forms;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Views;
using System.IO;

namespace ProyectoNET
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        private static void Main()
        {
            // Configurar la lectura del archivo appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Establecer la base para la ruta del archivo
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Cargar el archivo de configuración
                .Build();

            // Configurar el host y la inyección de dependencias
            var serviceCollection = new ServiceCollection()
                .AddDbContext<UniversityContext>(options =>
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"))) // Usar la cadena de conexión del appsettings.json
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
                .AddTransient<TakeAttendanceForm>()
                .AddTransient<UsersManagementForm>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

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
