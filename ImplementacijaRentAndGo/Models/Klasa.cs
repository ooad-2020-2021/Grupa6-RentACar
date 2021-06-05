using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public enum Klasa
    {
        [Display(Name = "Mala")]
        MALA,
        [Display(Name = "Srednja")]
        SREDNJA,
        [Display(Name = "Visoka")]
        VISOKA,
        [Display(Name = "Transportna")]
        TRANASPORTNA
    }
}
