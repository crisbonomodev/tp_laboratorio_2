using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Entidades
{
    public static class BaseDeDatos
    {

        #region Atributos
        private static string path = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TP4;Integrated Security=True;";

        public static string Path
        {
            get { return path; }
            set { path = value; }
        }


        #endregion
        #region Metodos

        /// <summary>
        /// Metodo que obtiene las cotizaciones de divisas de la BD
        /// </summary>
        /// <returns></returns>

        public static List<Divisa> ObtenerCotizaciones()
        {

            List<Divisa> cotizaciones = new List<Divisa>();
            SqlConnection conexion = new SqlConnection(Path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM[TP4].[dbo].[cotizaciones]";
            try
            {
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {//int idDivisa, NombreDivisa divisa ,double valorCompra,double  valorVenta
                    cotizaciones.Add(new Divisa((int)reader["idCotizacion"], SqlDataReaderExtension.ConvertirNombreDivisa(reader["nombreDivisa"].ToString()),(decimal) reader["valorCompra"], (decimal)reader["valorVenta"]));
                }
            
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.Close();
            }
            return cotizaciones;
        }

        public static Divisa ObtenerDivisaPorNombre(string nombreDivisa)
        {
            Divisa divisaARetornar = new Divisa();
            SqlConnection conexion = new SqlConnection(Path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = $"SELECT * FROM[TP4].[dbo].[cotizaciones] WHERE [nombreDivisa] = '{nombreDivisa}'";
            try
            {
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {//int idDivisa, NombreDivisa divisa ,double valorCompra,double  valorVenta
                    divisaARetornar.IdDivisa = (int)reader["idCotizacion"];
                    divisaARetornar.divisa = SqlDataReaderExtension.ConvertirNombreDivisa(reader["nombreDivisa"].ToString());
                    divisaARetornar.ValorCompra = (decimal)reader["valorCompra"];
                    divisaARetornar.ValorVenta = (decimal)reader["valorVenta"];
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.Close();
            }
            return divisaARetornar;
        }


        /// <summary>
        /// Metodo que devuelve las operaciones guardadas en BD
        /// </summary>
        /// <returns></returns>
        public static List<Operacion> ObtenerOperaciones()
        {

            List<Operacion> operaciones = new List<Operacion>();
            SqlConnection conexion = new SqlConnection(Path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM[TP4].[dbo].[registroOperaciones]";
            try
            {
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {//public Operacion(int idOperacion, DateTime fechaYhora, CasaDeCambio.TipoDeOperacion operacion, 
                    //Divisa divisa, decimal monto, decimal montoFinal)
                    operaciones.Add(new Operacion((int)reader["idOperacion"],DateTime.Parse(reader["fechaHora"].ToString()),SqlDataReaderExtension.ConvertirTipoOperacion(reader["tipoDeOperacion"].ToString()), BaseDeDatos.ObtenerDivisaPorNombre(reader["divisa"].ToString()), (decimal)reader["montoInicial"], (decimal)reader["montoFinal"]));
                                    
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.Close();
            }
            return operaciones;
        }

        /// <summary>
        /// Metodo para registrar nuevas operaciones.
        /// </summary>
        /// <param name="divisaARegistrar"></param>
        public static void RegistrarNuevaOperacion(Operacion operacionARegistrar)
        {
            string valorOperacionString = "";
            SqlConnection conexion = new SqlConnection(Path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            switch (operacionARegistrar.TipoOperacion)
            {
                case CasaDeCambio.TipoDeOperacion.Compra:
                    valorOperacionString = $"{operacionARegistrar.Divisa.ValorVenta} ,{operacionARegistrar.MontoFinal})";
                    break;
                case CasaDeCambio.TipoDeOperacion.Venta:
                    valorOperacionString = $"{operacionARegistrar.Divisa.ValorCompra} ,{operacionARegistrar.MontoFinal})";
                    break;
                default:
                    break;
            }
            comando.CommandText = "INSERT INTO [dbo].[RegistroOperaciones]([fechaHora],[tipoDeOperacion],[divisa],[montoInicial],[valorCotizacion],[montoFinal])" +
            $"VALUES('{operacionARegistrar.FechaYHora}','{operacionARegistrar.TipoOperacion.ToString()}','{operacionARegistrar.Divisa.divisa}',{operacionARegistrar.Monto} ," + valorOperacionString;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { 
            conexion.Close();
            }




        }

        /// <summary>
        /// Metodo que devuelve el ultimo ID de pedido entregado y cobrado
        /// </summary>
        /// <returns></returns>
        public static int ObtenerCantidadDeOperaciones()
        {
            int ultimaOperacion = 0;
            SqlConnection conexion = new SqlConnection(path);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM dbo.registroOperaciones";
            try
            {
                conexion.Open();
                ultimaOperacion = (int)comando.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            finally
            {
                conexion.Close();
            }
            return ultimaOperacion;
        }
        #endregion
    }
}
