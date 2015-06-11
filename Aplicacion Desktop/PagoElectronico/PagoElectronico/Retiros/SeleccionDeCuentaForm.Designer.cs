namespace PagoElectronico.Retiros
{
    partial class SeleccionDeCuentaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboCuentas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDocumento = new System.Windows.Forms.TextBox();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboCuentas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de Cuenta";
            // 
            // comboCuentas
            // 
            this.comboCuentas.FormattingEnabled = true;
            this.comboCuentas.Location = new System.Drawing.Point(80, 28);
            this.comboCuentas.Name = "comboCuentas";
            this.comboCuentas.Size = new System.Drawing.Size(175, 21);
            this.comboCuentas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis Cuentas:";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(206, 169);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(125, 169);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 2;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDocumento);
            this.groupBox2.Controls.Add(this.comboTipoDoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autenticacion";
            // 
            // textDocumento
            // 
            this.textDocumento.Location = new System.Drawing.Point(117, 22);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.Size = new System.Drawing.Size(138, 20);
            this.textDocumento.TabIndex = 3;
            this.textDocumento.TextChanged += new System.EventHandler(this.textDocumento_TextChanged);
            this.textDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDocumento_KeyPress);
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(117, 47);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(138, 21);
            this.comboTipoDoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero Documento:";
            // 
            // SeleccionDeCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 199);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeleccionDeCuentaForm";
            this.Text = "Retiro";
            this.Load += new System.EventHandler(this.SeleccionDeCuentaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDocumento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
    }
}