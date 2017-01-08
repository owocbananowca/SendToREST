﻿using System;
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
         *      wersja . jebać lol :v
         *      zasada .
         */

        public static void ReplaceThisStuff(string a)
        {
            a.Replace("[", "");
            a.Replace("]", "");
        }

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

        public static async Task<List<MagazynNowyDTO>> MagazynGET(int lid, int id)
        {
            List<MagazynNowyDTO> lista = null;
            string uri = "/magazyn/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<MagazynNowyDTO>>(list2);
            }
            return lista;
        }

        public static async Task<List<ModyfikacjaNowaDTO>> ModyfikacjaGET(int lid, int id)
        {
            List<ModyfikacjaNowaDTO> lista = null;
            string uri = "/modyfikacja/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<ModyfikacjaNowaDTO>>(list2);
            }
            return lista;
        }

        public static async Task<List<PacjentNowyDTO>> PacjentGET(int lid, int id)
        {
            List<PacjentNowyDTO> lista = null;
            string uri = "/pacjent/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<PacjentNowyDTO>>(list2);
            }
            return lista;
        }

        public static async Task<List<ParametrNowyDTO>> ParametrGET(int lid, int id)
        {
            List<ParametrNowyDTO> lista = null;
            string uri = "/parametr/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<ParametrNowyDTO>>(list2);
            }
            return lista;
        }

        public static async Task<List<Przypisanie_ParametruNowyDTO>> PrzypisanieParametruGET(int lid, int id)
        {
            List<Przypisanie_ParametruNowyDTO> lista = null;
            string uri = "/przypisanie/listapoid/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<Przypisanie_ParametruNowyDTO>>(list2);
            }
            return lista;
        }
        // Niepotrzebne ale jakoś z rozpędu się zrobiło :v
        public static async Task<List<WersjaNowaDTO>> WersjaGET(int lid, int id)
        {
            List<WersjaNowaDTO> lista = null;
            string uri = "/wersja/lista/" + lid.ToString();// + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<WersjaNowaDTO>>(list2);
            }
            return lista;
        }

        public static async Task<List<WizytaNowaDTO>> WizytaGET(int lid, int id)
        {
            List<WizytaNowaDTO> lista = null;
            string uri = "/wizyta/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<WizytaNowaDTO>>(list2);
            }
            return lista;
        }

        public static async Task<List<ZasadaNowaDTO>> ZasadaGET(int lid, int id)
        {
            List<ZasadaNowaDTO> lista = null;
            string uri = "/zasada/lista/" + lid.ToString() + "/" + id.ToString();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var list2 = await response.Content.ReadAsStringAsync();
                ReplaceThisStuff(list2);
                lista = JsonConvert.DeserializeObject<List<ZasadaNowaDTO>>(list2);
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

        public static async Task MagazynPut(MagazynNowyDTO obj, int lid)
        {
            List<MagazynNowyDTO> prev = null;
            MagazynNowyDTO prevObj = new MagazynNowyDTO();
            prev = await MagazynGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.max_rozmiar == null)
            {
                obj.max_rozmiar = prevObj.max_rozmiar;
            }
            if (obj.nazwa == null)
            {
                obj.nazwa = prevObj.nazwa;
            }
            if (obj.priorytet == null)
            {
                obj.priorytet = prevObj.priorytet;
            }

            string uri = "/magazyn/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            MagazynToSendDTO objToSend = new MagazynToSendDTO()
            {
                max_rozmiar = obj.max_rozmiar,
                nazwa = obj.nazwa,
                priorytet = obj.priorytet
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task ModyfikacjaPut(ModyfikacjaNowaDTO obj, int lid)
        {
            List<ModyfikacjaNowaDTO> prev = null;
            ModyfikacjaNowaDTO prevObj = new ModyfikacjaNowaDTO();
            prev = await ModyfikacjaGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.id_obiekt == null)
            {
                obj.id_obiekt = prevObj.id_obiekt;
            }
            if (obj.id_wersji == null)
            {
                obj.id_wersji = prevObj.id_wersji;
            }
            if (obj.obiekt == null)
            {
                obj.obiekt = prevObj.obiekt;
            }
            if (obj.operaca == null)
            {
                obj.operaca = prevObj.operaca;
            }

            string uri = "/modyfikacja/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            ModyfikacjaToSend objToSend = new ModyfikacjaToSend()
            {
                id_obiekt = obj.id_obiekt,
                id_wersji = obj.id_wersji,
                obiekt = obj.obiekt,
                operaca = obj.operaca
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task PacjentPut(PacjentNowyDTO obj, int lid)
        {
            List<PacjentNowyDTO> prev = null;
            PacjentNowyDTO prevObj = new PacjentNowyDTO();
            prev = await PacjentGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.aktywny == null)
            {
                obj.aktywny = prevObj.aktywny;
            }
            if (obj.id_magazyn == null)
            {
                obj.id_magazyn = prevObj.id_magazyn;
            }
            if (obj.ilosc_dodatkowych_parametrow == null)
            {
                obj.ilosc_dodatkowych_parametrow = prevObj.ilosc_dodatkowych_parametrow;
            }
            if (obj.imie == null)
            {
                obj.imie = prevObj.imie;
            }
            if (obj.nazwisko == null)
            {
                obj.nazwisko = prevObj.nazwisko;
            }
            if (obj.numer_koperty == null)
            {
                obj.numer_koperty = prevObj.numer_koperty;
            }
            if (obj.pesel == null)
            {
                obj.pesel = prevObj.pesel;
            }

            string uri = "/pacjent/zmiana/" + lid.ToString() + "/" + obj.id.ToString();
            PacjentToSendDTO objToSend = new PacjentToSendDTO()
            {
                aktywny = obj.aktywny,
                id_magazyn = obj.id_magazyn,
                ilosc_dodatkowych_parametrow = obj.ilosc_dodatkowych_parametrow,
                imie = obj.imie,
                nazwisko = obj.nazwisko,
                numer_koperty = obj.numer_koperty,
                pesel = obj.pesel
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task ParametrPut(ParametrNowyDTO obj, int lid)
        {
            List<ParametrNowyDTO> prev = null;
            ParametrNowyDTO prevObj = new ParametrNowyDTO();
            prev = await ParametrGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.nazwa == null)
            {
                obj.nazwa = prevObj.nazwa;
            }
            if (obj.typ == null)
            {
                obj.typ = prevObj.typ;
            }
            if (obj.wartosc_domyslna == null)
            {
                obj.wartosc_domyslna = prevObj.wartosc_domyslna;
            }

            string uri = "/parametr/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            ParametrToSendDTO objToSend = new ParametrToSendDTO()
            {
                nazwa = obj.nazwa,
                typ = obj.typ,
                wartosc_domyslna = obj.wartosc_domyslna
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task PrzypisanieParametruPut(Przypisanie_ParametruNowyDTO obj, int lid)
        {
            List<Przypisanie_ParametruNowyDTO> prev = null;
            Przypisanie_ParametruNowyDTO prevObj = new Przypisanie_ParametruNowyDTO();
            prev = await PrzypisanieParametruGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.id_pacjent == null)
            {
                obj.id_pacjent = prevObj.id_pacjent;
            }
            if (obj.id_parametr == null)
            {
                obj.id_parametr = prevObj.id_parametr;
            }
            if (obj.wartosc == null)
            {
                obj.wartosc = prevObj.wartosc;
            }

            string uri = "/przypisanie/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            Przypisanie_ParametruToSendDTO objToSend = new Przypisanie_ParametruToSendDTO()
            {
                id_pacjent = obj.id_pacjent,
                id_parametr = obj.id_parametr,
                wartosc = obj.wartosc
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task WizytaPut(WizytaNowaDTO obj, int lid)
        {
            List<WizytaNowaDTO> prev = null;
            WizytaNowaDTO prevObj = new WizytaNowaDTO();
            prev = await WizytaGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.data_wizyty == null)
            {
                obj.data_wizyty = prevObj.data_wizyty;
            }
            if (obj.id_pacjent == null)
            {
                obj.id_pacjent = prevObj.id_pacjent;
            }
            if (obj.komentarz == null)
            {
                obj.komentarz = prevObj.komentarz;
            }

            string uri = "/wizyta/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            WizytaToSend objToSend = new WizytaToSend()
            {
                data_wizyty = obj.data_wizyty,
                id_pacjent = obj.id_pacjent,
                komentarz = obj.komentarz
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task ZasadaPut(ZasadaNowaDTO obj, int lid)
        {
            List<ZasadaNowaDTO> prev = null;
            ZasadaNowaDTO prevObj = new ZasadaNowaDTO();
            prev = await ZasadaGET(lid, obj.id);
            prevObj = prev.Where(e => e.id == obj.id).First();

            if (obj.id_magazynu == null)
            {
                obj.id_magazynu = prevObj.id_magazynu;
            }
            if (obj.nazwa_atrybutu == null)
            {
                obj.nazwa_atrybutu = prevObj.nazwa_atrybutu;
            }
            if (obj.operacja_porownania == null)
            {
                obj.operacja_porownania = prevObj.operacja_porownania;
            }
            if (obj.spelnialnosc_operacji == null)
            {
                obj.spelnialnosc_operacji = prevObj.spelnialnosc_operacji;
            }
            if (obj.wartosc_porownania == null)
            {
                obj.wartosc_porownania = prevObj.wartosc_porownania;
            }

            string uri = "/zasada/zmiana/" + lid.ToString() + "/" + obj.id.ToString();

            ZasadaToSendDTO objToSend = new ZasadaToSendDTO()
            {
                id_magazynu = obj.id_magazynu,
                nazwa_atrybutu = obj.nazwa_atrybutu,
                operacja_porownania = obj.operacja_porownania,
                spelnialnosc_operacji = obj.spelnialnosc_operacji,
                wartosc_porownania = obj.wartosc_porownania
            };
            UniversalPut(objToSend, uri);
        }

        public static async Task TestStuff()
        {
            /*DaneModyfikacjiNoweDTO obj = new DaneModyfikacjiNoweDTO()
            {
                id = 2,
                id_modyfikacja = 1,
                //nazwa_danej = "pole",
                stara_wartosc = "vvvv1",
                nowa_wartosc = "vvvv2"
            };
            DaneModyfikacjiPut(obj, 1);
            Console.WriteLine("Wyslane");*/
        }
    }
}
