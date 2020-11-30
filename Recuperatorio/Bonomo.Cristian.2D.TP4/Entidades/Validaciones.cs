using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool ValidarIngresoNumeros(string stringAValidar)
        {
            bool stringValidado = true;
            char[] stringChar = stringAValidar.ToCharArray();

            foreach (char item in stringChar)
            {
                if (!Char.IsNumber(item) && item != '.')
                {
                    stringValidado = false;
                }
            }
            
            return stringValidado;
        }
    }
}
