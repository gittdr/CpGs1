using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1.Models
{
    public class Mercancias
    {
        public string PesoBrutoTotal { get; set; }
        public string PesoNetoTotal { get; set; }
        public string UnidadPeso { get; set; }
        public string NumTotalMercancias { get; set; }

        public List<Mercancia> Mercancia { get; set; }
    }
}
