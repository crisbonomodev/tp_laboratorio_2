using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Entidades
{
    public sealed class Empleado : Persona
    {
        int nroLegajo;
        string password;
        public Empleado(string nombre, string apellido, int DNI,string password,string rutaFotoPerfil, int nroLegajo) : base(nombre, apellido, DNI, rutaFotoPerfil)
        {
            this.nroLegajo = nroLegajo;
            this.password = password;
        }

        public string Password
            {
                get{return this.password;}
            }

        public int NroLegajo
        {
            get { return this.nroLegajo; }
        }
        
    }
}
