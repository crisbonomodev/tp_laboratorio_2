using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Divisa
    {
        #region Enumerados
        public enum NombreDivisa
        {
            Peso,
            Dolar,
            Euro,
            Real
        };

        #endregion
        #region atributos
        int idDivisa;
        public NombreDivisa divisa;
        decimal valorCompra;
        decimal valorVenta;
        #endregion
        #region propiedades
       

        public int IdDivisa
            {
            get
            {
                return idDivisa;
            }
            set
            {
                idDivisa = value;
            }
            }
        public decimal ValorCompra 
        { 
            get 
            {
                return valorCompra;
            }
            set
            {
                this.valorCompra = value;
            }
        }
        public decimal ValorVenta
        {
            get
            {
                return valorVenta;
            }
            set
            {
                this.valorVenta = value;
            }
        }
        #endregion
        #region Métodos

        public Divisa()
        {

        }
        public Divisa(int idDivisa, NombreDivisa divisa , decimal valorCompra, decimal valorVenta)
        {
            this.idDivisa = idDivisa;
            this.divisa = divisa; 
            this.valorCompra = valorCompra;
            this.valorVenta = valorVenta;
        }
        #endregion
    }
}
