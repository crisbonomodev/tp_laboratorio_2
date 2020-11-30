using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class SqlDataReaderExtension
    {
        /// <summary>
        /// Metodo que castea el string guardado en BD y lo devuelve como un enumerado de tipo NombreDivisa
        /// </summary>
        /// <param name="nombreDivisa"></param>
        /// <returns></returns>
        public static Divisa.NombreDivisa ConvertirNombreDivisa(this string nombreDivisa)
        {
            Divisa.NombreDivisa divisaARetornar = Divisa.NombreDivisa.Peso;
            switch (nombreDivisa)
            {
                case "Peso":
                    break;
                case "Dolar":
                    divisaARetornar = Divisa.NombreDivisa.Dolar;
                    break;
                case "Euro":
                    divisaARetornar = Divisa.NombreDivisa.Euro;
                    break;
                case "Real":
                    divisaARetornar = Divisa.NombreDivisa.Real;
                    break;
            }
            return divisaARetornar;
        }

        /// <summary>
        /// Metodo para castear el string con el nombre de la operacion al enumerado
        /// </summary>
        /// <param name="nombreOperacion"></param>
        /// <returns></returns>
        public static CasaDeCambio.TipoDeOperacion ConvertirTipoOperacion(this string nombreOperacion)
        {
            CasaDeCambio.TipoDeOperacion operacionARetornar = CasaDeCambio.TipoDeOperacion.Compra;
            switch (nombreOperacion)
            {
                case "Compra":
                    break;
                case "Venta":
                    operacionARetornar = CasaDeCambio.TipoDeOperacion.Venta;
                    break;
            }
            return operacionARetornar;
        }
    }
}
