using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string user_key { get; set; }
        public string lower_user_name { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}