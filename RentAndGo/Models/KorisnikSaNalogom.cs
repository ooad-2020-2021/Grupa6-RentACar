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
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja{ get; set; }
        [Required]
        public string Lozinka { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required]
        public BankovniRacun BankovniRacun { get; set; }
        [Required]
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
