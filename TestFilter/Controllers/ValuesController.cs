using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestFilter.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            throw new Exception("oh my god!");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        public ApiResult<string> GetAuthorName(int i)
        {
            if (i==0)
            {
                return new ApiResult<string> { Status="error",Message="oh my god!"};
            }
            else
            {
                return new ApiResult<string> { Status="ok",Value="dalong"};
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
