using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class Record
    {
        public Record(string datumPocetka, string datumKraja, Lokacija lokacija)
        {
            DatumPocetka = datumPocetka;
            DatumKraja = datumKraja;
            Lokacija = lokacija;
        }

        public string DatumPocetka { get; set; }
        public string DatumKraja { get; set; }
        public Lokacija Lokacija { get; set; }

    }
}
