namespace FelipeHoyos
{
    partial class frmImportar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(79, 47);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(303, 20);
            this.txtRutaArchivo.TabIndex = 0;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(38, 50);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Ruta:";
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(388, 45);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(29, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "...";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 210);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRutaArchivo);
            this.Name = "frmImportar";
            this.Text = "Pesebrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.Button btnCargar;
    }
}

