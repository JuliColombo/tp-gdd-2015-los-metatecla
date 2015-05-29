namespace PagoElectronico.Depositos
{
    partial class DepositoForm
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
            this.comboCuentas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoMoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTarjeta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta:";
            // 
            // comboCuentas
            // 
            this.comboCuentas.FormattingEnabled = true;
            this.comboCuentas.Location = new System.Drawing.Point(137, 24);
            this.comboCuentas.Name = "comboCuentas";
            this.comboCuentas.Size = new System.Drawing.Size(224, 21);
            this.comboCuentas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe:";
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(137, 77);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(223, 20);
            this.textImporte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Moneda:";
            // 
            // comboTipoMoneda
            // 
            this.comboTipoMoneda.FormattingEnabled = true;
            this.comboTipoMoneda.Location = new System.Drawing.Point(137, 127);
            this.comboTipoMoneda.Name = "comboTipoMoneda";
            this.comboTipoMoneda.Size = new System.Drawing.Size(222, 21);
            this.comboTipoMoneda.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarjeta De Credito:";
            // 
            // comboTarjeta
            // 
            this.comboTarjeta.FormattingEnabled = true;
            this.comboTarjeta.Location = new System.Drawing.Point(137, 171);
            this.comboTarjeta.Name = "comboTarjeta";
            this.comboTarjeta.Size = new System.Drawing.Size(222, 21);
            this.comboTarjeta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(134, 220);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(35, 13);
            this.labelFecha.TabIndex = 9;
            this.labelFecha.Text = "label6";
            // 
            // DepositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipoMoneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCuentas);
            this.Controls.Add(this.label1);
            this.Name = "DepositoForm";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipoMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFecha;
    }
}