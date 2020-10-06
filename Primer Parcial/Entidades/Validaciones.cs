using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Entidades
{
    public class Validaciones
    {
        /// <summary>
        /// Este metodo valida el ingreso de stock, para que sea un numero mayor a 0.
        /// </summary>
        /// <param name="itemAValidar"></param>
        /// <returns></returns>
        public static bool ValidarIngresoStock(string itemAValidar)
        {
            bool validado = false;
            int salida;
            if (int.TryParse(itemAValidar, out salida))
            {
                if (salida > 0)
                {
                    validado = true;
                    return validado;
                }
            }
            return validado;
        
        }

        public static bool ValidarPrecio(string precioAValidar)
        {
            bool validado = false;
            double salida;
            if (double.TryParse(precioAValidar,NumberStyles.Float, CultureInfo.InvariantCulture,out salida))
            {
                if (salida > 0)
                {
                    validado = true;
                    return validado;
                }
            }
            return validado;
        }
    }
}
