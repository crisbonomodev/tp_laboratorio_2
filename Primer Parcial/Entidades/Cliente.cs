using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Cliente : Persona
    {
        int idCliente;

        public Cliente(string nombre, string apellido, int DNI, string rutaFotoPerfil) : base(nombre, apellido, DNI,rutaFotoPerfil)
        {
            
        }

        public Cliente(string nombre, string apellido, int DNI, string rutaFotoPerfil, int idCliente) : this(nombre, apellido, DNI, rutaFotoPerfil)
        {
            this.idCliente = idCliente;
        }

        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
        }
    }
}
