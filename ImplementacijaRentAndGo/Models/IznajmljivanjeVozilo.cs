using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class IznajmljivanjeVozilo
    {
        public IEnumerable<Iznajmljivanje>  Iznajmljivanje { get; set; }
        public IEnumerable<Vozilo> Vozilo { get; set; }
    }
}
