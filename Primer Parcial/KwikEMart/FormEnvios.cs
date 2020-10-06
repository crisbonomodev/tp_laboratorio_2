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
    public partial class FormEnvios : Form
    {
        public FormEnvios()
        {
            InitializeComponent();
        }

        private void FormEnvios_Load(object sender, EventArgs e)
        {
            dgvRetiraEnLocal.DataSource = null;
            dgvRetiraEnLocal.DataSource = Comercio.EnvioRetLocal;
            dgvEnviosADomicilio.DataSource = null;
            dgvEnviosADomicilio.DataSource = Comercio.EnvioADomicilio;

        }
    }
}
