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
            using (var context = new UniversityContext())
            {
                    User nwUser = new User()
                    {
                        Id = user.Id,
                        Name = user.Name,
                        LastName = user.LastName,
                        Dir = user.Dir,
                        Password = user.Password
                    };
                    context.Users.Add(nwUser);
                    context.SaveChanges();
                }
            }
        

        public User getUser(string id)
        {
            using (var context = new UniversityContext())
            {
                User user = context.Users.FirstOrDefault(a => a.Id == id);
                if (user == null)
                {
                    //return user = new User();
                }
                return user;
            }
        }

        public Boolean userlogIn(string id, string pwd)
        {
            return (getUser(id).Password == pwd);
        }

    }
}
