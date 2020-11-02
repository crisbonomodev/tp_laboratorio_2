using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {

        public DniInvalidoException()
            : base("El DNI ingresado no es un número válido")
        {
        }
        public DniInvalidoException(string message)
            : this(message, null)
        {

        }
        public DniInvalidoException(Exception e)
            : base("El DNI ingresado no es un número válido", e)
        {

        }
        public DniInvalidoException(string message, Exception e)
            : base("El DNI ingresado no es un número válido:" + message, e)
        {

        }

    }
}
