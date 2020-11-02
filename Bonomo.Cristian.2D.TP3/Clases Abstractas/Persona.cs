using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;


namespace Clases_Abstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        };
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
        Regex regexNombreYApellido = new Regex("^[A-Z][a-zA-Z]*$");

        #region Propiedades

        public string Apellido
        {
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
            get
            {
                return this.apellido;
            }
            
        }

        public string Nombre
        {
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
            get
            {
                return this.nombre;
            }
        }

        public ENacionalidad Nacionalidad
        {
            set
            {
                this.nacionalidad = value;
            }
            get
            {
                return this.nacionalidad;
            }
        }

        public int DNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
            get
            {
                return this.dni;
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = Persona.ValidarDni(this.Nacionalidad, value);
            }
        }
        #endregion
        #region Métodos
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {
            
        }
        /// <summary>
        /// Constructor con apellido, nombre y nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            
        }
        /// <summary>
        /// Constructor con atributo DNI por int
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor con atributo DNI por string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        /// <summary>
        /// Metodo para mostrar datos de la persona: apellido, nombre y nacionalidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO:{this.Apellido},{this.Nombre}");
            sb.AppendLine($"NACIONALIDAD:{this.Nacionalidad}");

            return sb.ToString();
        }
        /// <summary>
        /// Validacion del DNI con paso de int por parametro
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private static int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && (dato < 1 || dato > 89999999)
            || nacionalidad == ENacionalidad.Extranjero && (dato < 90000000 || dato > 99999999))
            {
                throw new NacionalidadInvalidaException(dato.ToString());
            }
            return dato;
        }

        /// <summary>
        /// Validacion del DNI con paso de string por parametro
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private static int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
                int dniValidado = 0;
                try
                {
                    int numeroDni = Int32.Parse(dato);
                    dniValidado = ValidarDni(nacionalidad, numeroDni);
                }
                catch (Exception e)
                {
                    throw new NacionalidadInvalidaException();
                }
            return dniValidado;
        }

        /// <summary>
        /// Validacion de formato de nombre y apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (regexNombreYApellido.IsMatch(dato))
            {
                return dato;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
