using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{
    [RoutePrefix("api/v1/Person")]
    public class PersonV1Controller : ApiController
    {
        [Route("{id}")]
        public string Get(int id)
        {
            return "我是旧版" + id;
        }

    }
}
