﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalibaryREST.DTO
{
    public class ZasadaDTO
    {
        public int id { get; set; }
        public int? id_lekarz { get; set; }
        public int? id_magazynu { get; set; }
        //po tym porównianie
        public string nazwa_atrybutu { get; set; }
        //mniejsze, wieksze, rowne
        public string operacja_porownania { get; set; }
        //w stosunku do czego (liczba, string, data, kto wie)
        public string wartosc_porownania { get; set; }
        //negacja
        public bool? spelnialnosc_operacji { get; set; }
    }
}