using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1.Models
{
    public class Mcp
    {
        public string Version { get; set; }
        public string IDMensaje { get; set; }
        public string IDOrdenTrabajo { get; set; }
        public string ReemplazoIDOrdenTrabajo { get; set; }
        public string FechaCreacion { get; set; }

        public GeneradorDelMensaje GeneradorDelMensaje { get; set; }
        public ReceptorDelMensaje ReceptorDelMensaje { get; set; }
        public InformacionDelMensaje InformacionDelMensaje { get; set; }
    }
}
