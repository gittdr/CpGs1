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
            string fileName = @"C:\Administración\Carta Porte GS1\Cpp.json";
            string jsonText = File.ReadAllText(fileName);
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Cartap>(jsonText);
            //CAMPOS
            string Version = data.Mcp.Version.ToString();
            string idmensaje = data.Mcp.IDMensaje.ToString();
            string idordentrabajo = data.Mcp.IDOrdenTrabajo.ToString();
            string reemplazoidordentrabajo = data.Mcp.ReemplazoIDOrdenTrabajo.ToString();
            string fechacreacion = data.Mcp.FechaCreacion.ToString();
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

        }
    }
}
