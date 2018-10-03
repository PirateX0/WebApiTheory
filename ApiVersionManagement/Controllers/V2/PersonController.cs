using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiVersionManagement.Controllers.V2
{
    public class PersonController : ApiController
    {
        public string Get(int id)
        {
            return "我是V2版" + id;

        }
    }
}
