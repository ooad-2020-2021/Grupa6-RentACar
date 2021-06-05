using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public enum Kategorija
    {
        [Display(Name = "A1")]
        A1,
        [Display(Name = "A")]
        A,
        [Display(Name = "B1")]
        B1,
        [Display(Name = "B")]
        B,
        [Display(Name = "C1")]
        C1,
        [Display(Name = "C")]
        C,
        [Display(Name = "D")]
        D,
        [Display(Name = "BE")]
        BE
    }
}
