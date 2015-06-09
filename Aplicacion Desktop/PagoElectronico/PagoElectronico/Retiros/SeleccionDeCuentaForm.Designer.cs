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
            this.groupBox1.SuspendLayout();
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
            this.botonCancelar.Location = new System.Drawing.Point(206, 82);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(125, 82);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 2;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // SeleccionDeCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 113);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeleccionDeCuentaForm";
            this.Text = "Retiro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonSeleccionar;
    }
}