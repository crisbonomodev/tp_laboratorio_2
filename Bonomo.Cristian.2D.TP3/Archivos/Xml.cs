using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T>: IArchivo<T>
    {
        public bool Leer(string archivo, out T data)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(T)));
                    data = (T)ser.Deserialize(reader);
                }
                return true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }

        public bool Guardar(string archivo, T data)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, data);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
