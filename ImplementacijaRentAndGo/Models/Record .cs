using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class Record
    {
        public int ID { get; set; }
        public string ImeVozila { get; set; }
        public string SlikaVozila { get; set; }
        public Lokacija Lokacija { get; set; }

    }
}
