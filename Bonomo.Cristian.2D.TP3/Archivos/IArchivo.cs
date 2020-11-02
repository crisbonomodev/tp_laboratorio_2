using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IArchivo<T>
    {
        bool Leer(string archivo, out T data);
        bool Guardar(string archivo, T data);
    }
}
