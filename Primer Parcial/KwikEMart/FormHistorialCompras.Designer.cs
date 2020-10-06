namespace KwikEMart
{
    partial class FormHistorialCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialCompras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.dgvDetalleCompras = new System.Windows.Forms.DataGridView();
            this.btnDetalleCompra = new System.Windows.Forms.Button();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.BtnReiniciarFiltro = new System.Windows.Forms.Button();
            this.grpFiltrar = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompras)).BeginInit();
            this.grpFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(-4, -2);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.Size = new System.Drawing.Size(792, 241);
            this.dgvCompras.TabIndex = 0;
            // 
            // dgvDetalleCompras
            // 
            this.dgvDetalleCompras.AllowUserToAddRows = false;
            this.dgvDetalleCompras.AllowUserToDeleteRows = false;
            this.dgvDetalleCompras.AllowUserToResizeColumns = false;
            this.dgvDetalleCompras.AllowUserToResizeRows = false;
            this.dgvDetalleCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompras.Location = new System.Drawing.Point(-4, 334);
            this.dgvDetalleCompras.Name = "dgvDetalleCompras";
            this.dgvDetalleCompras.Size = new System.Drawing.Size(792, 175);
            this.dgvDetalleCompras.TabIndex = 1;
            // 
            // btnDetalleCompra
            // 
            this.btnDetalleCompra.Location = new System.Drawing.Point(303, 256);
            this.btnDetalleCompra.Name = "btnDetalleCompra";
            this.btnDetalleCompra.Size = new System.Drawing.Size(141, 72);
            this.btnDetalleCompra.TabIndex = 2;
            this.btnDetalleCompra.Text = "Ver Detalle";
            this.btnDetalleCompra.UseVisualStyleBackColor = true;
            this.btnDetalleCompra.Click += new System.EventHandler(this.btnDetalleCompra_Click);
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(65, 18);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(184, 21);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(6, 21);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(6, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // BtnReiniciarFiltro
            // 
            this.BtnReiniciarFiltro.Location = new System.Drawing.Point(87, 54);
            this.BtnReiniciarFiltro.Name = "BtnReiniciarFiltro";
            this.BtnReiniciarFiltro.Size = new System.Drawing.Size(75, 23);
            this.BtnReiniciarFiltro.TabIndex = 6;
            this.BtnReiniciarFiltro.Text = "Reiniciar filtro";
            this.BtnReiniciarFiltro.UseVisualStyleBackColor = true;
            this.BtnReiniciarFiltro.Click += new System.EventHandler(this.BtnReiniciarFiltro_Click);
            // 
            // grpFiltrar
            // 
            this.grpFiltrar.Controls.Add(this.lblVendedor);
            this.grpFiltrar.Controls.Add(this.BtnReiniciarFiltro);
            this.grpFiltrar.Controls.Add(this.cmbVendedor);
            this.grpFiltrar.Controls.Add(this.btnFiltrar);
            this.grpFiltrar.Location = new System.Drawing.Point(12, 245);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(255, 83);
            this.grpFiltrar.TabIndex = 7;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar por vendedor";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(697, 526);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormHistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grpFiltrar);
            this.Controls.Add(this.btnDetalleCompra);
            this.Controls.Add(this.dgvDetalleCompras);
            this.Controls.Add(this.dgvCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormHistorialCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik-E-Mart - Historial de compras";
            this.Load += new System.EventHandler(this.FormHistorialCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompras)).EndInit();
            this.grpFiltrar.ResumeLayout(false);
            this.grpFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridView dgvDetalleCompras;
        private System.Windows.Forms.Button btnDetalleCompra;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button BtnReiniciarFiltro;
        private System.Windows.Forms.GroupBox grpFiltrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}