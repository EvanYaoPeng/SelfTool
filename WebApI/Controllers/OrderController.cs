using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApI.Controllers
{
    public class OrderController : ApiController
    {
        [HttpGet]
        public object GetAll()
        {
            return "Success";
        }


        [ActionName("TestActionName")]
        [HttpGet]
        public object GetById(int id)
        {
            return "Success" + id;
        }
    }
}
