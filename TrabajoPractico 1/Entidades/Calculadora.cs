using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        //Métodos
        /// <summary>
        /// El método Operar será de clase: validará y realizará la operación pedida entre
        /// ambos números.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            //Realizamos la validación del operador mediante ValidarOperador
            char opc = Convert.ToChar(operador.Substring(0));
            switch (ValidarOperador(opc))
            {
                case "+":
                    resultado =  num1 + num2;
                    break;
                case "-":
                    resultado =  num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// El método ValidarOperador será privado y estático. Deberá validar que el operador
        /// recibido sea +, -, / o*. Caso contrario retornará +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {

            if ((operador != '+') && (operador != '-') && (operador != '*') && (operador != '/'))
            {
                operador = '+';
            }

            return operador.ToString();
        }
    }
}
