﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException()
            :base("Alumno repetido.")
        {
        
        }

        public AlumnoRepetidoException(string message)
            : base(message)
        {

        }
    }
}
