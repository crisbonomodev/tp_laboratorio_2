using Entidades;
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

namespace KwikEMart
{
    public partial class FormEmpleados : Form
    {

        string path;

        string pathProfilePicture;
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory();
            dtgEmpleados.DataSource = Comercio.Nomina;
            dtgEmpleados.Columns.Remove("Password");
            dtgEmpleados.AutoResizeColumns();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Comercio.AgregarEmpleado(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtPassword.Text, pathProfilePicture);
            dtgEmpleados.DataSource = null;
            dtgEmpleados.DataSource = Comercio.Nomina;
            dtgEmpleados.Columns.Remove("Password");
            dtgEmpleados.AutoResizeColumns();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdCargarImagen = new OpenFileDialog();
            ofdCargarImagen.Filter = "Archivos de Imagen|*.jpg";
            ofdCargarImagen.InitialDirectory = $"{path}\\resources";
            if (ofdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                pathProfilePicture = ofdCargarImagen.FileName;
                picEmpleado.ImageLocation = pathProfilePicture;
            }
        }

        private void dtgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroLegajo = (int)dtgEmpleados.SelectedRows[0].Cells[0].Value;
            picEmpleado.ImageLocation = dtgEmpleados.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
