using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{
    [RoutePrefix("api/Dog")]
    public class DogController : ApiController
    {
        [Route("Hello")]
        [HttpGet]
        public string Hello()
        {
            return "hello dalong";
        }

        [Route("AddNew/{name}/{age}")]
        [HttpPost]
        public string AddNew(string name,string age)
        {
            return "add successfully, name=" + name + ", age=" + age;
        }


    }
}
