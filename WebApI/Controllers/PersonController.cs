using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApI.Models;

namespace WebApI.Controllers
{
    public class PersonController : ApiController
    {
        static readonly IPersonRepository databasePlaceholder = new PersonRepository();


        public Person GetPersonByID(int id)
        {
            Person person = databasePlaceholder.Get(id);
            if (person == null)
            {
                //返回一个自定义HTTP状态码
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return person;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return databasePlaceholder.GetAll();
        }

        public HttpResponseMessage PostPerson(Person person)
        {
            person = databasePlaceholder.Add(person);
            var response = this.Request.CreateResponse<Person>(HttpStatusCode.Created, person);
            string uri = Url.Link("DefaultApi", new { id = person.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public bool PutPerson(Person person)
        {
            if (!databasePlaceholder.Update(person))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return true;
        }

        public void DeletePerson(int id)
        {
            Person person = databasePlaceholder.Get(id);
            if (person == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            databasePlaceholder.Remove(id);
        }
    }
}