using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public class VozackaDozvola
    {
        [Key]
        [Required]
        public int BrojVozackeDozvole { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string NadlezniOrgan { get; set; }
        [Required]
        public Kategorija Kategorija { get; set; }

        public VozackaDozvola(){}
    }
}
