using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public static class Comercio
    {
        #region Atributos
        private static List<Producto> carrito;
        private static List<Producto> inventario;
        private static List<Empleado> nomina;
        private static List<Empleado> sesion;
        private static List<Compra> compras;
        private static List<Cliente> clientes;

        #endregion

        #region Constructor
        static Comercio()
        {
            carrito = new List<Producto>();
            inventario = new List<Producto>();
            nomina = new List<Empleado>();
            compras = new List<Compra>();
            clientes = new List<Cliente>();
            sesion = new List<Empleado>();
        }

        #endregion

        #region Propiedades
        public static List<Producto> Inventario
        {
            get { return inventario; }
        }

        public static List<Producto> Carrito
        {
            get { return carrito; }
            set { carrito = value; }
        }

        public static List<Empleado> Nomina
        {
            get { return nomina; }
        }

        public static List<Compra> Compras
        {
            get { return compras; }
        }
        public static List<Cliente> Clientes
        {
            get { return clientes; }
        }

        public static List<Empleado> Sesion
        {
            get
            {
                return sesion;
            }
        }


        #endregion

        #region Operaciones con Empleados
        /// <summary>
        /// Agrega un nuevo empleado a la nómina
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="DNI"></param>
        /// <param name="password"></param>
        /// <param name="rutaFotoPerfil"></param>
        /// <returns></returns>
        public static bool AgregarEmpleado(string nombre, string apellido, int DNI,string password, string rutaFotoPerfil)
        {
            bool empleadoGuardado = true;
            foreach (Empleado empleadoRegistrado in nomina)
            {
                if (empleadoRegistrado.Dni == DNI)
                {
                    empleadoGuardado = false;
                    return empleadoGuardado;
                }
            }
            int nroLegajo = nomina.Count;
            Empleado nuevoEmpleado = new Empleado(nombre, apellido, DNI,password, rutaFotoPerfil, nroLegajo);
            nomina.Add(nuevoEmpleado);
            return empleadoGuardado;
        }

        #endregion

        #region Operaciones con clientes
        /// <summary>
        /// Agrega un nuevo cliente a la lista de clientes
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="DNI"></param>
        /// <param name="rutaFotoPerfil"></param>
        /// <returns></returns>
        public static bool RegistrarNuevoCliente(string nombre, string apellido, int DNI,string rutaFotoPerfil)
        {
            bool clienteGuardado = true;
                foreach (Cliente clienteRegistrado in clientes)
                {
                    if (clienteRegistrado.Dni == DNI)
                    {
                        clienteGuardado = false;
                        return clienteGuardado;
                    }
                }
            int idCliente = clientes.Count;
            Cliente nuevoCliente = new Cliente(nombre, apellido, DNI, rutaFotoPerfil,idCliente);
            clientes.Add(nuevoCliente);
            return clienteGuardado;
                
        }
        /// <summary>
        /// Búsqueda de cliente por ID
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public static Cliente ObtenerClientePorId(int idCliente)
        {
            return clientes[idCliente];
        }

        /// <summary>
        /// Verificación del apellido para aplicar o no descuento
        /// </summary>
        /// <param name="clienteRegistrado"></param>
        /// <returns></returns>
        public static bool VerificarDescuentoPorApellido(Cliente clienteRegistrado)
        {
            bool esSimpson = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Apellido == clienteRegistrado.Apellido && clienteRegistrado.Apellido == "Simpson")
                {
                    esSimpson = true;
                    return esSimpson;
                }
            }
            return esSimpson;
        }


        #endregion

        #region Operaciones con productos
        /// <summary>
        /// Metodo para crear un nuevo producto de cero y agregarlo al inventario
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public static void CrearNuevoProducto(string descripcion,double precio, int cantidad)
        {
            int nroProducto = inventario.Count + 1;
            Producto nuevoProducto = new Producto(nroProducto, descripcion, precio, cantidad);
            inventario.Add(nuevoProducto);
        }


        /// <summary>
        /// Búsqueda de producto por ID
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static Producto ObtenerProductoPorId(int idProducto)
        {
            Producto productoADevolver = new Producto();
            foreach (Producto producto in inventario)
            {
                if (producto.NroProducto == idProducto)
                {
                    productoADevolver.NroProducto = producto.NroProducto;
                    productoADevolver.Precio = producto.Precio;
                    productoADevolver.Cantidad = producto.Cantidad;
                    productoADevolver.Descripcion = producto.Descripcion;
                    return productoADevolver;
                }

            }
            return productoADevolver;
        
        }

        #endregion

        #region Operaciones con inventario
        /// <summary>
        /// Agrega un nuevo producto al inventario cuando se quita un producto del carrito
        /// </summary>
        /// <param name="nuevoProducto"></param>
        public static void AgregarProductoAInventario(int nroProducto, int cantidad)
        {
            foreach (Producto item in inventario)
            {
                if (item.NroProducto == nroProducto)
                {
                    item.Cantidad = item.Cantidad + cantidad;
                }

            }
        }
        /// <summary>
        /// Quita un producto del inventario cuando se agrega un producto al carrito
        /// </summary>
        /// <param name="nroProducto"></param>
        public static void RestarProductosDeInventario(int nroProducto)
        {
            foreach (Producto item in inventario)
            {
                if (item.NroProducto == nroProducto)
                {
                    item.Cantidad = item.Cantidad - 1;
                }

            }
        }

        #endregion

        #region Operaciones de compra
        /// <summary>
        /// Registrar nueva compra
        /// </summary>
        /// <param name="nuevaCompra"></param>
        public static void RegistrarNuevaCompra(int idVendedor,int idCliente,List<Producto> carrito)
        {
            double acumSubtotal = 0;
            double descuento = 0;
            double total = 0;
            List<Producto> listaAGuardar = (carrito as IEnumerable<Producto>).ToList();
            int nroCompra = Comercio.Compras.Count;

            foreach (Producto producto in listaAGuardar)
            {
                acumSubtotal += producto.Subtotal;
            }

            Cliente clienteRegistrado = ObtenerClientePorId(idCliente);

            if (VerificarDescuentoPorApellido(clienteRegistrado))
            {
                descuento = acumSubtotal * 0.13;
            }

            total = acumSubtotal - descuento;
            Compra nuevaCompra = new Compra(nroCompra, idVendedor, idCliente, listaAGuardar, acumSubtotal,descuento,total);
            compras.Add(nuevaCompra);

            foreach (Producto itemInventario in inventario)
            {
                foreach (Producto itemCarrito in listaAGuardar)
                {
                    if (itemCarrito.NroProducto == itemInventario.NroProducto)
                    {
                        itemInventario.Cantidad = itemInventario.Cantidad - itemCarrito.Cantidad;
                    }
                }

            }
        }
        /// <summary>
        /// Busca una compra por ID y retorna el listado de productos asociados
        /// </summary>
        /// <param name="nrocompra"></param>
        /// <returns></returns>
        public static List<Producto> BuscarDetalleDeCompra(int nrocompra)
        {
            List<Producto> listaCompras = new List<Producto>();
            foreach (Compra compra in Compras)
            {
                if (compra.NroCompra == nrocompra)
                {
                    listaCompras =  compra.ListaCompra;
                    return listaCompras;
                }

            }
            return listaCompras;
        }

        #endregion

        #region Operaciones del Carrito
        /// <summary>
        /// Agrega un producto del inventario al carrito
        /// </summary>
        /// <param name="nuevoProducto"></param>
        public static void AgregarProductoACarrito(Producto nuevoProducto)
        {
            bool productoDuplicado = false;
            if (carrito.Count != 0)
            {
                foreach (Producto producto in Carrito)
                {
                    if (producto.NroProducto == nuevoProducto.NroProducto)
                    {
                        productoDuplicado = true;
                        producto.Cantidad = producto.Cantidad + 1;
                        producto.Subtotal = producto.Subtotal + nuevoProducto.Subtotal;
                    }
                }
                if (!productoDuplicado)
                {
                    carrito.Add(nuevoProducto);
                }
            }
            else
            {
                carrito.Add(nuevoProducto);
            }
              
        }
        /// <summary>
        /// Quita un producto del carrito
        /// </summary>
        /// <param name="nuevoProducto"></param>
        public static void QuitarProductoACarrito(Producto nuevoProducto)
        {

            if (carrito.Count != 0)
            {
                foreach (Producto producto in Carrito.ToList())
                {
                    if (producto.NroProducto == nuevoProducto.NroProducto)
                    {

                        if (producto.Cantidad > 1)
                        {
                            producto.Cantidad = producto.Cantidad - 1;
                            producto.Subtotal = producto.Subtotal - nuevoProducto.Precio;
                        }
                        else
                        {
                            carrito.Remove(producto);
                        }
                        
                    }
                }
            }

        }
        /// <summary>
        /// Calculo del subtotal
        /// </summary>
        /// <returns></returns>
        public static double CalcularSubtotal()
        {
            double acumSubtotal = 0;
            foreach (Producto item in carrito)
            {
                acumSubtotal += item.Subtotal;
            }
            return acumSubtotal;
        }

        #endregion

        #region Operaciones de login


        /// <summary>
        /// Login al sistema
        /// </summary>
        /// <param name="nomina"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// 
        public static bool Login(string legajo,string password)
        {
            bool isLoggedIn = false;
            int legajoEmpleado;
            int.TryParse(legajo, out legajoEmpleado);

            foreach (Empleado e in nomina)
            {
                if (e.NroLegajo == legajoEmpleado)
                {
                    if (e.Password == password)
                    {
                        sesion.Add(e);
                        isLoggedIn = true;
                        return isLoggedIn;
                    }
                }
            }
            return isLoggedIn;
        }
        /// <summary>
        /// Verificación de la sesión
        /// </summary>
        /// <returns></returns>
        public static string[] ChequearLogin()
        {
            string[] empleadoLogueado = new string[4];
            foreach (Empleado empleado in sesion)
            {
                empleadoLogueado[0] = empleado.NroLegajo.ToString();
                empleadoLogueado[1] = empleado.Apellido;
                empleadoLogueado[2] = empleado.Nombre;
                empleadoLogueado[3] = empleado.RutaFotoPerfil;
            }
            return empleadoLogueado;
        
        }
        #endregion
    }
}
