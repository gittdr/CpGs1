using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1.Models
{
    public class Ubicaciones
    {
        
        public string TipoUbicacion { get; set; }
        public string IDUbicacion { get; set; }
        public string IDDestino { get; set; }
        public string RFCRemitenteDestinatario { get; set; }
        public string NombreRemitenteDestinatario { get; set; }
        public string NumRegIdTrib { get; set; }
        public string ResidenciaFiscal { get; set; }
        public string FechaHoraSalidaLlegada { get; set; }
        public string DistanciaRecorrida { get; set; }
        public Domicilio Domicilio { get; set; }

    }
}
