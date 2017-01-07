using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SendToREST.DTO;
using Newtonsoft.Json.Serialization;

namespace SendToREST
{
    class REST_SENDER
    {
        private static HttpClient client = new HttpClient();

        public REST_SENDER()
        {
            client.BaseAddress = new Uri("http://medicalibaryrest.azurewebsites.net");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // używając dodać await przed wywołaniem
        public static async Task UniversalPost(ObjectNewDTOs obj, string uri)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(uri, obj);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UniversalPut(ObjectNewDTOs obj, string uri)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(uri, obj);
            response.EnsureSuccessStatusCode();
        }

        // https://www.asp.net/web-api/overview/advanced/calling-a-web-api-from-a-net-client

        /*
         * Pobierz jeden*:
         *      dane_modyfikacji
         *      magazyn
         *      modyfikacja
         *      pacjent
         *      parametr
         *      przypisanie_parametru
         *      wersja
         *      wizyta
         *      zasada
         *      
         *      Zrób dla każdej funkcję, która sprawdzi czy dla updateowanego obiektu są null'e.
         *      Jeśli są to wypełnij je danymi obiektu o tym samym id w odp liście.
         *      Obiekty masz w nazwaDTO.
         */

        public static void ReplaceThisStuff(string a)
        {
            a.Replace("[", "");
            a.Replace("]", "");
            //return a;
        }
        //pobieram jeden po id
        public static async Task<List<DaneModyfikacjiNoweDTO>> DaneModyfikacjiGET(int lid, int id)
        {
            List<DaneModyfikacjiNoweDTO> lista = null;
            string uri = "/danemodyfikacji/"+ lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<DaneModyfikacjiNoweDTO>>(list2);
            }
            return lista;
        }
        // zakładam że id zawsze wysłane :v
        // i że jest taki obj :v
        public static async Task DaneModyfikacjiPut(DaneModyfikacjiNoweDTO obj, int lid)
        {
            List<DaneModyfikacjiNoweDTO> prev = null;
            DaneModyfikacjiNoweDTO prevObj = new DaneModyfikacjiNoweDTO();
            prev = await DaneModyfikacjiGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.id_modyfikacja == null)
            {
                obj.id_modyfikacja = prevObj.id_modyfikacja;
            }
            if (obj.nazwa_danej == null)
            {
                obj.nazwa_danej = prevObj.nazwa_danej;
            }
            if (obj.nowa_wartosc == null)
            {
                obj.nowa_wartosc = prevObj.nowa_wartosc;
            }
            if (obj.stara_wartosc == null)
            {
                obj.stara_wartosc = prevObj.stara_wartosc;
            }
            string uri = "/danemodyfikacji/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            DaneModyfikacjiSendDTO objToSend = new DaneModyfikacjiSendDTO()
            {
                id_modyfikacja = obj.id_modyfikacja,
                nazwa_danej = obj.nazwa_danej,
                nowa_wartosc = obj.nowa_wartosc,
                stara_wartosc = obj.stara_wartosc
            };


            UniversalPut(objToSend, uri);
        }



        public static async Task TestStuff()
        {
            /*List<DaneModyfikacjiNoweDTO> list = null;

            list = await REST_SENDER.DaneModyfikacjiGET(1,2);
            DaneModyfikacjiNoweDTO obj = new DaneModyfikacjiNoweDTO();
            obj = list.Where(e => e.id == 2).First();

            Console.WriteLine(obj.nazwa_danej);*/
            DaneModyfikacjiNoweDTO obj = new DaneModyfikacjiNoweDTO()
            {
                id = 2,
                id_modyfikacja = 1,
                //nazwa_danej = "pole",
                stara_wartosc = "vvvv1",
                nowa_wartosc = "vvvv2"
            };
            DaneModyfikacjiPut(obj, 1);
            Console.WriteLine("Wyslane");
        }
    }
}
