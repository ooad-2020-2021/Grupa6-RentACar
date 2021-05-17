using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndGo.Models
{
    public enum Mjenjac
    { 
        [Display(Name = "MANUELNI")]
        MANUELNI,
        [Display(Name = "AUTOMATIK")]
        AUTOMATIK
    }
}
