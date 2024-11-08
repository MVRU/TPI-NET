using System;
using System.Threading.Tasks;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Controllers
{
    public class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                // Hashear la contraseña antes de guardarla
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                return await _userRepository.AddUserAsync(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar usuario: {ex.Message}");
                return false;
            }
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            try
            {
                return await _userRepository.GetUserByIdAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener usuario: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UserLogInAsync(string id, string pwd)
        {
            try
            {
                var user = await _userRepository.GetUserByIdAsync(id);

                if (user != null && VerifyPassword(user.Password, pwd))
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                    return true;
                }

                Console.WriteLine("Credenciales incorrectas.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al intentar iniciar sesión: {ex.Message}");
                return false;
            }
        }

        private bool VerifyPassword(string storedPassword, string inputPassword)
        {
            try
            {
                // Verificar la contraseña usando BCrypt
                return BCrypt.Net.BCrypt.Verify(inputPassword, storedPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar la contraseña: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateUserAsync(User updatedUser, string currentUserId, string currentUserRole)
        {
            try
            {
                return await _userRepository.UpdateUserAsync(updatedUser, currentUserId, currentUserRole);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el usuario: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteUserAsync(string id, string currentUserId, string currentUserRole)
        {
            try
            {
                // Evitar que el usuario actual elimine su propia cuenta
                if (id == currentUserId)
                {
                    Console.WriteLine("Error: No puedes eliminar tu propia cuenta.");
                    return false;
                }

                return await _userRepository.DeleteUserAsync(id, currentUserRole);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el usuario: {ex.Message}");
                return false;
            }
        }
    }
}
