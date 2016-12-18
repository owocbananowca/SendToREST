﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MedicalibaryREST.DTO
{
    public class WizytaNowaDTO
    {
        public int? id_pacjent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_wizyty { get; set; }

        [StringLength(255)]
        public string komentarz { get; set; }
    }
}