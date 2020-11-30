using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
    public static class CasaDeCambio
    {
        #region atributos

        private static List<Divisa> cotizaciones;
        private static List<Operacion> operaciones;
        private static Queue<Operacion> operacionesEnLinea;

        public enum TipoDeOperacion
        {
        Compra,
        Venta
        }

        #endregion
        #region propiedades
        
        public static List<Divisa> Cotizaciones
        {
            get { return cotizaciones; }
            set { cotizaciones = value; }
        }
        public static List<Operacion> Operaciones
        {
            get { return operaciones; }
            set { operaciones = value; }
        }

        public static Queue<Operacion> OperacionesEnLinea
        {
            get { return operacionesEnLinea; }
            set { operacionesEnLinea = value; }
        }
        #endregion
        #region constructores
        static CasaDeCambio()
        {
            cotizaciones = new List<Divisa>();
            operaciones = new List<Operacion>();
            operacionesEnLinea =  new Queue<Operacion>();
        }
        #endregion
        #region metodos

        /// <summary>
        /// Metodo que devuelve una cotizacion sin registrarla en las operaciones.
        /// </summary>
        /// <param name="divisa1"></param>
        /// <param name="divisa2"></param>
        /// <param name="operacion"></param>
        /// <returns></returns>
        public static Operacion Cotizar(decimal monto,Divisa divisaAOperar,TipoDeOperacion operacion)
        {
            //generamos una nueva operacion
            Operacion cotizacion = new Operacion();
            decimal montoResultante;
            //Switch para seleccionar la operacion a cotizar
            switch (operacion)
            {
                case TipoDeOperacion.Compra:
                    foreach (Divisa divisa in cotizaciones)
                    {//Buscamos la cotizacion en el listado de cotizaciones
                        if (divisaAOperar.IdDivisa == divisa.IdDivisa)
                        {//Si encontramos la divisa, realizamos la operacion
                            //Calculamos el monto a comprar segun la cotizacion de la divisa
                            montoResultante = monto / divisa.ValorCompra;
                        }
                    }
                    break;
                case TipoDeOperacion.Venta:

                    break;
                default:
                    break;
            }

            return cotizacion;
        }


        #endregion
    }
}
