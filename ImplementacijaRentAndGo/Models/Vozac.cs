using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class Vozac
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required]
        public string BrojVozackeDozvole { get; set; }

        public string SlikaVozaca { get; set; }
        public Vozac() { }
    }
}
