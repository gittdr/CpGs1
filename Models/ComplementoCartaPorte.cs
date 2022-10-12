using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1.Models
{
    public class ComplementoCartaPorte
    {
        public string TranspInternac { get; set; }
        public string EntradaSalidaMerc { get; set; }
        public string TotalDistRec { get; set; }
        public string PaisOrigenDestino { get; set; }
        public string ViaEntradaSalida { get; set; }
        public List<Ubicaciones> Ubicaciones { get; set; }
        public Mercancias Mercancias { get; set; }
    }
}
