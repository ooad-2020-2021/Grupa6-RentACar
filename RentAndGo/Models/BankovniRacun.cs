using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public class BankovniRacun
    {
        [Key]
        [Required]
        public string BrojRacuna { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumValidnostiKartice { get; set; }
        [Required]
        public string ImePrezime { get; set; }
        public BankovniRacun(string brojRacuna, DateTime datum, string imePrezime)
        {
            BrojRacuna = brojRacuna;
            DatumValidnostiKartice = datum;
            ImePrezime = imePrezime; 
        }
        public BankovniRacun() { }


    }
}
