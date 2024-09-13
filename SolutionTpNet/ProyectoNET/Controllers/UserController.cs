using Microsoft.EntityFrameworkCore;
using ProyectoNET.Models;
using System;
using System.Linq;

namespace ProyectoNET.Controllers
{
    internal class UserController
    {
        public bool AddUser(User user)
        {
            try
            {
                using (var context = new UniversityContext())
                {
                    // Validar si el rol es válido
                    if (!new[] { "Professor", "Admin", "Student" }.Contains(user.Role))
                    {
                        Console.WriteLine("Error: Rol inválido. Debe ser 'Professor', 'Admin' o 'Student'.");
                        return false;
                    }

                    // Verificar si el email ya está registrado
                    if (context.Users.Any(u => u.Id == user.Id))
                    {
                        Console.WriteLine("Error: El email ya está registrado.");
                        return false;
                    }

                    // Guardar el usuario según su tipo
                    context.Users.Add(user);
                    context.SaveChanges();
                    Console.WriteLine("Usuario agregado exitosamente.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar usuario: {ex.Message}");
                return false;
            }
        }

        public User GetUserById(string id)
        {
            using (var context = new UniversityContext())
            {
                return context.Users.Find(id);
            }
        }

        public bool UserLogIn(string id, string pwd)
        {
            var user = GetUserById(id);

            // Comparación de contraseñas usando hash
            if (user != null && VerifyPassword(user.Password, pwd))
            {
                Console.WriteLine("Inicio de sesión exitoso.");
                return true;
            }

            Console.WriteLine("Credenciales incorrectas.");
            return false;
        }

        // Método para verificar contraseñas (usando hashing)
        private bool VerifyPassword(string storedPassword, string inputPassword)
        {
            // Acá se debería usar un algoritmo de hashing (ej: BCrypt)
            return storedPassword == inputPassword; // Simplificado por ahora
        }

        public bool UpdateUser(User updatedUser)
        {
            try
            {
                using (var context = new UniversityContext())
                {
                    var user = context.Users.Find(updatedUser.Id);

                    if (user != null)
                    {
                        user.Name = updatedUser.Name;
                        user.LastName = updatedUser.LastName;
                        user.Password = updatedUser.Password;
                        user.Address = updatedUser.Address;

                        // Actualizar campos específicos según el tipo de usuario
                        if (user is Student student && updatedUser is Student updatedStudent)
                        {
                            student.StudentFile = updatedStudent.StudentFile;
                        }
                        else if (user is Professor professor && updatedUser is Professor updatedProfessor)
                        {
                            professor.ProfessorFile = updatedProfessor.ProfessorFile;
                            professor.Specialization = updatedProfessor.Specialization;
                        }
                        else if (user is Admin admin && updatedUser is Admin updatedAdmin)
                        {
                            admin.Position = updatedAdmin.Position;
                        }

                        context.SaveChanges();
                        Console.WriteLine("Usuario actualizado exitosamente.");
                        return true;
                    }

                    Console.WriteLine("Error: Usuario no encontrado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar usuario: {ex.Message}");
                return false;
            }
        }

        public bool DeleteUser(string id)
        {
            try
            {
                using (var context = new UniversityContext())
                {
                    var user = context.Users.Find(id);

                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        Console.WriteLine("Usuario eliminado exitosamente.");
                        return true;
                    }

                    Console.WriteLine("Error: Usuario no encontrado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
                return false;
            }
        }
    }
}