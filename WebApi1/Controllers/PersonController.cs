using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{
    public class PersonController : ApiController
    {
        //public IEnumerable<string> Get()//用 /api/Person访问。不要忘了加“/api”这个前缀
        //{
        //    return new string[] { "value1", "value2" };
        //}

        ////public string Get(int id) //用 /api/Person/3 或者/api/Person?id=3访问
        ////{
        ////    return "value";
        ////}

        //public Person Get(int id) //用 /api/Person/3 或者/api/Person?id=3访问
        //{
        //    return new Person { Name="dalong",Age=18};
        //}

        //public string Get(string name) //用 /api/Person?name=yzk访问
        //{
        //    return name;
        //}

        //// POST api/<controller>
        //public string Post([FromBody]string value)
        //{
        //    return "收到Post，value=" + value;
        //}
        //// PUT api/<controller>/5
        //public string Put(int id, [FromBody]string value)
        //{
        //    return "收到Put，id=" + id + "，value=" + value;
        //}
        //// DELETE api/<controller>/5
        //public string Delete(int id)
        //{
        //    return "收到Delete，id=" + id;
        //}

        //==============
        //上面是restful风格【坑】，下面是mvc风格
        //==============

        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        public Person GetById(int id) 
        {
            return new Person { Name = "dalong", Age = 18 };
        }

        public string GetPerson([FromUri]Person person)
        {
            return "name=" + person.Name + ", age=" + person.Age;
        }

        public string AddNew(Person person)
        {
            return "add successfully, name="+person.Name+", age="+person.Age;
        }



    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
