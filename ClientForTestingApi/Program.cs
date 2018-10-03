using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientForTestingApi
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string res= httpClient.GetStringAsync("http://localhost:43386/api/Person").Result;
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
