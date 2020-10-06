using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace KwikEMart
{
    public partial class FormFinalizarCompra : Form
    {
        string path;
        double subTotal;
        double descuento;
        double envio;
        double total;
        string[] datosEmpleado = new string[3];
        public FormFinalizarCompra()
        {
            InitializeComponent();
        }

        private void FormFinalizarCompra_Load(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory();
            datosEmpleado = Comercio.ChequearLogin();
            lblDataApellidoVendedor.Text = datosEmpleado[1];
            lblDataNombreVendedor.Text = datosEmpleado[2];
            picVendedor.ImageLocation = datosEmpleado[3];
            dgvCarrito.DataSource = Comercio.Carrito;
            dgvCarrito.AutoResizeColumns();
            CargarClientesEnCombobox();
            cmbEnvio.Items.Add(Envio.tipoEnvio.Domicilio);
            cmbEnvio.Items.Add(Envio.tipoEnvio.RetiraEnLocal);
            descuento = 0;
            envio = 0;
            CalcularTotal();
            total = subTotal + envio - descuento;
            lblSubtotalData.Text = subTotal.ToString("#.##");
            lblTotalData.Text = total.ToString("#.##");
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null || txtPersonaResponsable.Text == "")
            {
                MessageBox.Show("Revise los datos faltantes.");
            }
            else
            {
                if (cmbEnvio.SelectedIndex == 0 && (txtCalle.Text == "" || txtAltura.Text == ""))
                {
                    MessageBox.Show("Revise los datos faltantes.");
                }
                else
                {
                    DateTime fechaHora = new DateTime();
                    fechaHora = DateTime.Now;
                    int idCliente = cmbClientes.SelectedIndex;
                    int nroCompra = Comercio.RegistrarNuevaCompra(int.Parse(datosEmpleado[0]), idCliente, Comercio.Carrito);
                    int nroEnvio;
                    StreamWriter sw = File.CreateText($"Ticket Nro{nroCompra}.txt");
                    sw.WriteLine("Kwik-E-Mart - Recibo X");
                    sw.WriteLine("---------------------------");
                    sw.WriteLine($"{fechaHora}");
                    sw.WriteLine("---------------------------");
                    sw.WriteLine($"Usted ha sido atendido por: {lblDataNombreVendedor.Text} {lblDataApellidoVendedor.Text}");
                    sw.WriteLine("---------------------------");
                    sw.WriteLine($"Cliente: {cmbClientes.SelectedItem.ToString()}");
                    sw.WriteLine("---------------------------");
                    sw.WriteLine("Producto Nro Descripcion Cantidad PrecioU Subtotal");
                    foreach (Producto item in Comercio.Carrito)
                    {
                        sw.WriteLine($"{item.NroProducto} {item.Descripcion} {item.Cantidad} {item.Precio} {item.Subtotal}");
                    }
                    switch (cmbEnvio.SelectedIndex)
                {
                    case 0:
                            nroEnvio = Comercio.EnvioADomicilio.Count;
                            EnvioADomicilio aDomicilio = new EnvioADomicilio(nroEnvio, nroCompra, txtPersonaResponsable.Text, txtCalle.Text, int.Parse(txtAltura.Text),envio);
                            Comercio.AgregarEnvioDomicilio(aDomicilio);
                            sw.WriteLine($"Envio: {envio}");
                            sw.WriteLine(aDomicilio.ObtenerEnvio());
                        break;
                    case 1:
                            nroEnvio = Comercio.EnvioRetLocal.Count;
                            EnvioRetLocal retiraEnLocal = new EnvioRetLocal(nroEnvio, nroCompra, txtPersonaResponsable.Text);
                            Comercio.AgregarRetiroEnLocal(retiraEnLocal);
                            sw.WriteLine($"Envio: {envio}");
                            sw.WriteLine(retiraEnLocal.ObtenerEnvio());
                            break;
                    default:
                        break;
                }
                    sw.WriteLine("---------------------------");
                    sw.WriteLine($"Subtotal: {subTotal}");
                    sw.WriteLine($"Descuentos: {descuento}");
                    sw.WriteLine($"Total: {total}");
                    sw.WriteLine("---------------------------");
                    sw.WriteLine("Gracias, vuelva prontossss!");
                    sw.WriteLine("---------------------------");
                    sw.Close();
                    System.Diagnostics.Process.Start($"Ticket Nro{nroCompra}.txt");
                    SoundPlayer sp = new SoundPlayer($"{path}\\resources\\audio\\CompraFinalizada.wav");
                    sp.Play();
                    MessageBox.Show($"Gracias, vuelva prontossss!");
            Close();

                }
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
                lblDescuentosData.Text = descuento.ToString("#.##");
            }
            else
            {
                descuento = 0;
                lblDescuentosData.Text = descuento.ToString("#.##");
            }
            CalcularTotal();
            lblSubtotalData.Text = subTotal.ToString("#.##");
            lblTotalData.Text = total.ToString("#.##");

        }

        private void cmbEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccione un cliente para configurar el envío");
            }
            else
            {
            txtPersonaResponsable.Text = cmbClientes.SelectedItem.ToString();
            if (cmbEnvio.SelectedIndex == 0)
            {
                envio = 100;

                lblPersonaResponsable.Text = "Recibe:";
                txtCalle.Enabled = true;
                txtAltura.Enabled = true;
                txtPersonaResponsable.Enabled = true;
            }
            else
            {
                lblPersonaResponsable.Text = "Retira:";
                envio = 0;
                txtCalle.Enabled = false;
                txtAltura.Enabled = false;
                txtPersonaResponsable.Enabled = false;
            }
            CalcularTotal();
            lblEnvioData.Text = envio.ToString("#.##");
            lblSubtotalData.Text = subTotal.ToString("#.##");
            lblTotalData.Text = total.ToString("#.##");

            }
        }

        private double CalcularTotal()
        {
            subTotal = Comercio.CalcularSubtotal();

            total = subTotal + envio - descuento;
            return total;
        }
    }
}
