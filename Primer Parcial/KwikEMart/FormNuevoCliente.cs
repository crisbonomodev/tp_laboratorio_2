using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FormNuevoCliente : Form
    {
        string path;
        string pathProfilePicture;
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdCargarImagen = new OpenFileDialog();
            ofdCargarImagen.Filter = "Archivos de Imagen|*.jpg";
            ofdCargarImagen.InitialDirectory = $"{path}\\resources";
            if (ofdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                pathProfilePicture = ofdCargarImagen.FileName;
                picBoxProfile.ImageLocation = pathProfilePicture;
            }

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory();
            pathProfilePicture = $"{path}\\resources\\default.jpg";
            picBoxProfile.ImageLocation = pathProfilePicture;
        }

        private void btnGuardarNuevoCliente_Click(object sender, EventArgs e)
        {
            bool clienteGuardado = Comercio.RegistrarNuevoCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), pathProfilePicture);
            if (clienteGuardado == true)
            {
                MessageBox.Show("Cliente guardado exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cliente duplicado. Revise sus datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
