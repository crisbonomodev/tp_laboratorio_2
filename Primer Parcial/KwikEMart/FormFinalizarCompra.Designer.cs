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
            this.lblTotalData = new System.Windows.Forms.Label();
            this.lblDescuentosData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.lblSubtotalData = new System.Windows.Forms.Label();
            this.lblSubtotalCompra = new System.Windows.Forms.Label();
            btnNuevoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            this.grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.grpResumenCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new System.Drawing.Point(9, 95);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new System.Drawing.Size(107, 38);
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
            this.groupBox1.Size = new System.Drawing.Size(446, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vendedor";
            // 
            // picVendedor
            // 
            this.picVendedor.Location = new System.Drawing.Point(332, 19);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(100, 100);
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
            this.grpDatosCliente.Location = new System.Drawing.Point(471, 156);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(445, 151);
            this.grpDatosCliente.TabIndex = 2;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del cliente";
            // 
            // picCliente
            // 
            this.picCliente.Location = new System.Drawing.Point(331, 33);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(100, 100);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 9;
            this.picCliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
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
            this.grpResumenCompra.Controls.Add(this.lblTotalData);
            this.grpResumenCompra.Controls.Add(this.lblDescuentosData);
            this.grpResumenCompra.Controls.Add(this.lblTotal);
            this.grpResumenCompra.Controls.Add(this.lblDescuento);
            this.grpResumenCompra.Controls.Add(this.btnRealizarCompra);
            this.grpResumenCompra.Controls.Add(this.lblSubtotalData);
            this.grpResumenCompra.Controls.Add(this.lblSubtotalCompra);
            this.grpResumenCompra.Location = new System.Drawing.Point(470, 313);
            this.grpResumenCompra.Name = "grpResumenCompra";
            this.grpResumenCompra.Size = new System.Drawing.Size(445, 244);
            this.grpResumenCompra.TabIndex = 3;
            this.grpResumenCompra.TabStop = false;
            this.grpResumenCompra.Text = "Resumen de la compra";
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
            this.lblDescuentosData.Location = new System.Drawing.Point(328, 80);
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
            this.lblDescuento.Location = new System.Drawing.Point(6, 80);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(95, 20);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "Descuentos";
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Location = new System.Drawing.Point(332, 172);
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
            this.lblSubtotalData.Location = new System.Drawing.Point(328, 44);
            this.lblSubtotalData.Name = "lblSubtotalData";
            this.lblSubtotalData.Size = new System.Drawing.Size(40, 20);
            this.lblSubtotalData.TabIndex = 1;
            this.lblSubtotalData.Text = "0.00";
            // 
            // lblSubtotalCompra
            // 
            this.lblSubtotalCompra.AutoSize = true;
            this.lblSubtotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalCompra.Location = new System.Drawing.Point(6, 44);
            this.lblSubtotalCompra.Name = "lblSubtotalCompra";
            this.lblSubtotalCompra.Size = new System.Drawing.Size(69, 20);
            this.lblSubtotalCompra.TabIndex = 0;
            this.lblSubtotalCompra.Text = "Subtotal";
            // 
            // FormFinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(928, 569);
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
    }
}