using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1.Models
{
    public class Mercancia
    {
        public string BienesTransp { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Dimensiones { get; set; }
        public string MaterialPeligroso { get; set; }
        public string CveMaterialPeligroso { get; set; }
        public string Embalaje { get; set; }
        public string DescripEmbalaje { get; set; }
        public string PesoEnKg { get; set; }
        public string ValorMercancia { get; set; }
        public string Moneda { get; set; }
        public string FraccionArracelaria { get; set; }
        public string UUIDComercioExt { get; set; }
        public List<GuiasIdentificacion> GuiasIdentificacion { get; set; }
        public List<Pedimentos> Pedimentos { get; set; }
        public List<CantidadTransporta> CantidadTransporta { get; set; }
        public DetalleMercancia DetalleMercancia { get; set; }


    }
}
