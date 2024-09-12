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


        // METODOS CURSO

        // crear curso
        static void CreateCourse(int year, DateTime fechaIni, DateTime fechaFin, int quota)
        {
            using (var context = new UniversityContext())
            {
                var course = new Course
                {
                    Year = year,
                    FechaIni = fechaIni,
                    FechaFin = fechaFin,
                    Quota = quota
                };

                context.Courses.Add(course);
                context.SaveChanges();

                // cambiar en la implementacion

                Console.WriteLine($"Curso del año {year} creado con éxito.");
            }
        }

        // Método para leer un curso por su Id
        static void GetCourseById(int id)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);


                // cambiar en la implementacion
                if (course != null)
                {
                    Console.WriteLine($"Curso encontrado: Año {course.Year}");
                    Console.WriteLine($"Fecha Inicio: {course.FechaIni}");
                    Console.WriteLine($"Fecha Fin: {course.FechaFin}");
                    Console.WriteLine($"Cupo: {course.Quota}");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        // actualizar curso
        static void UpdateCourse(int id, int newQuota)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);

                // cambiar en implementacion

                if (course != null)
                {
                    course.Quota = newQuota;
                    context.SaveChanges();

                    Console.WriteLine($"Cupo del curso con Id {id} actualizado a {newQuota}.");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }

        // Método para eliminar un curso
        static void DeleteCourse(int id)
        {
            using (var context = new UniversityContext())
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == id);

                // cambiar en implementacion

                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();

                    Console.WriteLine($"Curso con Id {id} eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }
    }

}