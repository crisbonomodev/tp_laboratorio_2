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

namespace Forms
{
    public partial class frmCotizacion : Form
    {
        Operacion nuevaOperacion = new Operacion();
        Ticketera ticketera;
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {

            cmbOperacion.Items.Add(CasaDeCambio.TipoDeOperacion.Compra);
            cmbOperacion.Items.Add(CasaDeCambio.TipoDeOperacion.Venta);
            cmbTipoOperacion.Items.Add("Cotización");
            cmbTipoOperacion.Items.Add("Operación");
            cmbDivisa.Items.Add(Divisa.NombreDivisa.Dolar);
            cmbDivisa.Items.Add(Divisa.NombreDivisa.Euro);
            cmbDivisa.Items.Add(Divisa.NombreDivisa.Real);
            cmbDivisa.SelectedIndex = 1;
            ticketera = new Ticketera();

        }
        /// <summary>
        /// Metodo que se ocupa de actualizar la informacion del formulario
        /// </summary>
        private void ActualizarInformacion()
        {
            foreach (Divisa cotizacion in CasaDeCambio.Cotizaciones)
            {

                if (cotizacion.divisa.ToString() == cmbDivisa.SelectedItem.ToString())
                {
                    switch (cmbOperacion.SelectedItem)
                    {
                        case CasaDeCambio.TipoDeOperacion.Compra:
                            nuevaOperacion.TipoOperacion = CasaDeCambio.TipoDeOperacion.Compra;
                            lblCotizacion.Text = cotizacion.ValorVenta.ToString();
                            break;
                        case CasaDeCambio.TipoDeOperacion.Venta:
                            nuevaOperacion.TipoOperacion = CasaDeCambio.TipoDeOperacion.Venta;
                            lblCotizacion.Text = cotizacion.ValorCompra.ToString();
                            break;
                    }
                    if (txtMonto.Text != "")
                    {
                        nuevaOperacion.Monto = decimal.Parse(txtMonto.Text);
                        nuevaOperacion.Cotizar();
                        lblConversion.Text = nuevaOperacion.MontoFinal.ToString("#.##");
                    }
                    else
                    {
                        lblConversion.Text = "0.00";
                    }
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDivisa.Enabled = true;
            nuevaOperacion.TipoOperacion = (CasaDeCambio.TipoDeOperacion)cmbOperacion.SelectedItem;
            ActualizarInformacion();
        }

        private void cmbDivisa_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Divisa divisa in CasaDeCambio.Cotizaciones)
            {
                if (divisa.divisa.ToString() == cmbDivisa.SelectedItem.ToString())
                {
                    nuevaOperacion.Divisa = divisa;
                }
            }
            ActualizarInformacion();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (Validaciones.ValidarIngresoNumeros(txtMonto.Text))
                {
                    nuevaOperacion.Monto = decimal.Parse(txtMonto.Text);
                    nuevaOperacion.Cotizar();
                    lblConversion.Text = nuevaOperacion.MontoFinal.ToString("#.##");

                }
                else
                {
                    txtMonto.Text = "";
                    lblConversion.Text = "0.00";
                }

            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Ha excedido el valor máximo posible");
            }catch (System.FormatException)
            {
                MessageBox.Show("Formato incorrecto, ingrese solo numeros");
                txtMonto.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDivisa.SelectedIndex == -1 || cmbOperacion.SelectedIndex == -1 || cmbTipoOperacion.SelectedIndex == -1 || txtMonto.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else 
            {
            
            switch (cmbTipoOperacion.SelectedItem)
            {
                case "Cotización":
                ticketera.ImprimirTicket(nuevaOperacion);
                break;
                case "Operación":
                BaseDeDatos.RegistrarNuevaOperacion(nuevaOperacion);
                ticketera.ImprimirTicket(nuevaOperacion);
                break;
            }
            this.Close();
            }
        }
    }
}

                