using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class Vozilo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string SlikaVozila { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [EnumDataType(typeof(Gorivo))]
        public Gorivo Gorivo { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [EnumDataType(typeof(Klasa))]
        public Klasa Klasa { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [EnumDataType(typeof(Mjenjac))]
        public Mjenjac Mjenjac { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [EnumDataType(typeof(Lokacija))]
        public Lokacija Lokacija { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [Range(2, 20, ErrorMessage = "Vrijednost za broj sjedišta mora biti između 2 i 20.")]
        public int MaksimalanBrojPutnika { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [Range(0, 200, ErrorMessage = "Vrijednost za cijenu mora biti između 0 i 200.")]
        public int CijenaPoDanu { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [DataType(DataType.Date)]
        public DateTime DatumTehnickogPregleda { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        [RegularExpression("^[AEJKMOT][0-9][0-9]-[AEJKMOT]-[0-9][0-9][0-9]$", ErrorMessage = "Neispravan format registracijskih tablica!")]
        public string BrojRegistacijskihTablica { get; set; }

        [Required]
        [Display(Name = "Klima")]
        public bool Klima { get; set; }

        [Required]
        [Display(Name = "Sistem bez ključa")]
        public bool SistemBezKljuca { get; set; }

        [Required]
        [Display(Name = "Aluminijske felge")]
        public bool AluminijskeFelge { get; set; }

        [Required]
        [Display(Name = "Sklopivi retrovizori")]
        public bool SklopiviRetrovizori { get; set; }

        [Required]
        [Display(Name = "Board Computer")]
        public bool BoardComputer { get; set; }
            
        [Required]
        [Display(Name = "MP3 Interfejs")]
        public bool MP3Interfejs { get; set; }

        public Vozilo(int id, string naziv)
        {
            id = GenerišiID();
            Naziv = naziv;

        }
        public Vozilo() { }

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
