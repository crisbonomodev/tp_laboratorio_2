using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {/// <summary>
    /// Constructor vacío, que llama al constructor de la clase base
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="chasis"></param>
    /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) 
            : base(chasis, marca, color)
        {
            
        }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        /// <summary>
        /// Genera un string con los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public override string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
