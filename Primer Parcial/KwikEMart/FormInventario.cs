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

namespace KwikEMart
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            ActualizarGrilla(Comercio.Inventario);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool validarStock = Validaciones.ValidarIngresoStock(txtCantidad.Text);
            bool validarPrecio = Validaciones.ValidarPrecio(txtPrecio.Text);
            if (validarStock && validarPrecio)
            {
                Comercio.CrearNuevoProducto(txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(txtCantidad.Text));
                ActualizarGrilla(Comercio.Inventario);
                MessageBox.Show("Producto agregado al inventario");
            }
            else
            {
                MessageBox.Show("Error en el ingreso. Revise sus datos.");
            }
            
            }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerReporte_Click(object sender, EventArgs e)
        {
            List<Producto> productosAReponer = new List<Producto>();

            foreach (Producto item in Comercio.Inventario)
            {
                if (item.Cantidad < 10)
                {
                    productosAReponer.Add(item);
                }
            }
            ActualizarGrilla(productosAReponer);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla(Comercio.Inventario);
        }
        /// <summary>
        /// Metodo de actualizacion de la grilla.
        /// </summary>
        /// <param name="lista"></param>
        private void ActualizarGrilla(List<Producto> lista)
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = lista;
            dgvInventario.Columns.Remove("subtotal");
            dgvInventario.AutoResizeColumns();
        }
    }
}
