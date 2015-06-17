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
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_pais = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label_tipo = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.maskedTextBox_fecha = new System.Windows.Forms.MaskedTextBox();
            this.labelError_usuario = new System.Windows.Forms.Label();
            this.labelError_nro_cuenta = new System.Windows.Forms.Label();
            this.labelError_fecha = new System.Windows.Forms.Label();
            this.labelError_pais = new System.Windows.Forms.Label();
            this.labelError_tipo = new System.Windows.Forms.Label();
            this.labelError_moneda = new System.Windows.Forms.Label();
            this.comboBox_moneda = new System.Windows.Forms.ComboBox();
            this.label_moneda = new System.Windows.Forms.Label();
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
            this.textBox_nro_cuenta.Location = new System.Drawing.Point(136, 64);
            this.textBox_nro_cuenta.Name = "textBox_nro_cuenta";
            this.textBox_nro_cuenta.Size = new System.Drawing.Size(135, 20);
            this.textBox_nro_cuenta.TabIndex = 3;
            this.textBox_nro_cuenta.TextChanged += new System.EventHandler(this.textBox_nro_cuenta_TextChanged);
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
            this.btn_confirmar.Location = new System.Drawing.Point(162, 271);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(109, 29);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(15, 271);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(109, 29);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // maskedTextBox_fecha
            // 
            this.maskedTextBox_fecha.Location = new System.Drawing.Point(202, 100);
            this.maskedTextBox_fecha.Mask = "00/00/0000";
            this.maskedTextBox_fecha.Name = "maskedTextBox_fecha";
            this.maskedTextBox_fecha.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBox_fecha.TabIndex = 12;
            this.maskedTextBox_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // labelError_usuario
            // 
            this.labelError_usuario.AutoSize = true;
            this.labelError_usuario.ForeColor = System.Drawing.Color.Red;
            this.labelError_usuario.Location = new System.Drawing.Point(278, 30);
            this.labelError_usuario.Name = "labelError_usuario";
            this.labelError_usuario.Size = new System.Drawing.Size(136, 13);
            this.labelError_usuario.TabIndex = 13;
            this.labelError_usuario.Text = "Falta especificar un usuario";
            this.labelError_usuario.Visible = false;
            // 
            // labelError_nro_cuenta
            // 
            this.labelError_nro_cuenta.AutoSize = true;
            this.labelError_nro_cuenta.ForeColor = System.Drawing.Color.Red;
            this.labelError_nro_cuenta.Location = new System.Drawing.Point(278, 71);
            this.labelError_nro_cuenta.Name = "labelError_nro_cuenta";
            this.labelError_nro_cuenta.Size = new System.Drawing.Size(188, 13);
            this.labelError_nro_cuenta.TabIndex = 14;
            this.labelError_nro_cuenta.Text = "Falta especificar un número de cuenta";
            this.labelError_nro_cuenta.Visible = false;
            // 
            // labelError_fecha
            // 
            this.labelError_fecha.AutoSize = true;
            this.labelError_fecha.ForeColor = System.Drawing.Color.Red;
            this.labelError_fecha.Location = new System.Drawing.Point(278, 103);
            this.labelError_fecha.Name = "labelError_fecha";
            this.labelError_fecha.Size = new System.Drawing.Size(135, 13);
            this.labelError_fecha.TabIndex = 15;
            this.labelError_fecha.Text = "Falta especificar una fecha";
            this.labelError_fecha.Visible = false;
            // 
            // labelError_pais
            // 
            this.labelError_pais.AutoSize = true;
            this.labelError_pais.ForeColor = System.Drawing.Color.Red;
            this.labelError_pais.Location = new System.Drawing.Point(278, 149);
            this.labelError_pais.Name = "labelError_pais";
            this.labelError_pais.Size = new System.Drawing.Size(123, 13);
            this.labelError_pais.TabIndex = 16;
            this.labelError_pais.Text = "Falta especificar un país";
            this.labelError_pais.Visible = false;
            // 
            // labelError_tipo
            // 
            this.labelError_tipo.AutoSize = true;
            this.labelError_tipo.ForeColor = System.Drawing.Color.Red;
            this.labelError_tipo.Location = new System.Drawing.Point(278, 187);
            this.labelError_tipo.Name = "labelError_tipo";
            this.labelError_tipo.Size = new System.Drawing.Size(170, 13);
            this.labelError_tipo.TabIndex = 17;
            this.labelError_tipo.Text = "Falta especificar un tipo de cuenta";
            this.labelError_tipo.Visible = false;
            // 
            // labelError_moneda
            // 
            this.labelError_moneda.AutoSize = true;
            this.labelError_moneda.ForeColor = System.Drawing.Color.Red;
            this.labelError_moneda.Location = new System.Drawing.Point(278, 226);
            this.labelError_moneda.Name = "labelError_moneda";
            this.labelError_moneda.Size = new System.Drawing.Size(170, 13);
            this.labelError_moneda.TabIndex = 20;
            this.labelError_moneda.Text = "Falta especificar un tipo de cuenta";
            this.labelError_moneda.Visible = false;
            // 
            // comboBox_moneda
            // 
            this.comboBox_moneda.FormattingEnabled = true;
            this.comboBox_moneda.Location = new System.Drawing.Point(137, 218);
            this.comboBox_moneda.Name = "comboBox_moneda";
            this.comboBox_moneda.Size = new System.Drawing.Size(135, 21);
            this.comboBox_moneda.TabIndex = 19;
            // 
            // label_moneda
            // 
            this.label_moneda.AutoSize = true;
            this.label_moneda.Location = new System.Drawing.Point(12, 221);
            this.label_moneda.Name = "label_moneda";
            this.label_moneda.Size = new System.Drawing.Size(49, 13);
            this.label_moneda.TabIndex = 18;
            this.label_moneda.Text = "Moneda:";
            // 
            // CrearCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 312);
            this.Controls.Add(this.labelError_moneda);
            this.Controls.Add(this.comboBox_moneda);
            this.Controls.Add(this.label_moneda);
            this.Controls.Add(this.labelError_tipo);
            this.Controls.Add(this.labelError_pais);
            this.Controls.Add(this.labelError_fecha);
            this.Controls.Add(this.labelError_nro_cuenta);
            this.Controls.Add(this.labelError_usuario);
            this.Controls.Add(this.maskedTextBox_fecha);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.label_pais);
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
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_pais;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fecha;
        private System.Windows.Forms.Label labelError_usuario;
        private System.Windows.Forms.Label labelError_nro_cuenta;
        private System.Windows.Forms.Label labelError_fecha;
        private System.Windows.Forms.Label labelError_pais;
        private System.Windows.Forms.Label labelError_tipo;
        private System.Windows.Forms.Label labelError_moneda;
        private System.Windows.Forms.ComboBox comboBox_moneda;
        private System.Windows.Forms.Label label_moneda;
    }
}