namespace PagoElectronico.Transferencias
{
    partial class TransferenciaForm
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
            this.labelDest = new System.Windows.Forms.Label();
            this.labelOri = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMonedas = new System.Windows.Forms.ComboBox();
            this.butonTrans = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.butonCacelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe:";
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(12, 32);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(83, 13);
            this.labelDest.TabIndex = 1;
            this.labelDest.Text = "Cuenta Destino:";
            // 
            // labelOri
            // 
            this.labelOri.AutoSize = true;
            this.labelOri.Location = new System.Drawing.Point(12, 9);
            this.labelOri.Name = "labelOri";
            this.labelOri.Size = new System.Drawing.Size(78, 13);
            this.labelOri.TabIndex = 2;
            this.labelOri.Text = "Cuenta Origen:";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(101, 9);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(35, 13);
            this.labelOrigen.TabIndex = 3;
            this.labelOrigen.Text = "label2";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(101, 32);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(35, 13);
            this.labelDestino.TabIndex = 4;
            this.labelDestino.Text = "label3";
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(104, 52);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(97, 20);
            this.textImporte.TabIndex = 5;
            this.textImporte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textImporte_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moneda:";
            // 
            // comboMonedas
            // 
            this.comboMonedas.FormattingEnabled = true;
            this.comboMonedas.Location = new System.Drawing.Point(104, 78);
            this.comboMonedas.Name = "comboMonedas";
            this.comboMonedas.Size = new System.Drawing.Size(97, 21);
            this.comboMonedas.TabIndex = 7;
            this.comboMonedas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboMonedas_KeyPress);
            // 
            // butonTrans
            // 
            this.butonTrans.Location = new System.Drawing.Point(132, 144);
            this.butonTrans.Name = "butonTrans";
            this.butonTrans.Size = new System.Drawing.Size(69, 24);
            this.butonTrans.TabIndex = 8;
            this.butonTrans.Text = "Transferir";
            this.butonTrans.UseVisualStyleBackColor = true;
            this.butonTrans.Click += new System.EventHandler(this.butonTrans_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Costo por \r\nTransferencia:";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(101, 120);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(35, 13);
            this.labelCosto.TabIndex = 10;
            this.labelCosto.Text = "label4";
            // 
            // butonCacelar
            // 
            this.butonCacelar.Location = new System.Drawing.Point(57, 144);
            this.butonCacelar.Name = "butonCacelar";
            this.butonCacelar.Size = new System.Drawing.Size(69, 24);
            this.butonCacelar.TabIndex = 11;
            this.butonCacelar.Text = "Cancelar";
            this.butonCacelar.UseVisualStyleBackColor = true;
            this.butonCacelar.Click += new System.EventHandler(this.butonCacelar_Click);
            // 
            // TransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 180);
            this.Controls.Add(this.butonCacelar);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butonTrans);
            this.Controls.Add(this.comboMonedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.labelOri);
            this.Controls.Add(this.labelDest);
            this.Controls.Add(this.label1);
            this.Name = "TransferenciaForm";
            this.Text = "Transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.Label labelOri;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMonedas;
        private System.Windows.Forms.Button butonTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Button butonCacelar;
    }
}