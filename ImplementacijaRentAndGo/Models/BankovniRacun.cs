using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ImplementacijaRentAndGo.Models
{

    public class DatumIzBudućnosti : RangeAttribute
    {
        public DatumIzBudućnosti() : base(typeof(DateTime), DateTime.Now.ToString(), DateTime.Now.AddDays(5).ToString())
        {

        }
    }

    public class BankovniRacun
    {
        [Key]
        [Required]
        [RegularExpression(@"^[A-Z]{2}"
         + @"[0-9]{18}$",
            ErrorMessage = "Neispravan broj racuna!")]
        [System.ComponentModel.DisplayName("Broj računa:")]
        public string BrojRacuna { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatumIzBudućnosti(ErrorMessage = "Datum isteka validacije mora biti najranije 5 dana od današnjeg datuma!")]
        [System.ComponentModel.DisplayName("Datum isteka validacije:")]
        public DateTime DatumValidnostiKartice { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''\s]{1,50}$",
         ErrorMessage = "Unijeli ste neispravne podatke!")]
        [System.ComponentModel.DisplayName("Ime i prezime:")]
        public string ImePrezime { get; set; }
        [Required]
        [RegularExpression(
         @"[0-9]{13}$",
            ErrorMessage = "Unesite ispravan matični broj!")]
        [System.ComponentModel.DisplayName("JMB:")]
        public int JMB { get; set; }
        public BankovniRacun(string brojRacuna, DateTime datum, string imePrezime, int jMB)
        {
            BrojRacuna = brojRacuna;
            DatumValidnostiKartice = datum;
            ImePrezime = imePrezime;
            JMB = jMB;
        }
        public BankovniRacun() { }


    }
}
