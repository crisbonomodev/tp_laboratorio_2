using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EnvioADomicilio : Envio
    {
        tipoEnvio envio;
        string calle;
        int altura;
        double costo;
        public EnvioADomicilio(int nroEnvio,int nroCompra,string nombreResponsable, string calle, int altura, double costo) : base(nroEnvio, nroCompra, nombreResponsable)
        {
            this.calle = calle;
            this.altura = altura;
            this.costo = costo;
            this.envio = tipoEnvio.Domicilio;
        }

        public override string ObtenerEnvio()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ObtenerEnvio());
            sb.Append($"Calle: {calle}\n");
            sb.Append($"Altura: {altura}\n");
            sb.Append($"Costo: {costo}\n");
            return sb.ToString();
        }

        public string Calle
        {
            get 
            {
                return calle;
            }
        }
        public int Altura
        {
            get
            {
                return altura;
            }
        }

        public double Costo
        {
            get
            {
                return costo;
            }
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
