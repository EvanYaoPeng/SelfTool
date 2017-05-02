using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApI.Models
{
    public class PersonRepository : IPersonRepository
    {

        private List<Person> _people = new List<Person>();
        private int num = 1;

        public PersonRepository()
        {
            this.Add(new Person { LastName = "三", FirstName = "张" });
            this.Add(new Person { LastName = "四", FirstName = "李" });
            this.Add(new Person { LastName = "五", FirstName = "王" });
            this.Add(new Person { LastName = "六", FirstName = "老" });
        }

        public IEnumerable<Person> GetAll()
        {
            return _people;
        }

        public Person Get(int id)
        {
            return _people.Find(p => p.Id == id);
        }

        public Person Add(Person person)
        {
            if (person == null)
                throw new ArgumentNullException("person");
            person.Id = num++;
            _people.Add(person);
            return person;
        }

        public void Remove(int id)
        {
            _people.RemoveAll(p => p.Id == id);
        }

        public bool Update(Person person)
        {
            if (person == null)
                throw new ArgumentNullException("person");

            int index = _people.FindIndex(p => p.Id == person.Id);
            if (index == -1)
                return false;
            _people.RemoveAt(index);
            _people.Add(person);
            return true;
        }
    }
}