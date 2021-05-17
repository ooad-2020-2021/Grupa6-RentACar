using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public enum Gorivo
    {
        [Display(Name = "DIZEL")]
        DIZEL,
        [Display(Name = "BENZIN")]
        BENZIN,
        [Display(Name = "PLIN")]
        PLIN
    }
}
