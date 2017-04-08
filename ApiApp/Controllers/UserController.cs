using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiApp.Models;


namespace ApiApp.Controllers
{
    public class UserController : ApiController
    {

        User[] users = new User[]
        {
            new User { Id = 1, Name = "Halfonso"},
            new User { Id = 2, Name = "Halfons"},
            new User { Id = 2, Name = "Laravel"}
        };

        public IEnumerable<User> GetAllUsers()
        {
                return users;
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
