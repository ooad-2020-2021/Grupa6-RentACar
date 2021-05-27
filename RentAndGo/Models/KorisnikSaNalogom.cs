using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public class KorisnikSaNalogom
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimalno 3 karaktera!")]
        public string Ime { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimalno 3 karaktera!")]

        public string Prezime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja{ get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Minimalno 8 karaktera!")]
        public string Lozinka { get; set; }
        [Required]
        [RegularExpression(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
         + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				    [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				    [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
         + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$",
            ErrorMessage = "Neispravan format e-mail adrese!")]
        public string Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Minimalno 6 karaktera!")]
        public string BrojTelefona { get; set; }

        public BankovniRacun BankovniRacun { get; set; }

        public string BrojVozackeDozvole { get; set; }
        public KorisnikSaNalogom() { }


        public KorisnikSaNalogom(int id, string ime, string prezime, DateTime datumRodenja,  string lozinka, string email, string brojTel)
        {
            id = GenerišiID();
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodenja;
            Lozinka = lozinka;
            Email = email;
            BrojTelefona = BrojTelefona;
            BrojVozackeDozvole = null;
        }
        #region Metode
        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }
        #endregion

    }
}
