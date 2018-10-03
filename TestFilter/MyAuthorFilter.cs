using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TestFilter
{
    public class MyAuthorFilter : IAuthorizationFilter
    {
        //public bool AllowMultiple => true;

        public bool AllowMultiple
        {
            get
            {
                return true;
            }
        }

        public async Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            IEnumerable<string> values;
            if (actionContext.Request.Headers.TryGetValues("UserName", out values))
            {
                string userName = values.FirstOrDefault();
                if (userName != "admin")
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
                httpResponseMessage.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                httpResponseMessage.Content = new StringContent("no permission");
                return httpResponseMessage;
            }
            return await continuation();
        }



    }
}
