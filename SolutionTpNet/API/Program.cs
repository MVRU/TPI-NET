using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using BusinessLogic.Profiles;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar la cadena de conexi�n
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configurar el DbContext con la cadena de conexi�n y establecer SQL Server
builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseSqlServer(connectionString));

// Registrar AutoMapper y los perfiles de mapeo
builder.Services.AddAutoMapper(typeof(UserProfile));

// Registrar servicios de BusinessLogic
builder.Services.AddScoped<IUserService, UserService>();

// Registrar el repositorio (interfaz -> implementaci�n) de DataAccess
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Registrar los controladores y otros servicios
builder.Services.AddControllers();

// Configurar Swagger para la documentaci�n de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de la solicitud HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
