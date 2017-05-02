using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestWebAPIClinet
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program will start......");

            JArray people = getAllPeople();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }


            Console.WriteLine(Environment.NewLine + "根据ID=2查询:");
            JObject singlePerson = getPerson(2);
            Console.WriteLine(singlePerson);


            Console.WriteLine(Environment.NewLine + "添加一个新对象并返回");
            JObject newPerson = AddPerson("曼迪", "石");
            Console.WriteLine(newPerson);


            Console.WriteLine(Environment.NewLine + "更新一个已经存在的对象并返回成功与否");

            JObject personToUpdate = getPerson(2);
            string newLastName = "麻子";
            Console.WriteLine("Update Last Name of " + personToUpdate + "to " + newLastName);


            int id = personToUpdate.Value<int>("Id");
            string FirstName = personToUpdate.Value<string>("FirstName");
            string LastName = personToUpdate.Value<string>("LastName");


            if (UpdatePerson(id, newLastName, FirstName))
            {
                Console.WriteLine(Environment.NewLine + "更新person:");
                Console.WriteLine(getPerson(id));
            }


            Console.WriteLine(Environment.NewLine + "删除ID为5的对象:");

            DeletePerson(5);

            Console.WriteLine("输出所有对象");
            people = getAllPeople();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.Read();
        }
    }
}
