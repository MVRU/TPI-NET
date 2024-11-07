using System;
using System.Threading.Tasks;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    internal class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            // Hashear la contraseña antes de guardarla
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            return await _userRepository.AddUserAsync(user);
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<bool> UserLogInAsync(string id, string pwd)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            // Comparación de contraseñas usando BCrypt
            if (user != null && VerifyPassword(user.Password, pwd))
            {
                Console.WriteLine("Inicio de sesión exitoso.");
                return true;
            }

            Console.WriteLine("Credenciales incorrectas.");
            return false;
        }

        private bool VerifyPassword(string storedPassword, string inputPassword)
        {
            // Verificar la contraseña usando BCrypt
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedPassword);
        }

        public async Task<bool> UpdateUserAsync(User updatedUser, string currentUserId, string currentUserRole)
        {
            return await _userRepository.UpdateUserAsync(updatedUser, currentUserId, currentUserRole);
        }

        public async Task<bool> DeleteUserAsync(string id, string currentUserRole)
        {
            return await _userRepository.DeleteUserAsync(id, currentUserRole);
        }
    }
}
