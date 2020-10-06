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
    public partial class FormFinalizarCompra : Form
    {
        double subTotal;
        double descuento;
        double total;
        string[] datosEmpleado = new string[3];
        public FormFinalizarCompra()
        {
            InitializeComponent();
        }

        private void FormFinalizarCompra_Load(object sender, EventArgs e)
        {
            datosEmpleado = Comercio.ChequearLogin();
            lblDataApellidoVendedor.Text = datosEmpleado[1];
            lblDataNombreVendedor.Text = datosEmpleado[2];
            picVendedor.ImageLocation = datosEmpleado[3];
            dgvCarrito.DataSource = Comercio.Carrito;
            dgvCarrito.AutoResizeColumns();
            CargarClientesEnCombobox();
            subTotal = Comercio.CalcularSubtotal();
            descuento = 0;
            total = subTotal - descuento;
            lblSubtotalData.Text = subTotal.ToString();
            lblTotalData.Text = total.ToString();
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente");
            }
            else
            {

            int idCliente = cmbClientes.SelectedIndex;

            Comercio.RegistrarNuevaCompra(int.Parse(datosEmpleado[0]), idCliente, Comercio.Carrito);
            MessageBox.Show("Gracias, vuelva prontossss!");
            Close();
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ShowDialog();
            CargarClientesEnCombobox();
        }

        /// <summary>
        /// Metodo para cargar la lista de clientes en el combobox de selección de clientes
        /// </summary>
        private void CargarClientesEnCombobox()
        {
            cmbClientes.Items.Clear();
            foreach (Cliente cliente in Comercio.Clientes)
            {
                cmbClientes.Items.Insert(cliente.IdCliente, $"{cliente.Nombre} {cliente.Apellido}");
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathFotoCliente = Comercio.Clientes[cmbClientes.SelectedIndex].RutaFotoPerfil;
            picCliente.ImageLocation = pathFotoCliente;
            bool esSimpson = Comercio.VerificarDescuentoPorApellido(Comercio.Clientes[cmbClientes.SelectedIndex]);

            if (esSimpson)
            {
                descuento = subTotal * 0.13;
                lblDescuentosData.Text = descuento.ToString();
            }
            else
            {
                descuento = 0;
                lblDescuentosData.Text = descuento.ToString();
            }
            total = subTotal - descuento;
            lblSubtotalData.Text = subTotal.ToString();
            lblTotalData.Text = total.ToString();

        }
    }
}
