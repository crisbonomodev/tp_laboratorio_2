using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        int nroProducto;
        string descripcion;
        double precio;
        int cantidad;
        double subtotal;
        public Producto()
        {

        }
        public Producto(int nroProducto, string descripcion, double precio, int cantidad)
        {
            this.nroProducto = nroProducto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public Producto(int nroProducto, string descripcion, double precio, int cantidad, double subtotal)
            :this(nroProducto,descripcion,precio,cantidad)
        {
            this.subtotal = Math.Round(precio * cantidad,2);
        }

        public int NroProducto 
        {
            get
            {
                return this.nroProducto;
            }
            set 
            { 
                this.nroProducto = value; 
            }
        }
        public string Descripcion
        { 
            get 
            { 
                return this.descripcion; 
            }
            set 
            {
                this.descripcion = value; 
            }
        }
        public double Precio
        {
            get 
            {
                return this.precio; 
            }
            set 
            {
                this.precio = value; 
            }
        }
        public int Cantidad
        {
            get 
            {
                return this.cantidad;
            }
            set 
            { 
                this.cantidad = value; 
            }
        }
        public double Subtotal
        {
            get 
            { 
                return this.subtotal; 
            }
            set 
            { 
                this.subtotal = value; 
            }
        }

       
    }

    
}
