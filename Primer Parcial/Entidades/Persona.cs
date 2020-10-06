using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int DNI;
        protected string rutaFotoPerfil;

        public Persona(string nombre, string apellido, int DNI,string rutaFotoPerfil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
            this.rutaFotoPerfil = rutaFotoPerfil;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Dni
        {
            get
            {
                return DNI;
            }
        }

        public string RutaFotoPerfil
        {
            get
            {
                return rutaFotoPerfil;
            }
        }


    }
}
