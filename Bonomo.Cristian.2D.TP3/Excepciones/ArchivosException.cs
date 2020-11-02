using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException)
            : this("No se pudo efectuar la accion en el archivo, ", innerException)
        {
        }
        public ArchivosException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
