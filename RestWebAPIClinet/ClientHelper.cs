using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace RestWebAPIClinet
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    partial class Program
    {
        // 发送一个HTTP GET请求给Person Controller  API:
        static JArray getAllPeople()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("http://localhost:1296/api/person/").Result;
            return response.Content.ReadAsAsync<JArray>().Result;
        }

        // 发送一个带ID参数的HTTP GET请求给Person Controller API
        static JObject getPerson(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("http://localhost:1296/api/person/" + id).Result;
            return response.Content.ReadAsAsync<JObject>().Result;
        }

        // 发送一个匿名（类）对象HTTP POST给Person Controller API
        static JObject AddPerson(string newLastName, string newFirstName)
        {
            // 初始化一个匿名对象
            var newPerson = new { LastName = newLastName, FirstName = newFirstName };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1296/");
            var response = client.PostAsJsonAsync("api/person", newPerson).Result;
            return response.Content.ReadAsAsync<JObject>().Result;

        }

        static bool UpdatePerson(int personId, string newLastName, string newFirstName)
        {
            var newPerson = new { id = personId, LastName = newLastName, FirstName = newFirstName };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1296/");
            var response = client.PutAsJsonAsync("api/person/", newPerson).Result;
            return response.Content.ReadAsAsync<bool>().Result;
        }

        static void DeletePerson(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1296/");
            var relativeUri = "api/person/" + id.ToString();
            var response = client.DeleteAsync(relativeUri).Result;
            client.Dispose();
        }

    }
}
