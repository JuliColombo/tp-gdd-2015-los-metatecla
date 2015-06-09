namespace PagoElectronico.Depositos
{
    partial class DatosDepositoForm
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
            this.btn_depositar = new System.Windows.Forms.Button();
            this.label_cta = new System.Windows.Forms.Label();
            this.comboBox_cuenta = new System.Windows.Forms.ComboBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_documento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.comboBox_tarjeta = new System.Windows.Forms.ComboBox();
            this.label_tarjeta = new System.Windows.Forms.Label();
            this.labelError_cuenta = new System.Windows.Forms.Label();
            this.labelError_tarjeta = new System.Windows.Forms.Label();
            this.comboBox_moneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError_moneda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_importe = new System.Windows.Forms.TextBox();
            this.labelError_importe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_depositar
            // 
            this.btn_depositar.Location = new System.Drawing.Point(184, 363);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(88, 30);
            this.btn_depositar.TabIndex = 0;
            this.btn_depositar.Text = "Depositar";
            this.btn_depositar.UseVisualStyleBackColor = true;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // label_cta
            // 
            this.label_cta.AutoSize = true;
            this.label_cta.Location = new System.Drawing.Point(28, 98);
            this.label_cta.Name = "label_cta";
            this.label_cta.Size = new System.Drawing.Size(99, 13);
            this.label_cta.TabIndex = 1;
            this.label_cta.Text = "Número de Cuenta:";
            // 
            // comboBox_cuenta
            // 
            this.comboBox_cuenta.FormattingEnabled = true;
            this.comboBox_cuenta.Location = new System.Drawing.Point(133, 95);
            this.comboBox_cuenta.Name = "comboBox_cuenta";
            this.comboBox_cuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cuenta.TabIndex = 2;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(155, 13);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(70, 13);
            this.label_nombre.TabIndex = 3;
            this.label_nombre.Text = "label_nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(155, 37);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(71, 13);
            this.label_apellido.TabIndex = 4;
            this.label_apellido.Text = "label_apellido";
            // 
            // label_documento
            // 
            this.label_documento.AutoSize = true;
            this.label_documento.Location = new System.Drawing.Point(155, 61);
            this.label_documento.Name = "label_documento";
            this.label_documento.Size = new System.Drawing.Size(88, 13);
            this.label_documento.TabIndex = 5;
            this.label_documento.Text = "label_documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(26, 13);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(47, 13);
            this.label_nom.TabIndex = 6;
            this.label_nom.Text = "Nombre:";
            // 
            // comboBox_tarjeta
            // 
            this.comboBox_tarjeta.FormattingEnabled = true;
            this.comboBox_tarjeta.Location = new System.Drawing.Point(133, 152);
            this.comboBox_tarjeta.Name = "comboBox_tarjeta";
            this.comboBox_tarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tarjeta.TabIndex = 10;
            // 
            // label_tarjeta
            // 
            this.label_tarjeta.AutoSize = true;
            this.label_tarjeta.Location = new System.Drawing.Point(28, 155);
            this.label_tarjeta.Name = "label_tarjeta";
            this.label_tarjeta.Size = new System.Drawing.Size(98, 13);
            this.label_tarjeta.TabIndex = 9;
            this.label_tarjeta.Text = "Número de Tarjeta:";
            // 
            // labelError_cuenta
            // 
            this.labelError_cuenta.AutoSize = true;
            this.labelError_cuenta.ForeColor = System.Drawing.Color.Red;
            this.labelError_cuenta.Location = new System.Drawing.Point(31, 126);
            this.labelError_cuenta.Name = "labelError_cuenta";
            this.labelError_cuenta.Size = new System.Drawing.Size(188, 13);
            this.labelError_cuenta.TabIndex = 11;
            this.labelError_cuenta.Text = "Falta especificar un número de cuenta";
            this.labelError_cuenta.Visible = false;
            // 
            // labelError_tarjeta
            // 
            this.labelError_tarjeta.AutoSize = true;
            this.labelError_tarjeta.ForeColor = System.Drawing.Color.Red;
            this.labelError_tarjeta.Location = new System.Drawing.Point(31, 186);
            this.labelError_tarjeta.Name = "labelError_tarjeta";
            this.labelError_tarjeta.Size = new System.Drawing.Size(234, 13);
            this.labelError_tarjeta.TabIndex = 12;
            this.labelError_tarjeta.Text = "Falta especificar un número de tarjeta de crédito";
            this.labelError_tarjeta.Visible = false;
            // 
            // comboBox_moneda
            // 
            this.comboBox_moneda.FormattingEnabled = true;
            this.comboBox_moneda.Location = new System.Drawing.Point(85, 216);
            this.comboBox_moneda.Name = "comboBox_moneda";
            this.comboBox_moneda.Size = new System.Drawing.Size(121, 21);
            this.comboBox_moneda.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Moneda:";
            // 
            // labelError_moneda
            // 
            this.labelError_moneda.AutoSize = true;
            this.labelError_moneda.ForeColor = System.Drawing.Color.Red;
            this.labelError_moneda.Location = new System.Drawing.Point(29, 251);
            this.labelError_moneda.Name = "labelError_moneda";
            this.labelError_moneda.Size = new System.Drawing.Size(146, 13);
            this.labelError_moneda.TabIndex = 15;
            this.labelError_moneda.Text = "Falta especificar una moneda";
            this.labelError_moneda.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Importe:";
            // 
            // textBox_importe
            // 
            this.textBox_importe.Location = new System.Drawing.Point(85, 288);
            this.textBox_importe.Name = "textBox_importe";
            this.textBox_importe.Size = new System.Drawing.Size(117, 20);
            this.textBox_importe.TabIndex = 17;
            // 
            // labelError_importe
            // 
            this.labelError_importe.AutoSize = true;
            this.labelError_importe.ForeColor = System.Drawing.Color.Red;
            this.labelError_importe.Location = new System.Drawing.Point(31, 322);
            this.labelError_importe.Name = "labelError_importe";
            this.labelError_importe.Size = new System.Drawing.Size(146, 13);
            this.labelError_importe.TabIndex = 18;
            this.labelError_importe.Text = "Falta especificar una moneda";
            this.labelError_importe.Visible = false;
            // 
            // DatosDepositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 405);
            this.Controls.Add(this.labelError_importe);
            this.Controls.Add(this.textBox_importe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelError_moneda);
            this.Controls.Add(this.comboBox_moneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelError_tarjeta);
            this.Controls.Add(this.labelError_cuenta);
            this.Controls.Add(this.comboBox_tarjeta);
            this.Controls.Add(this.label_tarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_documento);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.comboBox_cuenta);
            this.Controls.Add(this.label_cta);
            this.Controls.Add(this.btn_depositar);
            this.Name = "DatosDepositoForm";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_depositar;
        private System.Windows.Forms.Label label_cta;
        private System.Windows.Forms.ComboBox comboBox_cuenta;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.ComboBox comboBox_tarjeta;
        private System.Windows.Forms.Label label_tarjeta;
        private System.Windows.Forms.Label labelError_cuenta;
        private System.Windows.Forms.Label labelError_tarjeta;
        private System.Windows.Forms.ComboBox comboBox_moneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError_moneda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_importe;
        private System.Windows.Forms.Label labelError_importe;
    }
}