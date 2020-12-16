namespace Op
{
    partial class Form1
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHsTrabajadas = new System.Windows.Forms.TextBox();
            this.txtPrecioHora = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblSueldos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCantOficiales = new System.Windows.Forms.Label();
            this.lblCantCapataces = new System.Windows.Forms.Label();
            this.lblTotalSueldos = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(92, 32);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtHsTrabajadas
            // 
            this.txtHsTrabajadas.Location = new System.Drawing.Point(92, 111);
            this.txtHsTrabajadas.Name = "txtHsTrabajadas";
            this.txtHsTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHsTrabajadas.TabIndex = 2;
            // 
            // txtPrecioHora
            // 
            this.txtPrecioHora.Location = new System.Drawing.Point(92, 137);
            this.txtPrecioHora.Name = "txtPrecioHora";
            this.txtPrecioHora.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioHora.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "1_Oficial",
            "2_Capataz",
            "3_Otro"});
            this.cboCategoria.Location = new System.Drawing.Point(92, 84);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(100, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(223, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(316, 182);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(78, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblSueldos
            // 
            this.lblSueldos.AutoSize = true;
            this.lblSueldos.Location = new System.Drawing.Point(238, 35);
            this.lblSueldos.Name = "lblSueldos";
            this.lblSueldos.Size = new System.Drawing.Size(40, 13);
            this.lblSueldos.TabIndex = 7;
            this.lblSueldos.Text = "Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cant.Capataces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Sueldos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hs Trabajadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cant.Oficiales";
            // 
            // lblCantOficiales
            // 
            this.lblCantOficiales.AutoSize = true;
            this.lblCantOficiales.Location = new System.Drawing.Point(293, 118);
            this.lblCantOficiales.Name = "lblCantOficiales";
            this.lblCantOficiales.Size = new System.Drawing.Size(13, 13);
            this.lblCantOficiales.TabIndex = 16;
            this.lblCantOficiales.Text = "0";
            // 
            // lblCantCapataces
            // 
            this.lblCantCapataces.AutoSize = true;
            this.lblCantCapataces.Location = new System.Drawing.Point(293, 92);
            this.lblCantCapataces.Name = "lblCantCapataces";
            this.lblCantCapataces.Size = new System.Drawing.Size(13, 13);
            this.lblCantCapataces.TabIndex = 17;
            this.lblCantCapataces.Text = "0";
            // 
            // lblTotalSueldos
            // 
            this.lblTotalSueldos.AutoSize = true;
            this.lblTotalSueldos.Location = new System.Drawing.Point(293, 65);
            this.lblTotalSueldos.Name = "lblTotalSueldos";
            this.lblTotalSueldos.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSueldos.TabIndex = 18;
            this.lblTotalSueldos.Text = "0";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(293, 35);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(13, 13);
            this.lblSueldo.TabIndex = 19;
            this.lblSueldo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblTotalSueldos);
            this.Controls.Add(this.lblCantCapataces);
            this.Controls.Add(this.lblCantOficiales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSueldos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtPrecioHora);
            this.Controls.Add(this.txtHsTrabajadas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHsTrabajadas;
        private System.Windows.Forms.TextBox txtPrecioHora;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblSueldos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCantOficiales;
        private System.Windows.Forms.Label lblCantCapataces;
        private System.Windows.Forms.Label lblTotalSueldos;
        private System.Windows.Forms.Label lblSueldo;
    }
}

