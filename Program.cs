using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SendToREST.DTO;

//Bez tych dwóch nie będzie działało

//Install-Package Microsoft.AspNet.WebApi.Client                    <- Klient do komunikacji

//References -> Add Reference -> prawy górny róg, DataAnnotations   <- Opisy niektórych zmiennych, głównie jest tu po to żeby zmienne tutaj były identyczne co te na serwerze.
namespace SendToREST
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("start/n");

            // Inicjalizuje wartości klienta.
            REST_SENDER sender = new REST_SENDER();

            // Przykładowe wywołanie. wait() czeka aż się wykona.
            REST_SENDER.TestStuff().Wait();

            System.Console.WriteLine("/nkoniec");
            System.Console.ReadKey();
        }
    }
}
