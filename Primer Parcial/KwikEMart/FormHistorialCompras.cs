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
    public partial class FormHistorialCompras : Form
    {
        int idVendedor = -1;
        List<Compra> comprasFiltradas;
        public FormHistorialCompras()
        {
            InitializeComponent();
        }

        private void FormHistorialCompras_Load(object sender, EventArgs e)
        {
            CargarComboBoxVendedores();
            dgvCompras.DataSource = null;
            dgvCompras.DataSource = Comercio.Compras;
            dgvCompras.AutoResizeColumns();
        }

        private void btnDetalleCompra_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una compra del listado");
            }
            else
            {
                int indiceCompra = (int)dgvCompras.SelectedRows[0].Cells[0].Value;
                List<Producto> detalleCompra = Comercio.BuscarDetalleDeCompra(indiceCompra);
                dgvDetalleCompras.DataSource = null;
                dgvDetalleCompras.DataSource = detalleCompra;
                dgvDetalleCompras.AutoResizeColumns();
            }
        }
        /// <summary>
        /// Carga la lista de vendedores en el combobox para seleccionar el vendedor
        /// </summary>
        private void CargarComboBoxVendedores()
        {
            foreach (Empleado vendedor in Comercio.Nomina)
            {

                cmbVendedor.Items.Insert(vendedor.NroLegajo, $"{vendedor.Nombre} {vendedor.Apellido}");
                
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (idVendedor == -1)
            {
                MessageBox.Show("Seleccione un vendedor");
            }
            else
            {
                comprasFiltradas = new List<Compra>();
                foreach (Compra compra in Comercio.Compras)
                {
                    if (compra.IdVendedor == idVendedor)
                    {
                        comprasFiltradas.Add(compra);
                    } 
                }
                dgvCompras.DataSource = null;
                dgvCompras.DataSource = comprasFiltradas;
                dgvCompras.AutoResizeColumns();
            }
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            idVendedor = cmbVendedor.SelectedIndex;
        }

        private void BtnReiniciarFiltro_Click(object sender, EventArgs e)
        {
            cmbVendedor.SelectedIndex = -1;
            dgvCompras.DataSource = null;
            dgvCompras.DataSource = Comercio.Compras;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
