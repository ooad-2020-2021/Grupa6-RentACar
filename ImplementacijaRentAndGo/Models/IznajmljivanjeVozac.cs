using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementacijaRentAndGo.Models
{
    public class IznajmljivanjeVozac
    {
        public Iznajmljivanje  Iznajmljivanje { get; set; }
        public IEnumerable<Vozac> Vozac { get; set; }
    }
}
