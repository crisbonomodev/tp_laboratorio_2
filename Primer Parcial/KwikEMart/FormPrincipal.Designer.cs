namespace KwikEMart
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblProductosEnStock = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnLimpiarCarrito = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblNroSubtotal = new System.Windows.Forms.Label();
            this.lstCarrito = new System.Windows.Forms.ListView();
            this.nroProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlDeInventarioToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.enviosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // controlDeInventarioToolStripMenuItem
            // 
            this.controlDeInventarioToolStripMenuItem.Name = "controlDeInventarioToolStripMenuItem";
            this.controlDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.controlDeInventarioToolStripMenuItem.Text = "Control de Inventario";
            this.controlDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.controlDeInventarioToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeComprasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // historialDeComprasToolStripMenuItem
            // 
            this.historialDeComprasToolStripMenuItem.Name = "historialDeComprasToolStripMenuItem";
            this.historialDeComprasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.historialDeComprasToolStripMenuItem.Text = "Historial de compras";
            this.historialDeComprasToolStripMenuItem.Click += new System.EventHandler(this.historialDeComprasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvStock.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStock.Location = new System.Drawing.Point(12, 130);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(431, 489);
            this.dgvStock.TabIndex = 1;
            this.dgvStock.VirtualMode = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(452, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 39);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(452, 301);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(103, 39);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblProductosEnStock
            // 
            this.lblProductosEnStock.AutoSize = true;
            this.lblProductosEnStock.Location = new System.Drawing.Point(12, 114);
            this.lblProductosEnStock.Name = "lblProductosEnStock";
            this.lblProductosEnStock.Size = new System.Drawing.Size(287, 13);
            this.lblProductosEnStock.TabIndex = 5;
            this.lblProductosEnStock.Text = "Inventario - Seleccione el producto y haga click en Agregar";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(876, 652);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(120, 63);
            this.btnFinalizarCompra.TabIndex = 6;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(452, 556);
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(101, 63);
            this.btnLimpiarCarrito.TabIndex = 7;
            this.btnLimpiarCarrito.Text = "Limpiar Carrito";
            this.btnLimpiarCarrito.UseVisualStyleBackColor = true;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(557, 622);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // lblNroSubtotal
            // 
            this.lblNroSubtotal.AutoSize = true;
            this.lblNroSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSubtotal.Location = new System.Drawing.Point(925, 622);
            this.lblNroSubtotal.Name = "lblNroSubtotal";
            this.lblNroSubtotal.Size = new System.Drawing.Size(40, 20);
            this.lblNroSubtotal.TabIndex = 9;
            this.lblNroSubtotal.Text = "0.00";
            // 
            // lstCarrito
            // 
            this.lstCarrito.BackColor = System.Drawing.Color.Lavender;
            this.lstCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nroProducto,
            this.Descripcion,
            this.Cantidad,
            this.Subtotal});
            this.lstCarrito.FullRowSelect = true;
            this.lstCarrito.GridLines = true;
            this.lstCarrito.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCarrito.HideSelection = false;
            this.lstCarrito.Location = new System.Drawing.Point(561, 130);
            this.lstCarrito.Name = "lstCarrito";
            this.lstCarrito.Size = new System.Drawing.Size(435, 489);
            this.lstCarrito.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstCarrito.TabIndex = 10;
            this.lstCarrito.UseCompatibleStateImageBehavior = false;
            this.lstCarrito.View = System.Windows.Forms.View.Details;
            this.lstCarrito.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstCarrito_ColumnWidthChanging);
            // 
            // nroProducto
            // 
            this.nroProducto.Text = "Producto";
            this.nroProducto.Width = 64;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 224;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 72;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Width = 152;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KwikEMart.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = global::KwikEMart.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(411, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Carrito - Seleccione el producto y haga click en Quitar";
            // 
            // enviosToolStripMenuItem
            // 
            this.enviosToolStripMenuItem.Name = "enviosToolStripMenuItem";
            this.enviosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.enviosToolStripMenuItem.Text = "Envios";
            this.enviosToolStripMenuItem.Click += new System.EventHandler(this.enviosToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstCarrito);
            this.Controls.Add(this.lblNroSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnLimpiarCarrito);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.lblProductosEnStock);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 766);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik-e-Mart - Procesar compra";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblProductosEnStock;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnLimpiarCarrito;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblNroSubtotal;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ListView lstCarrito;
        private System.Windows.Forms.ColumnHeader nroProducto;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem enviosToolStripMenuItem;
    }
}

