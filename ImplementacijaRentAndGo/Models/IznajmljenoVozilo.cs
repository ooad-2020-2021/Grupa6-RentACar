using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class IznajmljenoVozilo
    {
        private Vozilo vozilo;
        private Iznajmljivanje iznajmljivanje;
        public Iznajmljivanje Iznajmljivanje { get; set; }
        public Vozilo Vozilo { get; set; }
    }
}
