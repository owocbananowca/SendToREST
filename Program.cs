using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SendToREST.DTO;

//Install-Package Microsoft.AspNet.WebApi.Client

//References -> Add Reference -> prawy górny róg, DataAnnotations
namespace SendToREST
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("start/n");

            REST_SENDER sender = new REST_SENDER();

            REST_SENDER.TestStuff().Wait();

            System.Console.WriteLine("/nkoniec");
            System.Console.ReadKey();
        }
    }
}
