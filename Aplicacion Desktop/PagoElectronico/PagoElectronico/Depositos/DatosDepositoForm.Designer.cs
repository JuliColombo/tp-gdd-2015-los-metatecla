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
            this.SuspendLayout();
            // 
            // btn_depositar
            // 
            this.btn_depositar.Location = new System.Drawing.Point(181, 222);
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
            this.label_cta.Location = new System.Drawing.Point(17, 115);
            this.label_cta.Name = "label_cta";
            this.label_cta.Size = new System.Drawing.Size(99, 13);
            this.label_cta.TabIndex = 1;
            this.label_cta.Text = "Número de Cuenta:";
            // 
            // comboBox_cuenta
            // 
            this.comboBox_cuenta.FormattingEnabled = true;
            this.comboBox_cuenta.Location = new System.Drawing.Point(122, 112);
            this.comboBox_cuenta.Name = "comboBox_cuenta";
            this.comboBox_cuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cuenta.TabIndex = 2;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(21, 15);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(70, 13);
            this.label_nombre.TabIndex = 3;
            this.label_nombre.Text = "label_nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(21, 39);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(71, 13);
            this.label_apellido.TabIndex = 4;
            this.label_apellido.Text = "label_apellido";
            // 
            // label_documento
            // 
            this.label_documento.AutoSize = true;
            this.label_documento.Location = new System.Drawing.Point(21, 63);
            this.label_documento.Name = "label_documento";
            this.label_documento.Size = new System.Drawing.Size(88, 13);
            this.label_documento.TabIndex = 5;
            this.label_documento.Text = "label_documento";
            // 
            // DatosDepositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}