using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto:IArchivo<string>
    {
        public bool Leer(string archivo, out string texto)
        {
            try
            {
                using (StreamReader sr = new StreamReader(archivo, true))
                {
                    texto = sr.ReadToEnd();
                }
                return true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        
        }
        public bool Guardar(string archivo, string texto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true))
                {
                
                sw.WriteLine(texto);
                }
                return true;
                    
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        
        }
    }
}
