using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Envio
    {
        public enum tipoEnvio
        {
            Domicilio,
            RetiraEnLocal
        };

        int nroEnvio;
        int nroCompra;
        string nombreResponsable;
        

        public Envio(int nroEnvio,int nroCompra, string nombreResponsable)
        {
            this.nroEnvio = nroEnvio;
            this.nroCompra = nroCompra;
            this.nombreResponsable = nombreResponsable;
        }

        public virtual string ObtenerEnvio()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Envio N: {nroEnvio}\n");
            sb.Append($"Compra N: {nroCompra}\n");
            sb.Append($"Responsable: {nombreResponsable}\n");

            return sb.ToString();
        }

        public int NroEnvio
        {
            get
            {
                return nroEnvio;
            }

        }

        public int NroCompra
        {
            get
            {
                return nroCompra;
            }

        }
    }
}
