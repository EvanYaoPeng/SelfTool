﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApI.Models
{
    interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        Person Add(Person person);
        void Remove(int id);
        bool Update(Person person);
    }
}