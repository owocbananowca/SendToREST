﻿using System.ComponentModel.DataAnnotations;

namespace SendToREST.DTO
{
    public class ParametrNowyDTO : ObjectNewDTOs
    {
        //public int? id_lekarz { get; set; }

        [StringLength(1)]
        public string typ { get; set; }

        [StringLength(50)]
        public string nazwa { get; set; }

        [StringLength(50)]
        public string wartosc_domyslna { get; set; }
    }
}