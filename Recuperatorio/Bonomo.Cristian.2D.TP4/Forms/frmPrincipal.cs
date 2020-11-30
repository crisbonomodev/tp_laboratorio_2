using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace Forms
{
    public partial class frmPrincipal : Form
    {
        public delegate void ActualizarInformacion();
        public event ActualizarInformacion actualizacion;

        List<Thread> listaThreads = new List<Thread>();
        Thread hiloPrincipal;
        Thread hiloActualizar;
        public frmPrincipal()
        {
            hiloPrincipal = new Thread(this.Comenzar);
            hiloActualizar = new Thread(this.ActualizarOperacionesEnLinea);
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GenerarOperacionesEnLinea();
            actualizacion += ActualizarDatagrids;
            ActualizarDatagrids();

            if (!hiloPrincipal.IsAlive)
            {
                listaThreads.Add(hiloPrincipal);
                hiloPrincipal.Start();
                listaThreads.Add(hiloActualizar);
                hiloActualizar.Start();
            }

        }

        private void Comenzar()
        {
            Thread.Sleep(1000);
            ActualizarDatagrids();
        }

        private void ActualizarOperacionesEnLinea()
        {
            do
            {
                Thread.Sleep(5000);
                if (this.dgvOperaciones.InvokeRequired)
                {
                    this.dgvOperaciones.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Operacion nuevaOperacion = CasaDeCambio.OperacionesEnLinea.Dequeue();
                        BaseDeDatos.RegistrarNuevaOperacion(nuevaOperacion);
                    });
                }
                actualizacion.Invoke();
            } while (CasaDeCambio.OperacionesEnLinea.Count > 0);
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            frmCotizacion frmCotizacion = new frmCotizacion();
            frmCotizacion.ShowDialog();
            actualizacion.Invoke();
        }

        private void ActualizarDatagrids()
        {
            if (this.dgvCotizacion.InvokeRequired)
            {
                this.dgvCotizacion.BeginInvoke((MethodInvoker)delegate ()
                {
                    CasaDeCambio.Cotizaciones = BaseDeDatos.ObtenerCotizaciones();
                    dgvCotizacion.Rows.Clear();
                    dgvCotizacion.Columns.Clear();
                    dgvCotizacion.DataSource = null;
                    dgvCotizacion.Columns.Add("Divisa", "Divisa");
                    dgvCotizacion.Columns.Add("Valor Compra", "Valor Compra");
                    dgvCotizacion.Columns.Add("Valor Venta", "Valor Venta");
                    foreach (Divisa cotizacion in CasaDeCambio.Cotizaciones)
                    {
                        dgvCotizacion.Rows.Add(cotizacion.divisa.ToString(),
                            cotizacion.ValorCompra.ToString(),
                            cotizacion.ValorVenta.ToString());
                    }
                    dgvCotizacion.AutoResizeColumns();
                });
            }

            if (this.dgvCotizacion.InvokeRequired)
            {
                this.dgvCotizacion.BeginInvoke((MethodInvoker)delegate ()
                {
                    CasaDeCambio.Operaciones = BaseDeDatos.ObtenerOperaciones();
                    dgvOperaciones.DataSource = null;
                    dgvOperaciones.Rows.Clear();
                    dgvOperaciones.Columns.Clear();
                    dgvOperaciones.Columns.Add("idOPeracion", "ID");
                    dgvOperaciones.Columns.Add("fechaHora", "Fecha y Hora");
                    dgvOperaciones.Columns.Add("tipoOperacion", "Tipo de operación");
                    dgvOperaciones.Columns.Add("divisa", "Divisa");
                    dgvOperaciones.Columns.Add("monto", "Monto inicial");
                    dgvOperaciones.Columns.Add("montoFinal", "Monto final");
                    foreach (Operacion operacion in CasaDeCambio.Operaciones)
                    {
                        dgvOperaciones.Rows.Add(operacion.IdOperacion,
                            operacion.FechaYHora,
                            operacion.TipoOperacion,
                            operacion.Divisa.divisa,
                            operacion.Monto,
                            operacion.MontoFinal);
                    }
                    dgvOperaciones.AutoResizeColumns();
                });
             }
                    
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializacion.EscribirAArchivo(CasaDeCambio.Operaciones);
            foreach (Thread hilo in listaThreads)
            {
                hilo.Abort();
            }
        }

        /// <summary>
        /// Metodo que genera las operaciones en linea
        /// </summary>
        private void GenerarOperacionesEnLinea()
        {
            for (int i = 0; i < 20; i++)
            {
            CasaDeCambio.OperacionesEnLinea.Enqueue(Operacion.GenerarOperacionRandom());
            }
        }
        
    }
}
