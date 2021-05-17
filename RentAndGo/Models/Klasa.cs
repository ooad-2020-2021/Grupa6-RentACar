using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public enum Klasa
    {
        [Display(Name = "MALA")]
        MALA,
        [Display(Name = "SREDNJA")]
        SREDNJA,
        [Display(Name = "VISOKA")]
        VISOKA,
        [Display(Name = "TRANSPORTNA")]
        TRANASPORTNA
    }
}
