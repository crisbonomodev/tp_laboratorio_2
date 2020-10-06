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
using Entidades;

namespace KwikEMart
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Comercio.Login(txtLegajo.Text, txtPassword.Text) == true)
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                this.Hide();
    
            }
            else
            {
                MessageBox.Show("Login incorrecto");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            txtLegajo.Enabled = false;
            txtPassword.Enabled = false;
            btnLogin.Enabled = false;
            lblLoadingStatus.Text = "Cargando productos";
            string pathCsv = $"{path}\\resources\\data\\productos.csv";
            var reader = new StreamReader(File.OpenRead(pathCsv));

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                string[] values = linea.Split(',');
                Producto itemACargar = new Producto(int.Parse(values[0]), values[1], Math.Round(double.Parse(values[2]),2), int.Parse(values[3]));
                Comercio.Inventario.Add(itemACargar);
            }
            prgBarLoading.Value = 30;
            lblLoadingStatus.Text = "Cargando empleados";
            Comercio.AgregarEmpleado("Apu", "Nahasapeemapetilon", 92000001, "123456", $"{path}\\resources\\apu.jpg");
            Comercio.AgregarEmpleado("Sanjai", "Nahasapeemapetilon", 92000002, "123456", $"{path}\\resources\\sanjay.jpg");

            lblLoadingStatus.Text = "Cargando clientes";
            Comercio.RegistrarNuevoCliente("Homero", "Simpson", 10000001, $"{path}\\resources\\homero.jpg");
            Comercio.RegistrarNuevoCliente("Marge", "Simpson", 10000002, $"{path}\\resources\\marge.jpg");
            Comercio.RegistrarNuevoCliente("Cristian", "Bonomo", 10000003, $"{path}\\resources\\default.jpg");
            prgBarLoading.Value = 50;
            lblLoadingStatus.Text = "Cargando compras";
            var random = new Random();
            for (int i = 0; i < 50; i++)
            {
                int cantidadProductosRandom;
                Producto productoEjemplo;
                List<Producto> listaEjemplo = new List<Producto>();
                cantidadProductosRandom = random.Next(1, 10);
                for (int j = 0; j < cantidadProductosRandom; j++)
                {
                    int idProductoRandom;
                    idProductoRandom = random.Next(1, 30);
                    productoEjemplo = Comercio.ObtenerProductoPorId(idProductoRandom);
                    productoEjemplo.Cantidad = random.Next(1, 4);
                    productoEjemplo.Subtotal = Math.Round(productoEjemplo.Cantidad * productoEjemplo.Precio,2);
                    listaEjemplo.Add(productoEjemplo);
                }
                int idCliente = random.Next(0, 3);
                int idVendedor = random.Next(0, 2);
                Comercio.RegistrarNuevaCompra(idVendedor, idCliente, listaEjemplo);
                
            }
            
            prgBarLoading.Value = 100;
            txtLegajo.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            lblLoadingStatus.Text = "Ingrese su legajo y clave.Demo: Legajo: 1, clave:123456";
            FormLogin formLogin = new FormLogin();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
