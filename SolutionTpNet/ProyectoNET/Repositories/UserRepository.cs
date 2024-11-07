using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    public class UserRepository
    {
        private readonly UniversityContext _context;

        public UserRepository(UniversityContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Agrega un nuevo usuario a la base de datos.
        /// Realiza validaciones sobre el rol del usuario y verifica si el legajo ya está registrado.
        /// </summary>
        /// <param name="user">El usuario a agregar.</param>
        /// <returns>True si el usuario fue agregado exitosamente, de lo contrario false.</returns>
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

        /// <summary>
        /// Obtiene un usuario por su identificador (legajo).
        /// </summary>
        /// <param name="id">El legajo del usuario.</param>
        /// <returns>El usuario encontrado o null si no se encuentra.</returns>
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

        /// <summary>
        /// Actualiza la información de un usuario. 
        /// Incluye validaciones para asegurar que solo el usuario actual pueda modificar su propia contraseña,
        /// y solo un administrador puede modificar el rol de un usuario.
        /// </summary>
        /// <param name="updatedUser">El usuario con los datos actualizados.</param>
        /// <param name="currentUserId">El identificador del usuario que realiza la actualización.</param>
        /// <param name="currentUserRole">El rol del usuario que realiza la actualización.</param>
        /// <returns>True si la actualización fue exitosa, de lo contrario false.</returns>
        public async Task<bool> UpdateUserAsync(User updatedUser, string currentUserId, string currentUserRole)
        {
            try
            {
                var user = await _context.Users.FindAsync(updatedUser.File);

                if (user == null)
                {
                    Console.WriteLine("Error: Usuario no encontrado.");
                    return false;
                }

                // Evitar cambios en el legajo
                if (user.File != updatedUser.File)
                {
                    Console.WriteLine("Error: El legajo no puede modificarse.");
                    return false;
                }

                // Verificar que el usuario no intente modificar la contraseña de otro usuario
                if (currentUserId != updatedUser.File && updatedUser.Password != user.Password)
                {
                    Console.WriteLine("Error: No puede modificar la contraseña de otro usuario.");
                    return false;
                }

                // Solo un administrador puede modificar el rol
                if (currentUserRole != "Admin" && updatedUser.Role != user.Role)
                {
                    Console.WriteLine("Error: Solo los administradores pueden modificar el rol.");
                    return false;
                }

                // Actualizar campos comunes
                user.Name = updatedUser.Name;
                user.LastName = updatedUser.LastName;
                user.Email = updatedUser.Email;
                user.Address = updatedUser.Address;

                // Actualizar campos específicos según el tipo de usuario
                if (!string.IsNullOrEmpty(updatedUser.Specialization))
                {
                    user.Specialization = updatedUser.Specialization;
                }

                if (!string.IsNullOrEmpty(updatedUser.Position))
                {
                    user.Position = updatedUser.Position;
                }

                // Si la contraseña ha sido cambiada, hashearla
                if (!string.IsNullOrEmpty(updatedUser.Password) && updatedUser.Password != user.Password)
                {
                    user.Password = BCrypt.Net.BCrypt.HashPassword(updatedUser.Password);
                }

                await _context.SaveChangesAsync();
                Console.WriteLine("Usuario actualizado exitosamente.");
                return true;
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

        /// <summary>
        /// Elimina un usuario de la base de datos.
        /// Realiza validaciones sobre el rol del usuario que realiza la eliminación y el rol del usuario a eliminar.
        /// Si el usuario es un profesor, se eliminan sus inscripciones y cursos si es el único profesor.
        /// </summary>
        /// <param name="id">El legajo del usuario a eliminar.</param>
        /// <param name="currentUserRole">El rol del usuario que realiza la eliminación.</param>
        /// <returns>True si la eliminación fue exitosa, de lo contrario false.</returns>
        public async Task<bool> DeleteUserAsync(string id, string currentUserRole)
        {
            try
            {
                var userToDelete = await _context.Users.FindAsync(id);

                if (userToDelete == null)
                {
                    Console.WriteLine("Error: Usuario no encontrado.");
                    return false;
                }

                // Los admins no pueden ser eliminados
                if (userToDelete.Role == "Admin")
                {
                    Console.WriteLine("Error: No se puede eliminar un usuario administrador.");
                    return false;
                }

                // Los profesores solo pueden ser eliminados por un admin
                if (userToDelete.Role == "Professor" && currentUserRole != "Admin")
                {
                    Console.WriteLine("Error: Solo los administradores pueden eliminar profesores.");
                    return false;
                }

                // Eliminar inscripciones de estudiantes si el curso no tiene más profesores
                if (userToDelete.Role == "Professor")
                {
                    foreach (var course in userToDelete.Courses)
                    {
                        if (course.Users.Count == 1) // Si solo tiene un profesor, eliminar inscripciones
                        {
                            foreach (var enrollment in course.Enrollments)
                            {
                                _context.Enrollments.Remove(enrollment);
                            }

                            // Eliminar el curso asociado
                            _context.Courses.Remove(course);
                        }
                    }
                }

                // Eliminar al usuario
                _context.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
                Console.WriteLine("Usuario eliminado exitosamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
                return false;
            }
        }

        // Obtener todos los usuarios
        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener usuarios: {ex.Message}");
                return new List<User>(); // Retorna una lista vacía en caso de error
            }
        }
    }
}
