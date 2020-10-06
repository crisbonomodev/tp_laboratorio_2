using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KwikEMart
{
    public partial class FormPrincipal : Form
    {
        double acumuladorSubtotal = 0.00;
        List<Producto> inventarioCopia;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga de los datagrid en el form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormInventario formInventario = new FormInventario();
                formInventario.ShowDialog();
                CargarInventario();
                ActualizarInventario();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione los productos a agregar");
            }
            else
            {
                for (int i = 0 ; i < dgvStock.SelectedRows.Count; i++)
                {

                    int nroProducto = (int)dgvStock.SelectedRows[i].Cells[0].Value;
                    string descripcion = dgvStock.SelectedRows[i].Cells[1].Value.ToString();
                    double precio = (double)dgvStock.SelectedRows[i].Cells[2].Value;
                    int cantidadStock = (int)dgvStock.SelectedRows[i].Cells[3].Value;

                    if (cantidadStock == 0)
                    {
                        MessageBox.Show("Producto sin stock disponible.");
                    }
                    else
                    { 

                        double subtotal = precio * 1;
                        Producto productoAgregadoAlCarrito = new Producto(nroProducto, descripcion, precio, 1,subtotal);
                        Comercio.AgregarProductoACarrito(productoAgregadoAlCarrito);
                        Comercio.RestarProductosDeInventario(nroProducto);
                        acumuladorSubtotal = (acumuladorSubtotal + subtotal);
                        ActualizarInventario();
                    }

                }
                lblNroSubtotal.Text = acumuladorSubtotal.ToString("#.##");
                ActualizarCarrito();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstCarrito.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
            }
            else
            {
                    ListView.SelectedListViewItemCollection productosARestar = lstCarrito.SelectedItems;
                    int nroProducto;
                    foreach (ListViewItem item in productosARestar)
                    {
                        nroProducto = int.Parse(item.SubItems[0].Text);
                        Producto productoAgregadoAlCarrito = Comercio.ObtenerProductoPorId(nroProducto);
                        Comercio.QuitarProductoACarrito(productoAgregadoAlCarrito);
                        acumuladorSubtotal = (acumuladorSubtotal - productoAgregadoAlCarrito.Precio);
                        Comercio.AgregarProductoAInventario(nroProducto,1);
                        ActualizarInventario();
                    }
                lblNroSubtotal.Text = acumuladorSubtotal.ToString("#.##");
                ActualizarCarrito();
            }
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {

            LimpiarCarrito();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (Comercio.Carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito");
            }
            else
            {
            FormFinalizarCompra formFinalizarCompra = new FormFinalizarCompra();
            formFinalizarCompra.ShowDialog();
                LimpiarCarrito();
            CargarInventario();
            
            }

        }

        private void historialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialCompras formHistorialCompras = new FormHistorialCompras();
            formHistorialCompras.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }

        //Funcion que recarga el inventario
        private void CargarInventario()
        {
            inventarioCopia = (Comercio.Inventario as IEnumerable<Producto>).ToList();
            lblNroSubtotal.Text = acumuladorSubtotal.ToString("#.##");
            ActualizarInventario();
        }

        public void ActualizarInventario()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = inventarioCopia;
            dgvStock.Columns.Remove("subtotal");
            dgvStock.AutoResizeColumns();
            dgvStock.DefaultCellStyle.BackColor = Color.Lavender;
        }

        /// <summary>
        /// Funcion que limpia el carrito, actualiza el datagrid y devuelve el acumulador a 0
        /// </summary>
        private void LimpiarCarrito()
        {
            int nroProducto;
            if (lstCarrito.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
            }
            else
            {
                foreach (ListViewItem item in lstCarrito.Items)
                    {
                        nroProducto = int.Parse(item.SubItems[0].Text);
                        int cantidad = int.Parse(item.SubItems[2].Text);
                        Producto productoAgregadoAlCarrito = Comercio.ObtenerProductoPorId(nroProducto);
                        Comercio.QuitarProductoACarrito(productoAgregadoAlCarrito);
                        acumuladorSubtotal = (acumuladorSubtotal - productoAgregadoAlCarrito.Precio);
                        Comercio.AgregarProductoAInventario(nroProducto, cantidad);
                   
                    }
            Comercio.Carrito.Clear();
            ActualizarInventario();
            ActualizarCarrito();
            acumuladorSubtotal = 0.00;
            lblNroSubtotal.Text = acumuladorSubtotal.ToString("#.##");

            }
        }
        /// <summary>
        /// Funcion que realiza la actualizacion del ListView cuando se agregan o quitan productos al carrito.
        /// </summary>
        private void ActualizarCarrito()
        {
            lstCarrito.Items.Clear();
            foreach (Producto producto in Comercio.Carrito)
            {
                ListViewItem item = new ListViewItem(producto.NroProducto.ToString());
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Cantidad.ToString());
                item.SubItems.Add(producto.Subtotal.ToString("#.##"));

                lstCarrito.Items.Add(item);
            }
            
            lstCarrito.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstCarrito_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = 80;

        }

        private void enviosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnvios formEnvios = new FormEnvios();
            formEnvios.ShowDialog();
        }
    }
}
