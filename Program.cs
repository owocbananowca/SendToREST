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
        }
    }

    class SendToREST
    {
        private static HttpClient client = new HttpClient();

        SendToREST()
        {
            client.BaseAddress = new Uri("http://medicalibaryrest.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // https://www.asp.net/web-api/overview/advanced/calling-a-web-api-from-a-net-client
        // Praktycznie gotowe?
        // Nie pamiętam...

        static async Task<Uri> UniversalPost(ObjectNewDTOs obj, string uri)
        {
            
        }

        static async Task UniversalPut()
        {
            
        }
    }
}
