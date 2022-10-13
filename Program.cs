using CpGs1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpGs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Administración\Carta Porte GS1\CartaPorteejemplo.json";
            string jsonText = File.ReadAllText(fileName);
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Cartap>(jsonText);
            //CAMPOS
            string Version = data.Mcp.Version.ToString();
            string idmensaje = data.Mcp.IDMensaje.ToString();
            string idordentrabajo = data.Mcp.IDOrdenTrabajo.ToString();
            string reemplazoidordentrabajo = data.Mcp.ReemplazoIDOrdenTrabajo.ToString();
            string fechacreacion = data.Mcp.FechaCreacion.ToString();

            //Generador del mensaje
            string id = data.Mcp.GeneradorDelMensaje.ID.ToString();
            string rfc = data.Mcp.GeneradorDelMensaje.RFC.ToString();
            string razonsocial = data.Mcp.GeneradorDelMensaje.RazonSocial.ToString();
            string correoelectronico = data.Mcp.GeneradorDelMensaje.CorreoElectronico.ToString();
            string telefono = data.Mcp.GeneradorDelMensaje.Telefono.ToString();
            string calle = data.Mcp.GeneradorDelMensaje.Domicilio.Calle.ToString();
            string numeroexterior = data.Mcp.GeneradorDelMensaje.Domicilio.NumeroExterior.ToString();
            string numerointerior = data.Mcp.GeneradorDelMensaje.Domicilio.NumeroInterior.ToString();
            string colonia = data.Mcp.GeneradorDelMensaje.Domicilio.Colonia.ToString();
            string localidad = data.Mcp.GeneradorDelMensaje.Domicilio.Localidad.ToString();
            string referencia = data.Mcp.GeneradorDelMensaje.Domicilio.Referencia.ToString();
            string municipio = data.Mcp.GeneradorDelMensaje.Domicilio.Municipio.ToString();
            string estado = data.Mcp.GeneradorDelMensaje.Domicilio.Estado.ToString();
            string pais = data.Mcp.GeneradorDelMensaje.Domicilio.Pais.ToString();
            string codigopostal = data.Mcp.GeneradorDelMensaje.Domicilio.CodigoPostal.ToString();
            dynamic infor = new List<InformacionAdicional>(data.Mcp.GeneradorDelMensaje.InformacionAdicional);
            foreach (var item in infor)
            {
                Console.WriteLine("Clave: " + item.Clave + " - " + "Valor: " + item.Valor);
              
            }
            //Receptor del mensaje
            string rid = data.Mcp.ReceptorDelMensaje.ID.ToString();
            string rrfc = data.Mcp.ReceptorDelMensaje.RFC.ToString();
            string rrazonsocial = data.Mcp.ReceptorDelMensaje.RazonSocial.ToString();
            string rcorreoelectronico = data.Mcp.ReceptorDelMensaje.CorreoElectronico.ToString();
            string rtelefono = data.Mcp.ReceptorDelMensaje.Telefono.ToString();
            string rcalle = data.Mcp.ReceptorDelMensaje.Domicilio.Calle.ToString();
            string rnumeroexterior = data.Mcp.ReceptorDelMensaje.Domicilio.NumeroExterior.ToString();
            string rnumerointerior = data.Mcp.ReceptorDelMensaje.Domicilio.NumeroInterior.ToString();
            string rcolonia = data.Mcp.ReceptorDelMensaje.Domicilio.Colonia.ToString();
            string rlocalidad = data.Mcp.ReceptorDelMensaje.Domicilio.Localidad.ToString();
            string rreferencia = data.Mcp.ReceptorDelMensaje.Domicilio.Referencia.ToString();
            string rmunicipio = data.Mcp.ReceptorDelMensaje.Domicilio.Municipio.ToString();
            string restado = data.Mcp.ReceptorDelMensaje.Domicilio.Estado.ToString();
            string rpais = data.Mcp.ReceptorDelMensaje.Domicilio.Pais.ToString();
            string rcodigopostal = data.Mcp.ReceptorDelMensaje.Domicilio.CodigoPostal.ToString();
            dynamic rinfor = new List<InformacionAdicional>(data.Mcp.ReceptorDelMensaje.InformacionAdicional);
            foreach (var ritem in rinfor)
            {
                Console.WriteLine("Clave: " + ritem.Clave + " - " + "Valor: " + ritem.Valor);

            }

            //Información del mensaje
            dynamic dinfor = new List<InformacionDelMensaje>(data.Mcp.InformacionDelMensaje);
            foreach (var ditem in dinfor)
            {
                Console.WriteLine("Clave: " + ditem.Clave + " - " + "Valor: " + ditem.Valor);

            }

            //Complemento Carta Porte
            string transpInternac = data.Mcp.ComplementoCartaPorte.TranspInternac.ToString();
            string entradaSalidaMerc = data.Mcp.ComplementoCartaPorte.EntradaSalidaMerc.ToString();
            string paisOrigenDestino = data.Mcp.ComplementoCartaPorte.PaisOrigenDestino.ToString();
            string viaEntradaSalida = data.Mcp.ComplementoCartaPorte.ViaEntradaSalida.ToString();

            //Ubicaciones
            dynamic uinfor = new List<Ubicaciones>(data.Mcp.ComplementoCartaPorte.Ubicaciones);
            foreach (var uitem in uinfor)
            {
                string tipoubicacion = uitem.TipoUbicacion;
                //string idubicacion = uitem.IDUbicacion;
                string rfcremitentedestinatario = uitem.RFCRemitenteDestinatario;
                string nombreremitentedestinatario = uitem.NombreRemitenteDestinatario;
                string numregidtrib = uitem.NumRegIdTrib;
                string residenciafiscal = uitem.ResidenciaFiscal;
                string fechahorasalidallegada = uitem.FechaHoraSalidaLlegada;

                string ucalle = uitem.Domicilio.Calle;
                string unumeroexterior = uitem.Domicilio.NumeroExterior;
                string unumerointerior = uitem.Domicilio.NumeroInterior;
                string ucolonia = uitem.Domicilio.Colonia;
                string ulocalidad = uitem.Domicilio.Localidad;
                string ureferencia = uitem.Domicilio.Referencia;
                string umunicipio = uitem.Domicilio.Municipio;
                string uestado = uitem.Domicilio.Estado;
                string upais = uitem.Domicilio.Pais;
                string ucodigopostal = uitem.Domicilio.CodigoPostal;

            }

            //Mercancias
            string pesobrutototal = data.Mcp.ComplementoCartaPorte.Mercancias.PesoBrutoTotal.ToString();
            string unidadpeso = data.Mcp.ComplementoCartaPorte.Mercancias.UnidadPeso.ToString();
            string numtotalmercancias = data.Mcp.ComplementoCartaPorte.Mercancias.NumTotalMercancias.ToString();

            //Mercancia

            dynamic minfor = new List<Mercancia>(data.Mcp.ComplementoCartaPorte.Mercancias.Mercancia);
            foreach (var mitem in minfor)
            {
                string bienestransp = mitem.BienesTransp;
                string descripcion = mitem.Descripcion;
                int cantidad = mitem.Cantidad;
                string claveunidad = mitem.ClaveUnidad;
                string unidad = mitem.Unidad;
                string dimensiones = mitem.Dimensiones;
                string materialpeligroso = mitem.MaterialPeligroso;
                string cvematerialpeligroso = mitem.CveMaterialPeligroso;
                string embalaje = mitem.Embalaje;
                string descripembalaje = mitem.DescripEmbalaje;
                int pesoenkg = mitem.PesoEnKg;
                int valormercancia = mitem.ValorMercancia;
                string moneda = mitem.Moneda;
                string fraccionArracelaria = mitem.FraccionArracelaria;
                string uuidcomercioext = mitem.UUIDComercioExt;

                //Cantidad Transporta
                int tcantidad = mitem.CantidadTransporta.Cantidad;
                string idorigen = mitem.CantidadTransporta.IDOrigen;
                string iddestino = mitem.CantidadTransporta.IDDestino;

                //Detalle mercancia
                string unidadpesomerc = mitem.DetalleMercancia.UnidadPesoMerc;
                int pesobruto = mitem.DetalleMercancia.PesoBruto;
                int pesoneto = mitem.DetalleMercancia.PesoNeto;
                int pesotara = mitem.DetalleMercancia.PesoTara;
                int numpiezas = mitem.DetalleMercancia.NumPiezas;
            }




        }
    }
}
