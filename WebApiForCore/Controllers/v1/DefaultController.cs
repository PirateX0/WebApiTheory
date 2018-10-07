using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiForCore.Controllers.v1
{
    [Produces("application/json")]
    //[Route("api/Default")]
    public class DefaultController : Controller
    {
        [HttpGet(nameof(Test))]
        public string Test()
        {
            return "v1";
        }

    }
}