namespace Guia13
{
    partial class FormDespacho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chbcertificada = new System.Windows.Forms.CheckBox();
            this.NumEmp = new System.Windows.Forms.ComboBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textpostal = new System.Windows.Forms.TextBox();
            this.NumEmpresas = new System.Windows.Forms.Label();
            this.Pesosgramos = new System.Windows.Forms.Label();
            this.Codigopostal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chbcertificada);
            this.groupBox1.Controls.Add(this.NumEmp);
            this.groupBox1.Controls.Add(this.textPeso);
            this.groupBox1.Controls.Add(this.textpostal);
            this.groupBox1.Controls.Add(this.NumEmpresas);
            this.groupBox1.Controls.Add(this.Pesosgramos);
            this.groupBox1.Controls.Add(this.Codigopostal);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Chbcertificada
            // 
            this.Chbcertificada.AutoSize = true;
            this.Chbcertificada.Location = new System.Drawing.Point(170, 156);
            this.Chbcertificada.Name = "Chbcertificada";
            this.Chbcertificada.Size = new System.Drawing.Size(100, 17);
            this.Chbcertificada.TabIndex = 7;
            this.Chbcertificada.Text = "Es Certificada ?";
            this.Chbcertificada.UseVisualStyleBackColor = true;
            // 
            // NumEmp
            // 
            this.NumEmp.FormattingEnabled = true;
            this.NumEmp.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.NumEmp.Location = new System.Drawing.Point(170, 115);
            this.NumEmp.Name = "NumEmp";
            this.NumEmp.Size = new System.Drawing.Size(121, 21);
            this.NumEmp.TabIndex = 6;
            this.NumEmp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(170, 77);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(121, 20);
            this.textPeso.TabIndex = 5;
            // 
            // textpostal
            // 
            this.textpostal.Location = new System.Drawing.Point(170, 40);
            this.textpostal.Name = "textpostal";
            this.textpostal.Size = new System.Drawing.Size(121, 20);
            this.textpostal.TabIndex = 4;
            // 
            // NumEmpresas
            // 
            this.NumEmpresas.AutoSize = true;
            this.NumEmpresas.Location = new System.Drawing.Point(21, 118);
            this.NumEmpresas.Name = "NumEmpresas";
            this.NumEmpresas.Size = new System.Drawing.Size(88, 13);
            this.NumEmpresas.TabIndex = 3;
            this.NumEmpresas.Text = "Número Empresa";
            // 
            // Pesosgramos
            // 
            this.Pesosgramos.AutoSize = true;
            this.Pesosgramos.Location = new System.Drawing.Point(21, 84);
            this.Pesosgramos.Name = "Pesosgramos";
            this.Pesosgramos.Size = new System.Drawing.Size(86, 13);
            this.Pesosgramos.TabIndex = 2;
            this.Pesosgramos.Text = "Peso en gramos ";
            // 
            // Codigopostal
            // 
            this.Codigopostal.AutoSize = true;
            this.Codigopostal.Location = new System.Drawing.Point(21, 47);
            this.Codigopostal.Name = "Codigopostal";
            this.Codigopostal.Size = new System.Drawing.Size(72, 13);
            this.Codigopostal.TabIndex = 1;
            this.Codigopostal.Text = "Codigo Postal";
            this.Codigopostal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(84, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(219, 225);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // FormDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 260);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDespacho";
            this.Text = "FormDespacho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label Codigopostal;
        public System.Windows.Forms.Label Pesosgramos;
        public System.Windows.Forms.TextBox textpostal;
        public System.Windows.Forms.Label NumEmpresas;
        public System.Windows.Forms.TextBox textPeso;
        public System.Windows.Forms.ComboBox NumEmp;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox Chbcertificada;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btncancelar;
    }
}