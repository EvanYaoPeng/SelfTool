using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using WebApI.Models;

namespace WebApI.Controllers
{
    public class UserController : ApiController
    {
        User[] users = new User[]{
            new User { ID = 1, lower_user_name = "石曼迪", user_key = "mady" },
            new User { ID = 2, lower_user_name = "狗王", user_key = "taisanDog" },
            new User { ID = 3, lower_user_name = "道长", user_key = "kongque" }
        };
        public IEnumerable<User> GetAllUsers()
        {
            //获取请求地址中的信息
            StringBuilder showsql = new StringBuilder();
            HttpRequest req = HttpContext.Current.Request;
            foreach (var item in req.ServerVariables)
            {
                showsql.AppendFormat("{0}:{1}\r\n", item.ToString(), req.ServerVariables.Get(item.ToString()));
            }
            //获取客户端IP方法
            string uip = "";
            if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null) //如何是代理用这个获取IP信息
            {
                uip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                uip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }


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
