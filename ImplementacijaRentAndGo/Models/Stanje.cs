using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public enum Stanje
    {

        [Display(Name = "KOMPLETIRAN")]
        KOMPLETIRAN,
        [Display(Name = "OTKAZAN")]
        OTKAZAN,
        [Display(Name = "ODOBREN")]
        ODOBREN,
        [Display(Name = "CEKA")]
        CEKA,
        [Display(Name = "OBRADA")]
        OBRADA
    }
}
