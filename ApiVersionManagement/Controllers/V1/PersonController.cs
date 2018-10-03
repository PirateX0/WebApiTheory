using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiVersionManagement.Controllers.V1
{
    public class PersonController : ApiController
    {
        [HttpGet]
        public string Get(int id)
        {
            return "我是旧版" + id;
        }

    }
}
