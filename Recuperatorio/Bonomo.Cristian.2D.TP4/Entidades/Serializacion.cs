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
    public static class Serializacion
    {

        #region Atributos y Propiedades

        static string ruta = AppDomain.CurrentDomain.BaseDirectory + "OperacionesEnLinea.xml";

        public static string Ruta
        {
            get
            {
                return ruta;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para serializar las operaciones realizadas
        /// </summary>
        /// <param name="operacionesAGuardar"></param>
        public static void EscribirAArchivo(List<Operacion> operacionesAGuardar)
        {
            using (XmlTextWriter auxWriter = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer auxSerializer = new XmlSerializer(typeof(List<Operacion>));

                    auxSerializer.Serialize(auxWriter, operacionesAGuardar);
                
            }
        }

        /// <summary>
        /// Metodo para deserializar las operaciones
        /// </summary>
        /// <returns></returns>
        public static Queue<Operacion> LeerDeArchivo()
        {
            Queue<Operacion> operacionesARestaurar = new Queue<Operacion>();
            if (File.Exists(ruta))
            {
                using (XmlTextReader auxReader = new XmlTextReader(ruta))
                {
                    XmlSerializer auxSerializer = new XmlSerializer(typeof(Operacion));

                    Operacion operacionARestaurar = new Operacion();
                    operacionARestaurar = (Operacion)auxSerializer.Deserialize(auxReader);
                    operacionesARestaurar.Enqueue(operacionARestaurar);
                }

            }
            
            return operacionesARestaurar;
        }
        #endregion
    }
}
