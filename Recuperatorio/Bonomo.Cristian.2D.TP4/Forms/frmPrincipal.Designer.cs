namespace Forms
{
    partial class frmPrincipal
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
            this.dgvCotizacion = new System.Windows.Forms.DataGridView();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblUltimasOperaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCotizacion
            // 
            this.dgvCotizacion.AllowUserToAddRows = false;
            this.dgvCotizacion.AllowUserToDeleteRows = false;
            this.dgvCotizacion.AllowUserToResizeColumns = false;
            this.dgvCotizacion.AllowUserToResizeRows = false;
            this.dgvCotizacion.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizacion.Location = new System.Drawing.Point(12, 47);
            this.dgvCotizacion.MultiSelect = false;
            this.dgvCotizacion.Name = "dgvCotizacion";
            this.dgvCotizacion.ReadOnly = true;
            this.dgvCotizacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCotizacion.Size = new System.Drawing.Size(322, 233);
            this.dgvCotizacion.TabIndex = 0;
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCotizacion.Location = new System.Drawing.Point(239, 298);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(95, 43);
            this.btnCotizacion.TabIndex = 2;
            this.btnCotizacion.Text = "Operar";
            this.btnCotizacion.UseVisualStyleBackColor = false;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.AllowUserToResizeColumns = false;
            this.dgvOperaciones.AllowUserToResizeRows = false;
            this.dgvOperaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOperaciones.Location = new System.Drawing.Point(351, 47);
            this.dgvOperaciones.MultiSelect = false;
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperaciones.Size = new System.Drawing.Size(696, 448);
            this.dgvOperaciones.TabIndex = 6;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCotizacion.Location = new System.Drawing.Point(33, 16);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(83, 20);
            this.lblCotizacion.TabIndex = 7;
            this.lblCotizacion.Text = "Cotización";
            // 
            // lblUltimasOperaciones
            // 
            this.lblUltimasOperaciones.AutoSize = true;
            this.lblUltimasOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimasOperaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUltimasOperaciones.Location = new System.Drawing.Point(625, 16);
            this.lblUltimasOperaciones.Name = "lblUltimasOperaciones";
            this.lblUltimasOperaciones.Size = new System.Drawing.Size(156, 20);
            this.lblUltimasOperaciones.TabIndex = 8;
            this.lblUltimasOperaciones.Text = "Ultimas Operaciones";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1059, 525);
            this.Controls.Add(this.lblUltimasOperaciones);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.dgvCotizacion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrincipal";
            this.Text = "Casa de cambio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCotizacion;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblUltimasOperaciones;
    }
}