using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using PruebaEntity_2015;
using Models;

namespace ApiApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {

        User[] users = new User[] { };
        PruebaEntity_2015.UserController control = new PruebaEntity_2015.UserController();

        public IEnumerable<User> GetAllUsers()
        {
                return control.getAll();
        }

        public IHttpActionResult GetUser(int id)
        {
            var user = users.FirstOrDefault((u) => u.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
