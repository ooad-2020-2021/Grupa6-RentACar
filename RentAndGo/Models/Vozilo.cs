using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public class Vozilo
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }

        [Required]
        public string SlikaVozila { get; set; }

        [Required]
        [EnumDataType(typeof(Gorivo))]
        public Gorivo Gorivo { get; set; }
        [Required]
        [EnumDataType(typeof(Klasa))]
        public Klasa Klasa { get; set; }
        [Required]
        [EnumDataType(typeof(Mjenjac))]
        public Mjenjac Mjenjac { get; set; }
        [Required]
        public int MaksimalanBrojPutnika { get; set; }
        [Required]
        public int CijenaPoDanu { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumTehnickogPregleda { get; set; }
        [Required]
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
