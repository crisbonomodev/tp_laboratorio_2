using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitariosDB
    {
        [TestMethod]
        public void ObtenerCotizaciones()
        {
            //Arrange

            //Act
            BaseDeDatos.ObtenerCotizaciones();
            //Assert
            Assert.IsNotNull(CasaDeCambio.Cotizaciones);
        }

        [TestMethod]
        public void ObtenerUltimaOperacionRegistrada()
        {
            //Arrange
            int ultimaOperacion;
            //Act
            ultimaOperacion = BaseDeDatos.ObtenerCantidadDeOperaciones();
            //Assert
            Assert.IsNotNull(ultimaOperacion);
        }

        [TestMethod]
        public void RegistrarNuevaOperacion()
        {
            int ultimaOperacion = BaseDeDatos.ObtenerCantidadDeOperaciones();
            Divisa divisaPrueba = new Divisa();
            CasaDeCambio.TipoDeOperacion operacionPrueba = CasaDeCambio.TipoDeOperacion.Compra;
            //Arrange
            Operacion miOperacionDePrueba = new Operacion(operacionPrueba, divisaPrueba,1000,100);
            //Act
            BaseDeDatos.RegistrarNuevaOperacion(miOperacionDePrueba);
            //Assert
            Assert.IsTrue(BaseDeDatos.ObtenerCantidadDeOperaciones() == ultimaOperacion + 1);
        }


    }
}
