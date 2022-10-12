using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1.Models
{
    public class GeneradorDelMensaje
    {
        public string ID { get; set; }
        public string RFC { get; set; }
        public string RazonSocial { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public Domicilio Domicilio { get; set; }
        public List<InformacionAdicional> InformacionAdicional { get; set; }
    }
}
