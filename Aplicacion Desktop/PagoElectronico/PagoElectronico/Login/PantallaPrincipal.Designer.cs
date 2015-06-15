namespace PagoElectronico.Login
{
    partial class PantallaPrincipal
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
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelNomYApe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRetiro);
            this.groupBox1.Controls.Add(this.btnTransferencia);
            this.groupBox1.Controls.Add(this.btnDeposito);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(339, 28);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 2;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(167, 28);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(87, 23);
            this.btnTransferencia.TabIndex = 1;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(16, 28);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDoc);
            this.groupBox2.Controls.Add(this.labelNomYApe);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Usuario";
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Location = new System.Drawing.Point(15, 44);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(35, 13);
            this.labelDoc.TabIndex = 1;
            this.labelDoc.Text = "label2";
            // 
            // labelNomYApe
            // 
            this.labelNomYApe.AutoSize = true;
            this.labelNomYApe.Location = new System.Drawing.Point(15, 20);
            this.labelNomYApe.Name = "labelNomYApe";
            this.labelNomYApe.Size = new System.Drawing.Size(35, 13);
            this.labelNomYApe.TabIndex = 0;
            this.labelNomYApe.Text = "label1";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelNomYApe;
    }
}