namespace PagoElectronico.ABM_Cuenta
{
    partial class CrearCuentaForm
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
            this.label_usuario = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_nro_cuenta = new System.Windows.Forms.TextBox();
            this.label_nro_cuenta = new System.Windows.Forms.Label();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_pais = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label_tipo = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(12, 27);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(46, 13);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "Usuario:";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(137, 27);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(135, 20);
            this.textBox_usuario.TabIndex = 1;
            // 
            // textBox_nro_cuenta
            // 
            this.textBox_nro_cuenta.Location = new System.Drawing.Point(137, 64);
            this.textBox_nro_cuenta.Name = "textBox_nro_cuenta";
            this.textBox_nro_cuenta.Size = new System.Drawing.Size(135, 20);
            this.textBox_nro_cuenta.TabIndex = 3;
            // 
            // label_nro_cuenta
            // 
            this.label_nro_cuenta.AutoSize = true;
            this.label_nro_cuenta.Location = new System.Drawing.Point(12, 67);
            this.label_nro_cuenta.Name = "label_nro_cuenta";
            this.label_nro_cuenta.Size = new System.Drawing.Size(101, 13);
            this.label_nro_cuenta.TabIndex = 2;
            this.label_nro_cuenta.Text = "Número de cuenta: ";
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Location = new System.Drawing.Point(137, 100);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(135, 20);
            this.textBox_fecha.TabIndex = 5;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(12, 103);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(85, 13);
            this.label_fecha.TabIndex = 4;
            this.label_fecha.Text = "Fecha apertura: ";
            // 
            // label_pais
            // 
            this.label_pais.AutoSize = true;
            this.label_pais.Location = new System.Drawing.Point(12, 144);
            this.label_pais.Name = "label_pais";
            this.label_pais.Size = new System.Drawing.Size(30, 13);
            this.label_pais.TabIndex = 6;
            this.label_pais.Text = "Pais:";
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(137, 141);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(135, 21);
            this.comboBoxPais.TabIndex = 7;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(137, 179);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(135, 21);
            this.comboBox_tipo.TabIndex = 9;
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Location = new System.Drawing.Point(12, 182);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(31, 13);
            this.label_tipo.TabIndex = 8;
            this.label_tipo.Text = "Tipo:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(162, 222);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(109, 29);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Crear";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(15, 222);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(109, 29);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // CrearCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.label_pais);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.textBox_nro_cuenta);
            this.Controls.Add(this.label_nro_cuenta);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label_usuario);
            this.Name = "CrearCuentaForm";
            this.Text = "Crear Cuenta";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_nro_cuenta;
        private System.Windows.Forms.Label label_nro_cuenta;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_pais;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_limpiar;
    }
}