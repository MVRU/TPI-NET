using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    internal class UserRepository
    {
        private readonly UniversityContext _context;

        public UserRepository(UniversityContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                // Validar si el rol es válido
                if (!new[] { "Professor", "Admin", "Student" }.Contains(user.Role))
                {
                    throw new ArgumentException("Rol inválido. Debe ser 'Professor', 'Admin' o 'Student'.");
                }

                // Verificar si el legajo ya está registrado
                if (await _context.Users.AnyAsync(u => u.File == user.File))
                {
                    throw new InvalidOperationException("El legajo ya está registrado.");
                }

                // Guardar el usuario
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
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
                return await _context.Users.FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener usuario: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UpdateUserAsync(User updatedUser)
        {
            try
            {
                var user = await _context.Users.FindAsync(updatedUser.File);

                if (user != null)
                {
                    user.Name = updatedUser.Name;
                    user.LastName = updatedUser.LastName;
                    user.Email = updatedUser.Email;
                    user.Password = updatedUser.Password;
                    user.Address = updatedUser.Address;

                    // Actualizar campos específicos según el tipo de usuario
                    user.Specialization = updatedUser.Specialization;
                    user.Position = updatedUser.Position;

                    await _context.SaveChangesAsync();
                    Console.WriteLine("Usuario actualizado exitosamente.");
                    return true;
                }

                Console.WriteLine("Error: Usuario no encontrado.");
                return false;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Error de actualización en la base de datos: {dbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar usuario: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);

                if (user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                    Console.WriteLine("Usuario eliminado exitosamente.");
                    return true;
                }

                Console.WriteLine("Error: Usuario no encontrado.");
                return false;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Error de actualización en la base de datos: {dbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
                return false;
            }
        }
    }
}
