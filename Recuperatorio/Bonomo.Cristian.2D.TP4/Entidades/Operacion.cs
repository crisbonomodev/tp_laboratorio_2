using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    [Serializable]
    public class Operacion
    {
        #region Atributos

        private int idOperacion;
        private DateTime fechaYHora;
        private CasaDeCambio.TipoDeOperacion tipoOperacion;
        private Divisa divisa;
        private decimal monto;
        private decimal montoFinal;
        #endregion
        #region Propiedades

        public int IdOperacion
        {
            get { return idOperacion; }
            set { idOperacion = value; }
        }
        public DateTime FechaYHora
        {
            get { return fechaYHora; }
            set { fechaYHora = value; }
        }
        public CasaDeCambio.TipoDeOperacion TipoOperacion
        {
            get
            {
                return tipoOperacion;
            }
            set
            {
                tipoOperacion = value; 
            }
        }
        public Divisa Divisa { get => divisa; set => divisa = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public decimal MontoFinal { get => montoFinal; set => montoFinal = value; }

        #endregion
        #region Métodos
       
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Operacion()
        {
            this.fechaYHora = DateTime.Now;
            this.idOperacion = BaseDeDatos.ObtenerCantidadDeOperaciones() +1 ;
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="operacion"></param>
        /// <param name="divisa"></param>
        /// <param name="monto"></param>
        /// <param name="montoFinal"></param>
        public Operacion(CasaDeCambio.TipoDeOperacion operacion, Divisa divisa, decimal monto, decimal montoFinal)
            : this()
        {
            this.tipoOperacion = operacion;
            this.divisa = divisa;
            this.monto = monto;
            this.montoFinal = montoFinal;

        }

        /// <summary>
        /// Constructor con todos los parametros, para el retorno de datos desde BD
        /// </summary>
        /// <param name="operacion"></param>
        /// <param name="divisa"></param>
        /// <param name="monto"></param>
        /// <param name="montoFinal"></param>
        public Operacion(int idOperacion, DateTime fechaYhora, CasaDeCambio.TipoDeOperacion operacion, Divisa divisa, decimal monto, decimal montoFinal)
        {
            this.fechaYHora = fechaYhora;
            this.idOperacion = idOperacion;
            this.tipoOperacion = operacion;
            this.divisa = divisa;
            this.monto = monto;
            this.montoFinal = montoFinal;

        }

        /// <summary>
        /// Metodo que se encarga de procesar el resultado de la operacion solicitada a cotizar
        /// </summary>
        public void Cotizar()
        {
            switch (this.TipoOperacion)
            {
                //Si quiere comprar, se le toma el valor de venta de la casa
                case CasaDeCambio.TipoDeOperacion.Compra:
                    this.MontoFinal = this.Monto / this.Divisa.ValorVenta;

                    break;
                //Si quiere vender, se le toma el valor de compra de la casa
                case CasaDeCambio.TipoDeOperacion.Venta:
                    this.MontoFinal = this.Monto * this.Divisa.ValorCompra;
                    break;
                default:
                    break;
            }
        }
        #endregion

        /// <summary>
        /// Metodo que genera una operacion random, para simular una operacion realizada en linea
        /// </summary>
        /// <returns></returns>
        public static Operacion GenerarOperacionRandom()
        {

            Operacion miOperacionRandom;

            Random random = new Random();
            int tipoOPeracion = random.Next(1, 2);
            int idDivisa = random.Next(1, 3);
            string nombreDivisa = "";
            decimal monto = random.Next(1, 1000);
            decimal montoFinal = 0;
            CasaDeCambio.TipoDeOperacion operacion = CasaDeCambio.TipoDeOperacion.Compra;
            Divisa divisa = new Divisa();

            switch (tipoOPeracion)
            {
                case 1:
                    operacion = CasaDeCambio.TipoDeOperacion.Compra;
                    break;
                case 2:
                    operacion = CasaDeCambio.TipoDeOperacion.Venta;
                    break;
            }

            switch (idDivisa)
            {
                case 1:
                    nombreDivisa = "Dolar";
                    break;
                case 2:
                    nombreDivisa = "Euro";
                    break;
                case 3:
                    nombreDivisa = "Real";
                    break;
            }

            divisa = BaseDeDatos.ObtenerDivisaPorNombre(nombreDivisa);

            switch (operacion)
            {
                case CasaDeCambio.TipoDeOperacion.Compra:
                    montoFinal = monto / divisa.ValorVenta;
                    break;
                case CasaDeCambio.TipoDeOperacion.Venta:
                    montoFinal = monto * divisa.ValorCompra;
                    break;
                default:
                    break;
            }


            miOperacionRandom = new Operacion(operacion, divisa, monto, montoFinal);

            return miOperacionRandom;
        
        }

    }
}
