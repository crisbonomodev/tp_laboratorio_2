using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EnvioRetLocal : Envio
    {
        tipoEnvio envio;
        public EnvioRetLocal(int nroEnvio, int nroCompra, string nombreResponsable) : base(nroEnvio, nroCompra, nombreResponsable)
        {
            envio = tipoEnvio.RetiraEnLocal;
        }

        public override string ObtenerEnvio()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ObtenerEnvio());
            return sb.ToString();
        }

        public tipoEnvio Envio
        {
            get
            {
                return envio;
            }
        }
    }
}
