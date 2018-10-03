using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace TestFilter
{
    public class MyExceptionFilter : IExceptionFilter
    {
        public bool AllowMultiple => true;

        public async Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            using (StreamWriter writer = File.AppendText(@"C:/LongCode/WebApi/TestFilter/err.txt"))
            {
                await writer.WriteLineAsync(actionExecutedContext.Exception.ToString());
            }
        }

    }
}
