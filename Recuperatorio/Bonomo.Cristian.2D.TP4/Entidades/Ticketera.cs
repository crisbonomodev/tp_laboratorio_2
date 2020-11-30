using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Ticketera : IArchivos<Operacion>
    {
        #region Atributos y propiedades

        static string ruta = AppDomain.CurrentDomain.BaseDirectory + "cotizaciones.xml";
        public string Ruta
        {
            get
            {
                return ruta;
            }
        }
        #endregion
        #region Metodos

        /// <summary>
        /// Metodo que imprime la cotizacion
        /// </summary>
        /// <param name="operacion"></param>
        public void ImprimirTicket(Operacion operacion)
        {
            DateTime fechaHora = new DateTime();
            fechaHora = DateTime.Now;
            StreamWriter sw = File.CreateText($"Cotizacion Nro{operacion.IdOperacion}.txt");
            sw.WriteLine($"Casa de Cambio - Recibo X - Cotizacion Nro {operacion.IdOperacion} ");
            sw.WriteLine("---------------------------");
            sw.WriteLine($"{fechaHora}");
            sw.WriteLine("---------------------------");
            sw.WriteLine($"Divisa a cotizar: {operacion.Divisa.divisa.ToString()}");
            sw.WriteLine("---------------------------");
            sw.WriteLine($"Monto:{operacion.Monto.ToString("#.##")} ");
            switch (operacion.TipoOperacion)
            {
                case CasaDeCambio.TipoDeOperacion.Compra:
                    sw.WriteLine($"Tipo de operacion:Compra");
                    sw.WriteLine($"Valor: {operacion.Divisa.ValorVenta}");
                    sw.WriteLine($"Cotización: {operacion.MontoFinal.ToString("#.##")}");
                    break;
                case CasaDeCambio.TipoDeOperacion.Venta:
                    sw.WriteLine($"Tipo de operacion:Venta");
                    sw.WriteLine($"Valor: {operacion.Divisa.ValorCompra}");
                    sw.WriteLine($"Cotización: {operacion.MontoFinal.ToString("#.##")}");
                    break;
            }
            sw.WriteLine("---------------------------");
            sw.Close();
        }

        /// <summary>
        /// Metodo que carga las cotizaciones desde un XML
        /// </summary>
        public List<Divisa> CargarCotizaciones()
        {
            List<Divisa> cotizacionesACargar = new List<Divisa>();

            if (File.Exists(ruta))
            {
                using (XmlTextReader auxReader = new XmlTextReader(ruta))
                {
                    XmlSerializer auxSerializer = new XmlSerializer(typeof(Divisa));

                    Divisa divisaARestaurar = new Divisa();
                    divisaARestaurar = (Divisa)auxSerializer.Deserialize(auxReader);
                    cotizacionesACargar.Add(divisaARestaurar);
                }

            }
            File.Delete(Ruta);

            return cotizacionesACargar;
        }
        /// <summary>
        /// Metodo que guarda las cotizaciones en un XML
        /// </summary>
        public void GuardarCotizaciones(List<Divisa> cotizacionesAGuardar)
        {
            using (XmlTextWriter auxWriter = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer auxSerializer = new XmlSerializer(typeof(Divisa));

                foreach (Divisa item in cotizacionesAGuardar)
                {
                    auxSerializer.Serialize(auxWriter, item);
                }


            }
        }
        #endregion
    }
}
