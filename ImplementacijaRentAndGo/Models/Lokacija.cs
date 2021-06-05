using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public enum Lokacija

    {
        [Display(Name = "Nije dostupno")]
        NEDOSTUPNO,
        [Display(Name = "Sarajevo")]
        SARAJEVO,
        [Display(Name = "Mostar")]
        MOSTAR,
        [Display(Name = "Zenica")]
        ZENICA
    }
}
