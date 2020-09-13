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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {   //Asignamos el espacio en memoria a las variables, y aseguramos su accesibilidad
        Numero num1;
        Numero num2;
        public FormCalculadora()
        {   //Inicializamos los componentes
            InitializeComponent();
            num1 = new Numero();
            num2 = new Numero();
            cmbOperador.SelectedIndex = 0;
            //Sugerencias para implementación en el código:
            //Deshabilitamos los botones de conversion para evitar problemas. Si bien las validaciones
            //se ocupan de esto, me parece buena práctica deshabilitar los botones de conversión
            //En el inicio, hasta que tengamos un Resultado, y cuando se limpien los campos.

            //btnConvertirABinario.Enabled = false;
            //btnConvertirADecimal.Enabled = false;

        }
        /// <summary>
        /// Evento Click para cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Evento para limpiar los datos de los Textbox, ComboBox y Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = null;
            txtNumero2.Text = null;
            lblResultado.Text = null;
            cmbOperador.SelectedIndex = 0;
            //Sugerencia: Deshabilitar los botones de conversion para evitar problemas.
            //btnConvertirABinario.Enabled = false;
            //btnConvertirADecimal.Enabled = false;  
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            num1.SetNumero = txtNumero1.Text;
            num2.SetNumero = txtNumero2.Text;
            string operador = cmbOperador.Text;
            lblResultado.Text = Calculadora.Operar(num1, num2, operador).ToString();
            //Sugerencia: Habilitar el boton para convertir a binario, deshabilitar el de conversión
            // a decimal como medida de seguridad adicional a la validación.
            //btnConvertirABinario.Enabled = true;
            //btnConvertirADecimal.Enabled = false;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != null)
            {
                string resultado = Numero.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = resultado;
                //Sugerencia: Habilitar el boton para convertir a binario, deshabilitar el de conversión
                // a decimal como medida de seguridad adicional a la validación.
                //btnConvertirABinario.Enabled = true;
                //btnConvertirADecimal.Enabled = false;
            }
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != null)
            {
                
                string resultado = Numero.DecimalBinario(lblResultado.Text);
                lblResultado.Text = resultado;
                //Sugerencia: Habilitar el boton para convertir a decimal, deshabilitar el de conversión
                // a binario como medida de seguridad adicional a la validación.
                //btnConvertirABinario.Enabled = false;
                //btnConvertirADecimal.Enabled = true;
            }


        }
    }
}
