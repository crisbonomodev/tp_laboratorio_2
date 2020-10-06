using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Compra
    {
        int nroCompra;
        DateTime fechaYHora;
        int idVendedor;
        int idCliente;
        List<Producto> listaCompra;
        double subtotal;
        double descuento;
        double total;

        public Compra(int nroCompra, int idVendedor,int idCliente, List<Producto> listaCompra,double subtotal, double descuento, double total)
        {
            fechaYHora = DateTime.Now;
            this.nroCompra = nroCompra;
            this.idVendedor = idVendedor;
            this.idCliente = idCliente;
            this.listaCompra = listaCompra;
            this.subtotal = subtotal;
            this.descuento = descuento;
            this.total = total;
        }
        
        public int NroCompra
        {
            get { return nroCompra; }
        }

        public int IdVendedor
        {
            get { return idVendedor; }
        }

        public int IdCliente
        {
            get { return idCliente; }
        }

        public List<Producto> ListaCompra
        {
            get { return listaCompra; }
        }

        public DateTime FechaYHora
        {
            get
            {
                return fechaYHora;
            }
        }

        public double Subtotal
        {
            get
            {
                return subtotal;
            }
        }

        public double Descuento
        {
            get
            {
                return descuento;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }
        }

    }
}
