using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace PruebaEntity_2015
{
    //Controlador para obtener los objetos del entity
    public class UserController
    {
        //obtener todos los usuarios del entity
        public User[] getAll()
        {
            List<User> usuarios = new List<User>();

            using (var db = new TO_DO_LISTEntities())
            {
                
                var query = from u in db.USER
                            orderby u.id descending
                            select u;
                foreach (var item in query)
                {
                    User user = new User();
                    user.Id = item.id;
                    user.Name = item.name;
                    usuarios.Add(user);
                }
            }
            return usuarios.ToArray();
        }
    }
}
