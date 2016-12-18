﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MedicalibaryREST.DTO
{
    public class PacjentNowyDTO
    {
        public int? id_magazyn { get; set; }
        public bool? aktywny { get; set; }
        [StringLength(50)]
        public string imie { get; set; }
        [StringLength(50)]
        public string nazwisko { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? pesel { get; set; }
        public int? numer_koperty { get; set; }
        public int? ilosc_dodatkowych_parametrow { get; set; }
    }
}