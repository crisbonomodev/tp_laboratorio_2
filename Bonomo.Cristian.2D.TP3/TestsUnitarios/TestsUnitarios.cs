using System;
using Clases_Abstractas;
using Clases_Instanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitarios
{
    [TestClass]
    public class TestsUnitarios
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void DNI_InvalidoExtranjero()
        {
            string dniExtranjero = "40123456";
            Alumno alumnoNuevo = new Alumno(5, "Maximo", "Cozzetti", dniExtranjero,
            Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AgregarAlumnoDuplicado()
        {
          

            Alumno alumno1 = new Alumno(5, "Maximo", "Cozzetti", "40123456",
            Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);

            Universidad auxUniversidad = new Universidad();

            auxUniversidad += alumno1;

            Alumno alumno2 = new Alumno(6, "Fernando", "Laguzzi", "40123456",
            Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);

            auxUniversidad += alumno2;
        }

        [TestMethod]
        public void UniversidadInstanciarListaAlumnos()
        {

            Alumno alumno1 = new Alumno(5, "Maximo", "Cozzetti", "40123456",
            Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);

            Universidad auxUniversidad = new Universidad();

            auxUniversidad += alumno1;

            Assert.IsNotNull(auxUniversidad.Alumnos);

        }
    }
}
