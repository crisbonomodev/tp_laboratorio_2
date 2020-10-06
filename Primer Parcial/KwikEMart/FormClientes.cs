using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ShowDialog();
            lstClientes.Clear();
            CargarClientes();
            
        }

        private void CargarClientes()
        {
            ImageList profilepic = new ImageList();
            profilepic.ImageSize = new Size(150, 150);
            foreach (Cliente cliente in Comercio.Clientes)
            {
                profilepic.Images.Add(Image.FromFile(cliente.RutaFotoPerfil));
            }

            for (int i = 0; i < Comercio.Clientes.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{Comercio.Clientes[i].Apellido} {Comercio.Clientes[i].Nombre}");
                lstClientes.LargeImageList = profilepic;
                lstClientes.Items.Add(item);
                lstClientes.Items[i].ImageIndex = i;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            this.Height = 0;
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            this.Height = 50;
        }
    }
}
