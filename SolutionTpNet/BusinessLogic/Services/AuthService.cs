using DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SharedModels.Interfaces;
using SharedModels.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SharedModels.DTOs;

namespace BusinessLogic.Services;

public class AuthService
{
    private readonly IUserRepository _userRepository;
    private readonly string _jwtKey;

    public AuthService(IUserRepository userRepository, IConfiguration configuration)
    {
        _userRepository = userRepository;
        _jwtKey = configuration["Jwt:Key"];
    }

    public async Task<SignInResponse> SignInAsync(SignInRequest request)
    {
        // Validar contraseña
        if (request.Password != request.ConfirmPassword)
            throw new ArgumentException("Las contraseñas no coinciden.");

        if (!IsPasswordValid(request.Password))
            throw new ArgumentException("La contraseña debe tener al menos 8 caracteres, incluyendo letras, números y símbolos.");

        // Crear el usuario según el rol
        IUser user = request.Role switch
        {
            "Student" => new Student
            {
                Id = request.Id,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
            },
            "Professor" => new Professor
            {
                Id = request.Id,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Speciality = request.Specialization // Atributo adicional
            },
            "Admin" => new Admin
            {
                Id = request.Id,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Position = request.Position // Atributo adicional
            },
            _ => throw new ArgumentException("Rol no válido.")
        };

        // Guardar el usuario en la base de datos
        await _userRepository.AddAsync(user);

        // Generar el token JWT
        var token = GenerateJwtToken(user);

        return new SignInResponse { Token = token, Role = user.Role };
    }

    private string GenerateJwtToken(IUser user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_jwtKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role)
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private bool IsPasswordValid(string password)
    {
        // Validar que la contraseña tenga al menos 8 caracteres, incluyendo letras, números y símbolos
        return password.Length >= 8 &&
               password.Any(char.IsLetter) &&
               password.Any(char.IsDigit) &&
               password.Any(char.IsSymbol);
    }
}