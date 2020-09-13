using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        ///El atributo número es privado
        private double numero;
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor: El constructor por defecto (sin parámetros) asignará valor 0 al atributo número.
        /// </summary>
        public Numero()
        {
            numero = 0;
        }
        /// <summary>
        /// Constructor que recibe y asigna un double al atributo número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor que recibe y parsea un string para asignarlo al atributo número
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            double.TryParse(strNumero, out numero);
            
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Propiedad que asigna un numero al atributo privado numero. Aqui se llama al método ValidarNumero
        /// </summary>
        public string SetNumero
        {
            set { this.numero = ValidarNumero(value);}
        }
        #endregion
        #region Validaciones
        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en
        /// formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        double ValidarNumero(string strNumero)
        {
            //Declaramos variable temporal
            double numeroValidado = 0;
            //Validamos si por error se usó coma, y reemplazamos por punto
            if (strNumero.Contains(","))
            {
                strNumero = strNumero.Replace(",", ".");
            }
            //Intentamos realizar la conversion
            double.TryParse(strNumero, out numeroValidado);
            //Retornamos el valor. Si la conversion fue exitosa, retorna el numero, sino retorna 0.
            return numeroValidado;
        }
        public static bool  EsBinario(string binario)
        {
            //Inicializamos variables y pasamos nuestro string a un array de chars
            bool EsBinario = false;
            char[] binarioArray;
            binarioArray = binario.ToCharArray();
            //Validamos para cada item dentro del array, si difiere de 0/1, devolvemos false
            foreach (char item in binarioArray)
            {
                if (item != '0' && item != '1')
                {
                    return EsBinario;
                }
            }
            //Sino, devolvemos true
            EsBinario = true;
            return EsBinario;
            
        }
        #endregion
        #region Sobrecarga de operadores
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;

        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;

        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;

        }
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;

        }
        #endregion
        #region Conversiones Binario Decimal

        /// <summary>
        /// Método que realiza la conversion de un número binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            string resultado = null;
            //Si no hay nada en el lblResultado o si no es binario
            if (binario == null || !EsBinario(binario)) 
            {
                resultado = "Valor inválido";
            }
            else
            {
                resultado = Convert.ToInt32(binario, 2).ToString();
            }
            return resultado;
        }
        
        /// <summary>
        /// Metodo que recibe un double y realiza la conversion a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            string resultado = null;
            numero = Math.Abs(numero); //Tomamos el valor absoluto
            int numeroConvertido = Convert.ToInt32(numero); //Convertimos a int y redondeamos
            resultado = Convert.ToString(numeroConvertido, 2); //Pasamos a binario
            return resultado;
        }
        /// <summary>
        /// Metodo que recibe un string y realiza la conversion a double, para luego realizar el pasaje a binario.
        /// Si no logra realizar la conversion, retorna "Valor inválido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            double numeroADouble;
            //Si podemos realizar la conversion llamamos al metodo para resolver
            if (double.TryParse(numero, out numeroADouble)) 
            {
                return DecimalBinario(numeroADouble);
            }
            else //Sino, retornamos valor invalido.
            {
                return "Valor inválido";
            }            
        }
        #endregion
    }
}
