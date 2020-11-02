using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.Xml.Serialization;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Tipos Anidados
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #endregion
        #region Atributos

        private List<Alumno> alumnos;
        private List<Profesor> profesores;
        private List<Jornada> jornada;

        #endregion
        #region Propiedades

        public List<Alumno> Alumnos
        {
            get 
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set 
            {
                this.jornada = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Jornadas.Count && this.Jornadas.Count > 0)
                {
                    return this.Jornadas[i];
                }
                else
                {
                    return null;
                }
            }
            set {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
                else
                {
                    this.Jornadas[i] = null;
                }
            }
        }
        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        #endregion
        #region Métodos
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universidad()
        {
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }

        /// <summary>
        /// Los datos del Universidad se harán públicos mediante ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        /// <summary>
        /// Guardar de clase serializará los datos del Universidad en un XML, incluyendo todos los datos de sus Profesores, Alumnos y Jornadas
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;
            Xml<Universidad> auxUniversidad = new Xml<Universidad>();
            try
            {
                auxUniversidad.Guardar("Universidad.xml", uni);
                retorno = true;
            }
            catch (ArchivosException e)
            {

                throw new ArchivosException(e);
            }
            return retorno;
        }

        /// <summary>
        /// Leer de clase retornará un Universidad con todos los datos previamente serializados.
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad dataUniversidad = new Universidad();

            Xml<Universidad> aux = new Xml<Universidad>();

            try
            {
                aux.Leer("Universidad.xml", out dataUniversidad);
            }
            catch (ArchivosException e)
            {

                throw new ArchivosException(e);
            }
            return dataUniversidad;
        }

        /// <summary>
        /// MostrarDatos será privado y de clase.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("<------------------------------------>");
            }
            return sb.ToString();
        }


        #region Operadores

        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno alumno in g.alumnos)
            {
                if (alumno.Equals(a))
                {
                    retorno = true;
                    return retorno;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Un Universidad no será igual a un Alumno si el mismo no está inscripto en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            foreach (Profesor p in g.profesores)
            {
                if (p == i)
                {
                    retorno = true;
                    return retorno;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Un Universidad no será igual a un Profesor si el mismo no está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase. 
        /// Sino, lanzará la Excepción SinProfesorException. 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
                foreach (Profesor profesor in u.profesores)
                {
                    if (profesor == clase)
                    {
                        return profesor;
                    }
                }
                throw new SinProfesorException();
        }

        /// <summary>
        /// El distinto retornará el primer Profesor que no pueda dar la clase.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor auxProfesor = new Profesor();
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor != clase)
                {
                    auxProfesor = profesor;
                    return auxProfesor;
                }
            }
            return auxProfesor;
        }

        /// <summary>
        /// Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la clase, 
        /// un Profesor que pueda darla (según su atributo ClasesDelDia) 
        /// y la lista de alumnos que la toman (todos los que coincidan en su campo ClaseQueToma).
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            try
            {
                Jornada jornada = new Jornada(clase,g == clase);
                Universidad auxUniversidad = new Universidad();
                foreach (Alumno alumno in g.Alumnos)
                {
                    if (alumno == clase)
                    {
                        jornada += alumno;
                    }
                }
                g.Jornadas.Add(jornada);
                return g;
            }
            catch (SinProfesorException)
            {
                throw new SinProfesorException();
            }
        }
        /// <summary>
        /// Sobrecarga que permite agregar un alumno a una universidad, previa validación
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            try
            {
                if (g == a)
                {
                  throw new AlumnoRepetidoException();
                }
                g.Alumnos.Add(a);
                return g;
            }
            catch (AlumnoRepetidoException)
            {

                throw new AlumnoRepetidoException();
            }
            
        }

        /// <summary>
        /// Sobrecarga que permite agregar un profesor a una universidad, previa validación
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.Profesores)
            {
                if (profesor == i)
                {
                    return g;
                }
            }
            g.Profesores.Add(i);
            return g;
        }


        #endregion

        #endregion

    }
}
