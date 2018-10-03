using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{
    public class ReturnTypeController : ApiController
    {
        [HttpGet]
        public void Hello()
        {

        }

        [HttpGet]
        public IHttpActionResult Hi(int i)
        {
            switch (i)
            {
                case 1:
                    return Ok();
                case 2:
                    return NotFound();
                case 3:
                    return BadRequest();
                case 4:
                    return Json(new Person() { Name="dalong",Age=18});
                case 5:
                    return Content(HttpStatusCode.Forbidden,"don't have permisson");
                default:
                    return InternalServerError();
            }
        }

        [HttpGet]
        public HttpResponseMessage Hey()
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            httpResponseMessage.Content = new StringContent("hey");
            httpResponseMessage.Headers.Add("author","dalong");
            httpResponseMessage.StatusCode = HttpStatusCode.OK;
            return httpResponseMessage;
        }
    }
}
