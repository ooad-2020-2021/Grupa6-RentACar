using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public enum Gorivo
    {
        [Display(Name = "Dizel")]
        DIZEL,
        [Display(Name = "Benzin")]
        BENZIN,
        [Display(Name = "Plin")]
        PLIN
    }
}
