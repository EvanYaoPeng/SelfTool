using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApI.Models;

namespace WebApI.Controllers
{
    public class UserController : ApiController
    {
        User[] users = new User[]
 {
new User { ID = 1, lower_user_name = "石曼迪", user_key = "mady" },
new User { ID = 2, lower_user_name = "狗王", user_key = "taisanDog" },
new User { ID = 3, lower_user_name = "道长", user_key = "kongque" }
 };
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }
        public User GetUserById(int id)
        {
            var user = users.FirstOrDefault((p) => p.ID == id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
        }
    }
}
