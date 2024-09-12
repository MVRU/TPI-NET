using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNET
{
    internal class Operation
    {
        public void addUser(User user)
        {
            try
            {
                using (var context = new UniversityContext())
                {
                    // Validar el rol
                    if (!new[] { "Professor", "Admin", "Student" }.Contains(user.Role))
                    {
                        throw new Exception("Rol inválido. Debe ser 'Professor', 'Admin' o 'Student'.");
                    }

                    if (context.Users.Any(u => u.Id == user.Id))
                    {
                        throw new Exception("El email ya está registrado.");
                    }

                    // Guardar según el tipo de usuario
                    if (user is Student student)
                    {
                        context.Users.Add(student);
                    }
                    else if (user is Professor professor)
                    {
                        context.Users.Add(professor);
                    }
                    else if (user is Admin admin)
                    {
                        context.Users.Add(admin);
                    }
                    else
                    {
                        throw new Exception("Tipo de usuario desconocido.");
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar usuario: {ex.Message}");
            }
        }


        public User getUserById(string id)
            {
                using (var context = new UniversityContext())
                {
                    return context.Users.Find(id); // Encontrar al usuario por su Id (Email)
                }
            }

        public Boolean userlogIn(string id, string pwd)
        {
            return (getUserById(id).Password == pwd);
        }

        public void updateUser(User updatedUser)
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
                        user.Id = updatedUser.Id;
                        user.Password = updatedUser.Password;

                        // Actualizar atributos específicos según el tipo de usuario
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
                    }
                    else
                    {
                        throw new Exception("Usuario no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar usuario: {ex.Message}");
            }
        }

        public void deleteUser(string id)
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
                    }
                    else
                    {
                        throw new Exception("Usuario no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
            }
        }


    }
}