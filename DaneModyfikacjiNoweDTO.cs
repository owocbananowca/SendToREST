using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SendToREST.DTO;

namespace SendToREST
{
    public class DaneModyfikacjiNoweDTO : ObjectNewDTOs 
    {
        public int? id_modyfikacja { get; set; }

        //public int? id_lekarz { get; set; }

        [StringLength(50)]
        public string nazwa_danej { get; set; }

        [StringLength(50)]
        public string stara_wartosc { get; set; }

        [StringLength(50)]
        public string nowa_wartosc { get; set; }
    }
}