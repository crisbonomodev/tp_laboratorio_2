namespace KwikEMart
{
    partial class FormEnvios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnvios));
            this.dgvRetiraEnLocal = new System.Windows.Forms.DataGridView();
            this.dgvEnviosADomicilio = new System.Windows.Forms.DataGridView();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiraEnLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosADomicilio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRetiraEnLocal
            // 
            this.dgvRetiraEnLocal.AllowUserToAddRows = false;
            this.dgvRetiraEnLocal.AllowUserToDeleteRows = false;
            this.dgvRetiraEnLocal.AllowUserToResizeColumns = false;
            this.dgvRetiraEnLocal.AllowUserToResizeRows = false;
            this.dgvRetiraEnLocal.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgvRetiraEnLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetiraEnLocal.Location = new System.Drawing.Point(12, 258);
            this.dgvRetiraEnLocal.Name = "dgvRetiraEnLocal";
            this.dgvRetiraEnLocal.ReadOnly = true;
            this.dgvRetiraEnLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRetiraEnLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRetiraEnLocal.Size = new System.Drawing.Size(776, 180);
            this.dgvRetiraEnLocal.TabIndex = 0;
            // 
            // dgvEnviosADomicilio
            // 
            this.dgvEnviosADomicilio.AllowUserToAddRows = false;
            this.dgvEnviosADomicilio.AllowUserToDeleteRows = false;
            this.dgvEnviosADomicilio.AllowUserToResizeColumns = false;
            this.dgvEnviosADomicilio.AllowUserToResizeRows = false;
            this.dgvEnviosADomicilio.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.dgvEnviosADomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnviosADomicilio.Location = new System.Drawing.Point(12, 45);
            this.dgvEnviosADomicilio.Name = "dgvEnviosADomicilio";
            this.dgvEnviosADomicilio.ReadOnly = true;
            this.dgvEnviosADomicilio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEnviosADomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnviosADomicilio.Size = new System.Drawing.Size(776, 180);
            this.dgvEnviosADomicilio.TabIndex = 1;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(13, 26);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(96, 13);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.Text = "Envíos a domicilio:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(13, 242);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(95, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "Retiran en el local:";
            // 
            // FormEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.dgvEnviosADomicilio);
            this.Controls.Add(this.dgvRetiraEnLocal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnvios";
            this.Text = "Kwik-E-Mart - Envios";
            this.Load += new System.EventHandler(this.FormEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiraEnLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosADomicilio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRetiraEnLocal;
        private System.Windows.Forms.DataGridView dgvEnviosADomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblLocal;
    }
}