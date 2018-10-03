using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFilter
{
    public class ApiResult<T>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
    }
}