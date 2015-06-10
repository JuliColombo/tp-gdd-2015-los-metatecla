namespace PagoElectronico.ABM_Cliente
{
    partial class AltaTarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.boxCodSeguridad = new System.Windows.Forms.TextBox();
            this.comboBoxEmisores = new System.Windows.Forms.ComboBox();
            this.boxFechaEmision = new System.Windows.Forms.MaskedTextBox();
            this.boxFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labelErrorNro = new System.Windows.Forms.Label();
            this.labelErrorCod = new System.Windows.Forms.Label();
            this.labelErrorEmisor = new System.Windows.Forms.Label();
            this.labelErrorFEmision = new System.Windows.Forms.Label();
            this.labelErrorFVenc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Tarjeta";
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(146, 20);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(100, 20);
            this.boxNumero.TabIndex = 1;
            this.boxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNumero_KeyPress);
            // 
            // boxCodSeguridad
            // 
            this.boxCodSeguridad.Location = new System.Drawing.Point(146, 62);
            this.boxCodSeguridad.Name = "boxCodSeguridad";
            this.boxCodSeguridad.Size = new System.Drawing.Size(100, 20);
            this.boxCodSeguridad.TabIndex = 2;
            this.boxCodSeguridad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.boxCodSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCodSeguridad_KeyPress);
            // 
            // comboBoxEmisores
            // 
            this.comboBoxEmisores.FormattingEnabled = true;
            this.comboBoxEmisores.Location = new System.Drawing.Point(146, 104);
            this.comboBoxEmisores.Name = "comboBoxEmisores";
            this.comboBoxEmisores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmisores.TabIndex = 3;
            // 
            // boxFechaEmision
            // 
            this.boxFechaEmision.Location = new System.Drawing.Point(146, 152);
            this.boxFechaEmision.Mask = "00/00/0000";
            this.boxFechaEmision.Name = "boxFechaEmision";
            this.boxFechaEmision.Size = new System.Drawing.Size(100, 20);
            this.boxFechaEmision.TabIndex = 4;
            this.boxFechaEmision.ValidatingType = typeof(System.DateTime);
            // 
            // boxFechaVencimiento
            // 
            this.boxFechaVencimiento.Location = new System.Drawing.Point(146, 196);
            this.boxFechaVencimiento.Mask = "00/00/0000";
            this.boxFechaVencimiento.Name = "boxFechaVencimiento";
            this.boxFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.boxFechaVencimiento.TabIndex = 5;
            this.boxFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código de seguridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Emisor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de emisión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de vencimiento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(213, 247);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // labelErrorNro
            // 
            this.labelErrorNro.AutoSize = true;
            this.labelErrorNro.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNro.Location = new System.Drawing.Point(282, 23);
            this.labelErrorNro.Name = "labelErrorNro";
            this.labelErrorNro.Size = new System.Drawing.Size(151, 13);
            this.labelErrorNro.TabIndex = 12;
            this.labelErrorNro.Text = "Falta especificar Nro de tarjeta";
            this.labelErrorNro.Visible = false;
            // 
            // labelErrorCod
            // 
            this.labelErrorCod.AutoSize = true;
            this.labelErrorCod.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCod.Location = new System.Drawing.Point(282, 65);
            this.labelErrorCod.Name = "labelErrorCod";
            this.labelErrorCod.Size = new System.Drawing.Size(184, 13);
            this.labelErrorCod.TabIndex = 13;
            this.labelErrorCod.Text = "Falta especificar Código de seguridad";
            this.labelErrorCod.Visible = false;
            // 
            // labelErrorEmisor
            // 
            this.labelErrorEmisor.AutoSize = true;
            this.labelErrorEmisor.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEmisor.Location = new System.Drawing.Point(282, 107);
            this.labelErrorEmisor.Name = "labelErrorEmisor";
            this.labelErrorEmisor.Size = new System.Drawing.Size(118, 13);
            this.labelErrorEmisor.TabIndex = 14;
            this.labelErrorEmisor.Text = "Falta especificar Emisor";
            this.labelErrorEmisor.Visible = false;
            // 
            // labelErrorFEmision
            // 
            this.labelErrorFEmision.AutoSize = true;
            this.labelErrorFEmision.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFEmision.Location = new System.Drawing.Point(282, 155);
            this.labelErrorFEmision.Name = "labelErrorFEmision";
            this.labelErrorFEmision.Size = new System.Drawing.Size(170, 13);
            this.labelErrorFEmision.TabIndex = 15;
            this.labelErrorFEmision.Text = "Falta especificar Fecha de emisión";
            this.labelErrorFEmision.Visible = false;
            // 
            // labelErrorFVenc
            // 
            this.labelErrorFVenc.AutoSize = true;
            this.labelErrorFVenc.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFVenc.Location = new System.Drawing.Point(282, 199);
            this.labelErrorFVenc.Name = "labelErrorFVenc";
            this.labelErrorFVenc.Size = new System.Drawing.Size(192, 13);
            this.labelErrorFVenc.TabIndex = 16;
            this.labelErrorFVenc.Text = "Falta especificar Fecha de vencimiento";
            this.labelErrorFVenc.Visible = false;
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 287);
            this.Controls.Add(this.labelErrorFVenc);
            this.Controls.Add(this.labelErrorFEmision);
            this.Controls.Add(this.labelErrorEmisor);
            this.Controls.Add(this.labelErrorCod);
            this.Controls.Add(this.labelErrorNro);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFechaVencimiento);
            this.Controls.Add(this.boxFechaEmision);
            this.Controls.Add(this.comboBoxEmisores);
            this.Controls.Add(this.boxCodSeguridad);
            this.Controls.Add(this.boxNumero);
            this.Controls.Add(this.label1);
            this.Name = "AltaTarjeta";
            this.Text = "AltaTarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.TextBox boxCodSeguridad;
        private System.Windows.Forms.ComboBox comboBoxEmisores;
        private System.Windows.Forms.MaskedTextBox boxFechaEmision;
        private System.Windows.Forms.MaskedTextBox boxFechaVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labelErrorNro;
        private System.Windows.Forms.Label labelErrorCod;
        private System.Windows.Forms.Label labelErrorEmisor;
        private System.Windows.Forms.Label labelErrorFEmision;
        private System.Windows.Forms.Label labelErrorFVenc;
    }
}