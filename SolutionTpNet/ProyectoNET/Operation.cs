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
                    if (context.Users.Any(u => u.Id == user.Id))
                    {
                        throw new Exception("El email ya está registrado.");
                    }

                    context.Users.Add(user);
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
                    return context.Users.Find(id); // Encuentra el usuario por su Id (Email)
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

        public void deleteUser(int id)
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