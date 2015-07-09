namespace PagoElectronico.Facturacion
{
    partial class FacturacionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.textSuscrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataFactura = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bontonCancelar = new System.Windows.Forms.Button();
            this.botonFactura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuentas:";
            // 
            // comboCuentas
            // 
            this.comboCuentas.FormattingEnabled = true;
            this.comboCuentas.Location = new System.Drawing.Point(98, 22);
            this.comboCuentas.Name = "comboCuentas";
            this.comboCuentas.Size = new System.Drawing.Size(127, 21);
            this.comboCuentas.TabIndex = 1;
            this.comboCuentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCuentas_KeyPress);
            this.comboCuentas.SelectedValueChanged += new System.EventHandler(this.comboCuentas_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCosto);
            this.groupBox1.Controls.Add(this.labelTipo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botonAgregar);
            this.groupBox1.Controls.Add(this.textSuscrip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboCuentas);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suscripcion";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(95, 106);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(35, 13);
            this.labelCosto.TabIndex = 8;
            this.labelCosto.Text = "label7";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(95, 83);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(35, 13);
            this.labelTipo.TabIndex = 7;
            this.labelTipo.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo:";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(156, 130);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 4;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // textSuscrip
            // 
            this.textSuscrip.Location = new System.Drawing.Point(98, 51);
            this.textSuscrip.Name = "textSuscrip";
            this.textSuscrip.Size = new System.Drawing.Size(127, 20);
            this.textSuscrip.TabIndex = 3;
            this.textSuscrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSuscrip_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suscripciones:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataFactura);
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura Actual";
            // 
            // dataFactura
            // 
            this.dataFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFactura.Location = new System.Drawing.Point(3, 16);
            this.dataFactura.Name = "dataFactura";
            this.dataFactura.Size = new System.Drawing.Size(452, 188);
            this.dataFactura.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "AVISO: La cantidad de dias de la suscripcion \r\ndepende del tipo de cuenta.\r\nEl co" +
                "sto de apertura cuenta como una\r\nsuscripcion.";
            // 
            // bontonCancelar
            // 
            this.bontonCancelar.Location = new System.Drawing.Point(641, 228);
            this.bontonCancelar.Name = "bontonCancelar";
            this.bontonCancelar.Size = new System.Drawing.Size(81, 23);
            this.bontonCancelar.TabIndex = 5;
            this.bontonCancelar.Text = "Cancelar";
            this.bontonCancelar.UseVisualStyleBackColor = true;
            this.bontonCancelar.Click += new System.EventHandler(this.bontonCancelar_Click);
            // 
            // botonFactura
            // 
            this.botonFactura.Location = new System.Drawing.Point(526, 228);
            this.botonFactura.Name = "botonFactura";
            this.botonFactura.Size = new System.Drawing.Size(109, 23);
            this.botonFactura.TabIndex = 6;
            this.botonFactura.Text = "Generar Factura";
            this.botonFactura.UseVisualStyleBackColor = true;
            this.botonFactura.Click += new System.EventHandler(this.botonFactura_Click);
            // 
            // FacturacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 261);
            this.Controls.Add(this.botonFactura);
            this.Controls.Add(this.bontonCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FacturacionForm";
            this.Text = "Facturacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCuentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSuscrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataFactura;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button bontonCancelar;
        private System.Windows.Forms.Button botonFactura;
    }
}