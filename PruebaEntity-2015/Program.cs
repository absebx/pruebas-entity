using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PruebaEntity_2015
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new TO_DO_LISTEntities())
            {
                //crear y guardar nuevo usuario
                Console.WriteLine("Ingrese el nombre");
                string name = Console.ReadLine();
                var user = new USER { name = name };
                db.USER.Add(user);
                db.SaveChanges();

                //display all users

                Console.WriteLine("Todos los usuarios en la base de datos");
                var query = from u in db.USER
                            orderby u.name descending
                            select u;

                foreach (var item in query)
                {
                    Console.WriteLine("ID: "+item.id+" nombre: "+item.name);
                }

                Console.ReadKey();

            }
                

        }
    }
}
