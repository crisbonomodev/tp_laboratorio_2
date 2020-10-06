namespace KwikEMart
{
    partial class FormFinalizarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnNuevoCliente;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinalizarCompra));
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picVendedor = new System.Windows.Forms.PictureBox();
            this.lblDataNombreVendedor = new System.Windows.Forms.Label();
            this.lblDataApellidoVendedor = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblApellidoVendedor = new System.Windows.Forms.Label();
            this.lblApellidoData = new System.Windows.Forms.Label();
            this.lblNombreData = new System.Windows.Forms.Label();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.grpResumenCompra = new System.Windows.Forms.GroupBox();
            this.lblEnvioData = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.lblDescuentosData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.lblSubtotalData = new System.Windows.Forms.Label();
            this.lblSubtotalCompra = new System.Windows.Forms.Label();
            this.grpEnvio = new System.Windows.Forms.GroupBox();
            this.txtPersonaResponsable = new System.Windows.Forms.TextBox();
            this.lblPersonaResponsable = new System.Windows.Forms.Label();
            this.cmbEnvio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            btnNuevoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            this.grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.grpResumenCompra.SuspendLayout();
            this.grpEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new System.Drawing.Point(175, 52);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new System.Drawing.Size(107, 21);
            btnNuevoCliente.TabIndex = 0;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeColumns = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(12, 12);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(432, 545);
            this.dgvCarrito.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picVendedor);
            this.groupBox1.Controls.Add(this.lblDataNombreVendedor);
            this.groupBox1.Controls.Add(this.lblDataApellidoVendedor);
            this.groupBox1.Controls.Add(this.lblNombreVendedor);
            this.groupBox1.Controls.Add(this.lblApellidoVendedor);
            this.groupBox1.Controls.Add(this.lblApellidoData);
            this.groupBox1.Controls.Add(this.lblNombreData);
            this.groupBox1.Location = new System.Drawing.Point(470, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vendedor";
            // 
            // picVendedor
            // 
            this.picVendedor.Location = new System.Drawing.Point(372, 12);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(60, 60);
            this.picVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVendedor.TabIndex = 8;
            this.picVendedor.TabStop = false;
            // 
            // lblDataNombreVendedor
            // 
            this.lblDataNombreVendedor.AutoSize = true;
            this.lblDataNombreVendedor.Location = new System.Drawing.Point(60, 59);
            this.lblDataNombreVendedor.Name = "lblDataNombreVendedor";
            this.lblDataNombreVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblDataNombreVendedor.TabIndex = 7;
            this.lblDataNombreVendedor.Text = "Apellido:";
            // 
            // lblDataApellidoVendedor
            // 
            this.lblDataApellidoVendedor.AutoSize = true;
            this.lblDataApellidoVendedor.Location = new System.Drawing.Point(60, 32);
            this.lblDataApellidoVendedor.Name = "lblDataApellidoVendedor";
            this.lblDataApellidoVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblDataApellidoVendedor.TabIndex = 6;
            this.lblDataApellidoVendedor.Text = "Apellido:";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(7, 59);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreVendedor.TabIndex = 5;
            this.lblNombreVendedor.Text = "Nombre:";
            // 
            // lblApellidoVendedor
            // 
            this.lblApellidoVendedor.AutoSize = true;
            this.lblApellidoVendedor.Location = new System.Drawing.Point(7, 32);
            this.lblApellidoVendedor.Name = "lblApellidoVendedor";
            this.lblApellidoVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoVendedor.TabIndex = 4;
            this.lblApellidoVendedor.Text = "Apellido:";
            // 
            // lblApellidoData
            // 
            this.lblApellidoData.AutoSize = true;
            this.lblApellidoData.Location = new System.Drawing.Point(74, 59);
            this.lblApellidoData.Name = "lblApellidoData";
            this.lblApellidoData.Size = new System.Drawing.Size(0, 13);
            this.lblApellidoData.TabIndex = 3;
            // 
            // lblNombreData
            // 
            this.lblNombreData.AutoSize = true;
            this.lblNombreData.Location = new System.Drawing.Point(71, 32);
            this.lblNombreData.Name = "lblNombreData";
            this.lblNombreData.Size = new System.Drawing.Size(0, 13);
            this.lblNombreData.TabIndex = 2;
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.picCliente);
            this.grpDatosCliente.Controls.Add(this.label1);
            this.grpDatosCliente.Controls.Add(this.cmbClientes);
            this.grpDatosCliente.Controls.Add(btnNuevoCliente);
            this.grpDatosCliente.Location = new System.Drawing.Point(471, 141);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(445, 93);
            this.grpDatosCliente.TabIndex = 2;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del cliente";
            // 
            // picCliente
            // 
            this.picCliente.Location = new System.Drawing.Point(371, 14);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(60, 60);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 9;
            this.picCliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione el cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(9, 53);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(160, 21);
            this.cmbClientes.TabIndex = 1;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // grpResumenCompra
            // 
            this.grpResumenCompra.Controls.Add(this.lblEnvioData);
            this.grpResumenCompra.Controls.Add(this.lblEnvio);
            this.grpResumenCompra.Controls.Add(this.lblTotalData);
            this.grpResumenCompra.Controls.Add(this.lblDescuentosData);
            this.grpResumenCompra.Controls.Add(this.lblTotal);
            this.grpResumenCompra.Controls.Add(this.lblDescuento);
            this.grpResumenCompra.Controls.Add(this.btnRealizarCompra);
            this.grpResumenCompra.Controls.Add(this.lblSubtotalData);
            this.grpResumenCompra.Controls.Add(this.lblSubtotalCompra);
            this.grpResumenCompra.Location = new System.Drawing.Point(470, 380);
            this.grpResumenCompra.Name = "grpResumenCompra";
            this.grpResumenCompra.Size = new System.Drawing.Size(445, 177);
            this.grpResumenCompra.TabIndex = 3;
            this.grpResumenCompra.TabStop = false;
            this.grpResumenCompra.Text = "Resumen de la compra";
            // 
            // lblEnvioData
            // 
            this.lblEnvioData.AutoSize = true;
            this.lblEnvioData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvioData.Location = new System.Drawing.Point(328, 59);
            this.lblEnvioData.Name = "lblEnvioData";
            this.lblEnvioData.Size = new System.Drawing.Size(40, 20);
            this.lblEnvioData.TabIndex = 8;
            this.lblEnvioData.Text = "0.00";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvio.Location = new System.Drawing.Point(6, 59);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(48, 20);
            this.lblEnvio.TabIndex = 7;
            this.lblEnvio.Text = "Envío";
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalData.Location = new System.Drawing.Point(328, 120);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(40, 20);
            this.lblTotalData.TabIndex = 6;
            this.lblTotalData.Text = "0.00";
            // 
            // lblDescuentosData
            // 
            this.lblDescuentosData.AutoSize = true;
            this.lblDescuentosData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentosData.Location = new System.Drawing.Point(328, 89);
            this.lblDescuentosData.Name = "lblDescuentosData";
            this.lblDescuentosData.Size = new System.Drawing.Size(40, 20);
            this.lblDescuentosData.TabIndex = 5;
            this.lblDescuentosData.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 120);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(6, 89);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(95, 20);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "Descuentos";
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Location = new System.Drawing.Point(325, 143);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(107, 23);
            this.btnRealizarCompra.TabIndex = 2;
            this.btnRealizarCompra.Text = "Realizar compra";
            this.btnRealizarCompra.UseVisualStyleBackColor = true;
            this.btnRealizarCompra.Click += new System.EventHandler(this.btnRealizarCompra_Click);
            // 
            // lblSubtotalData
            // 
            this.lblSubtotalData.AutoSize = true;
            this.lblSubtotalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalData.Location = new System.Drawing.Point(328, 30);
            this.lblSubtotalData.Name = "lblSubtotalData";
            this.lblSubtotalData.Size = new System.Drawing.Size(40, 20);
            this.lblSubtotalData.TabIndex = 1;
            this.lblSubtotalData.Text = "0.00";
            // 
            // lblSubtotalCompra
            // 
            this.lblSubtotalCompra.AutoSize = true;
            this.lblSubtotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalCompra.Location = new System.Drawing.Point(6, 30);
            this.lblSubtotalCompra.Name = "lblSubtotalCompra";
            this.lblSubtotalCompra.Size = new System.Drawing.Size(69, 20);
            this.lblSubtotalCompra.TabIndex = 0;
            this.lblSubtotalCompra.Text = "Subtotal";
            // 
            // grpEnvio
            // 
            this.grpEnvio.Controls.Add(this.label4);
            this.grpEnvio.Controls.Add(this.label3);
            this.grpEnvio.Controls.Add(this.txtAltura);
            this.grpEnvio.Controls.Add(this.txtCalle);
            this.grpEnvio.Controls.Add(this.txtPersonaResponsable);
            this.grpEnvio.Controls.Add(this.lblPersonaResponsable);
            this.grpEnvio.Controls.Add(this.cmbEnvio);
            this.grpEnvio.Controls.Add(this.label2);
            this.grpEnvio.Location = new System.Drawing.Point(471, 240);
            this.grpEnvio.Name = "grpEnvio";
            this.grpEnvio.Size = new System.Drawing.Size(445, 134);
            this.grpEnvio.TabIndex = 4;
            this.grpEnvio.TabStop = false;
            this.grpEnvio.Text = "Envío";
            // 
            // txtPersonaResponsable
            // 
            this.txtPersonaResponsable.Location = new System.Drawing.Point(76, 104);
            this.txtPersonaResponsable.Name = "txtPersonaResponsable";
            this.txtPersonaResponsable.Size = new System.Drawing.Size(160, 20);
            this.txtPersonaResponsable.TabIndex = 12;
            // 
            // lblPersonaResponsable
            // 
            this.lblPersonaResponsable.AutoSize = true;
            this.lblPersonaResponsable.Location = new System.Drawing.Point(14, 111);
            this.lblPersonaResponsable.Name = "lblPersonaResponsable";
            this.lblPersonaResponsable.Size = new System.Drawing.Size(38, 13);
            this.lblPersonaResponsable.TabIndex = 11;
            this.lblPersonaResponsable.Text = "Retira:";
            // 
            // cmbEnvio
            // 
            this.cmbEnvio.FormattingEnabled = true;
            this.cmbEnvio.Location = new System.Drawing.Point(76, 21);
            this.cmbEnvio.Name = "cmbEnvio";
            this.cmbEnvio.Size = new System.Drawing.Size(160, 21);
            this.cmbEnvio.TabIndex = 10;
            this.cmbEnvio.SelectedIndexChanged += new System.EventHandler(this.cmbEnvio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Envío:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(76, 52);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(160, 20);
            this.txtCalle.TabIndex = 13;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(76, 78);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(160, 20);
            this.txtAltura.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Altura:";
            // 
            // FormFinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(928, 569);
            this.Controls.Add(this.grpEnvio);
            this.Controls.Add(this.grpResumenCompra);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCarrito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFinalizarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik-E-Mart - Finalizar Compra";
            this.Load += new System.EventHandler(this.FormFinalizarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).EndInit();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.grpResumenCompra.ResumeLayout(false);
            this.grpResumenCompra.PerformLayout();
            this.grpEnvio.ResumeLayout(false);
            this.grpEnvio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblApellidoData;
        private System.Windows.Forms.Label lblNombreData;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.GroupBox grpResumenCompra;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Label lblSubtotalData;
        private System.Windows.Forms.Label lblSubtotalCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblDataNombreVendedor;
        private System.Windows.Forms.Label lblDataApellidoVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblApellidoVendedor;
        private System.Windows.Forms.PictureBox picVendedor;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.Label lblDescuentosData;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.GroupBox grpEnvio;
        private System.Windows.Forms.ComboBox cmbEnvio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnvioData;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.TextBox txtPersonaResponsable;
        private System.Windows.Forms.Label lblPersonaResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
    }
}