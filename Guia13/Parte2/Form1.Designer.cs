namespace Guia13
{
    partial class Form1
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
            this.AtencionCliente = new System.Windows.Forms.Button();
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.VerResultados = new System.Windows.Forms.Button();
            this.PrepararDist = new System.Windows.Forms.Button();
            this.Textdistri = new System.Windows.Forms.TextBox();
            this.Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // AtencionCliente
            // 
            this.AtencionCliente.Location = new System.Drawing.Point(174, 12);
            this.AtencionCliente.Name = "AtencionCliente";
            this.AtencionCliente.Size = new System.Drawing.Size(156, 63);
            this.AtencionCliente.TabIndex = 0;
            this.AtencionCliente.Text = "Atención Al Cliente";
            this.AtencionCliente.UseVisualStyleBackColor = true;
            // 
            // Gbx
            // 
            this.Gbx.Controls.Add(this.Textdistri);
            this.Gbx.Controls.Add(this.PrepararDist);
            this.Gbx.Controls.Add(this.VerResultados);
            this.Gbx.Location = new System.Drawing.Point(12, 99);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(318, 183);
            this.Gbx.TabIndex = 1;
            this.Gbx.TabStop = false;
            this.Gbx.Text = "Por Empresas de distribución";
            // 
            // VerResultados
            // 
            this.VerResultados.Location = new System.Drawing.Point(162, 19);
            this.VerResultados.Name = "VerResultados";
            this.VerResultados.Size = new System.Drawing.Size(150, 62);
            this.VerResultados.TabIndex = 0;
            this.VerResultados.Text = "Ver Resultado";
            this.VerResultados.UseVisualStyleBackColor = true;
            // 
            // PrepararDist
            // 
            this.PrepararDist.Location = new System.Drawing.Point(162, 103);
            this.PrepararDist.Name = "PrepararDist";
            this.PrepararDist.Size = new System.Drawing.Size(150, 61);
            this.PrepararDist.TabIndex = 1;
            this.PrepararDist.Text = "Preparar Distribución";
            this.PrepararDist.UseVisualStyleBackColor = true;
            // 
            // Textdistri
            // 
            this.Textdistri.Location = new System.Drawing.Point(6, 41);
            this.Textdistri.Name = "Textdistri";
            this.Textdistri.Size = new System.Drawing.Size(129, 20);
            this.Textdistri.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 320);
            this.Controls.Add(this.Gbx);
            this.Controls.Add(this.AtencionCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gbx.ResumeLayout(false);
            this.Gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gbx;
        public System.Windows.Forms.Button AtencionCliente;
        public System.Windows.Forms.Button VerResultados;
        public System.Windows.Forms.Button PrepararDist;
        public System.Windows.Forms.TextBox Textdistri;
    }
}

