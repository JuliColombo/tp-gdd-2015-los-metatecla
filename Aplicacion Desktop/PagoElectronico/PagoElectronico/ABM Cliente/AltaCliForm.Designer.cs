namespace PagoElectronico.ABM_Cliente
{
    partial class AltaCliForm
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
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxApellido = new System.Windows.Forms.TextBox();
            this.boxDocumento = new System.Windows.Forms.TextBox();
            this.boxMail = new System.Windows.Forms.TextBox();
            this.boxCalle = new System.Windows.Forms.TextBox();
            this.boxAltura = new System.Windows.Forms.TextBox();
            this.boxPiso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.boxDepto = new System.Windows.Forms.TextBox();
            this.boxPais = new System.Windows.Forms.TextBox();
            this.boxFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(155, 12);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(100, 20);
            this.boxNombre.TabIndex = 0;
            this.boxNombre.TextChanged += new System.EventHandler(this.boxNombre_TextChanged);
            // 
            // boxApellido
            // 
            this.boxApellido.Location = new System.Drawing.Point(155, 38);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Size = new System.Drawing.Size(100, 20);
            this.boxApellido.TabIndex = 1;
            // 
            // boxDocumento
            // 
            this.boxDocumento.Location = new System.Drawing.Point(155, 91);
            this.boxDocumento.Name = "boxDocumento";
            this.boxDocumento.Size = new System.Drawing.Size(100, 20);
            this.boxDocumento.TabIndex = 2;
            // 
            // boxMail
            // 
            this.boxMail.Location = new System.Drawing.Point(155, 117);
            this.boxMail.Name = "boxMail";
            this.boxMail.Size = new System.Drawing.Size(100, 20);
            this.boxMail.TabIndex = 3;
            // 
            // boxCalle
            // 
            this.boxCalle.Location = new System.Drawing.Point(155, 143);
            this.boxCalle.Name = "boxCalle";
            this.boxCalle.Size = new System.Drawing.Size(100, 20);
            this.boxCalle.TabIndex = 4;
            // 
            // boxAltura
            // 
            this.boxAltura.Location = new System.Drawing.Point(155, 170);
            this.boxAltura.Name = "boxAltura";
            this.boxAltura.Size = new System.Drawing.Size(100, 20);
            this.boxAltura.TabIndex = 5;
            // 
            // boxPiso
            // 
            this.boxPiso.Location = new System.Drawing.Point(155, 197);
            this.boxPiso.Name = "boxPiso";
            this.boxPiso.Size = new System.Drawing.Size(100, 20);
            this.boxPiso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre*";
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "Pasaporte"});
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(155, 64);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDoc.TabIndex = 8;
            // 
            // boxDepto
            // 
            this.boxDepto.Location = new System.Drawing.Point(155, 224);
            this.boxDepto.Name = "boxDepto";
            this.boxDepto.Size = new System.Drawing.Size(100, 20);
            this.boxDepto.TabIndex = 9;
            // 
            // boxPais
            // 
            this.boxPais.Location = new System.Drawing.Point(155, 251);
            this.boxPais.Name = "boxPais";
            this.boxPais.Size = new System.Drawing.Size(100, 20);
            this.boxPais.TabIndex = 10;
            // 
            // boxFecha
            // 
            this.boxFecha.Location = new System.Drawing.Point(155, 278);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(100, 20);
            this.boxFecha.TabIndex = 11;
            this.boxFecha.TextChanged += new System.EventHandler(this.boxFecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de documento*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nro de documento*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Altura*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Calle*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Piso*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Depto*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Pais*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha de nacimiento";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(180, 308);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 22;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "* Campos obligatorios";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(39, 308);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 24;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // AltaCliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 363);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFecha);
            this.Controls.Add(this.boxPais);
            this.Controls.Add(this.boxDepto);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPiso);
            this.Controls.Add(this.boxAltura);
            this.Controls.Add(this.boxCalle);
            this.Controls.Add(this.boxMail);
            this.Controls.Add(this.boxDocumento);
            this.Controls.Add(this.boxApellido);
            this.Controls.Add(this.boxNombre);
            this.Name = "AltaCliForm";
            this.Text = "AltaCliForm";
            this.Load += new System.EventHandler(this.AltaCliForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.TextBox boxApellido;
        private System.Windows.Forms.TextBox boxDocumento;
        private System.Windows.Forms.TextBox boxMail;
        private System.Windows.Forms.TextBox boxCalle;
        private System.Windows.Forms.TextBox boxAltura;
        private System.Windows.Forms.TextBox boxPiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.TextBox boxDepto;
        private System.Windows.Forms.TextBox boxPais;
        private System.Windows.Forms.TextBox boxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_limpiar;
    }
}