using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;

        #endregion
        #region Métodos
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario()
        {

        }
        /// <summary>
        /// Constructor con asignacion del atributo legajo
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base (nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Universitario)
            {
                if (this == (Universitario)obj)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Método protegido y abstracto ParticiparEnClase
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();


        /// <summary>
        /// Metodo que retorna un string formatedo con la info del legajo
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO: {this.legajo}");
            return sb.ToString();
        }

        /// <summary>
        /// Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
            {
            return pg2.GetType() == pg1.GetType() && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo);
            }

        /// <summary>
        /// Dos Universitario serán distintos si y sólo si son de distinto Tipo y su Legajo o DNI son distintos.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
