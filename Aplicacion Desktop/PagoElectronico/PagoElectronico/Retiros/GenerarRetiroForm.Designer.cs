﻿namespace PagoElectronico.Retiros
{
    partial class GenerarRetiroForm
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
            this.comboBancos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMonedas = new System.Windows.Forms.ComboBox();
            this.importeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonRetirar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBancos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboMonedas);
            this.groupBox1.Controls.Add(this.importeText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Retiro";
            // 
            // comboBancos
            // 
            this.comboBancos.FormattingEnabled = true;
            this.comboBancos.Location = new System.Drawing.Point(57, 80);
            this.comboBancos.Name = "comboBancos";
            this.comboBancos.Size = new System.Drawing.Size(121, 21);
            this.comboBancos.TabIndex = 5;
            this.comboBancos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBancos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banco:";
            // 
            // comboMonedas
            // 
            this.comboMonedas.FormattingEnabled = true;
            this.comboMonedas.Location = new System.Drawing.Point(57, 53);
            this.comboMonedas.Name = "comboMonedas";
            this.comboMonedas.Size = new System.Drawing.Size(121, 21);
            this.comboMonedas.TabIndex = 3;
            this.comboMonedas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboMonedas_KeyPress);
            // 
            // importeText
            // 
            this.importeText.Location = new System.Drawing.Point(57, 23);
            this.importeText.Name = "importeText";
            this.importeText.Size = new System.Drawing.Size(121, 20);
            this.importeText.TabIndex = 2;
            this.importeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moneda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe:";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(131, 135);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonRetirar
            // 
            this.botonRetirar.Location = new System.Drawing.Point(50, 135);
            this.botonRetirar.Name = "botonRetirar";
            this.botonRetirar.Size = new System.Drawing.Size(75, 23);
            this.botonRetirar.TabIndex = 2;
            this.botonRetirar.Text = "Retirar";
            this.botonRetirar.UseVisualStyleBackColor = true;
            this.botonRetirar.Click += new System.EventHandler(this.botonRetirar_Click);
            // 
            // GenerarRetiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 165);
            this.Controls.Add(this.botonRetirar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerarRetiroForm";
            this.Text = "Retiro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox importeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMonedas;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonRetirar;
        private System.Windows.Forms.ComboBox comboBancos;
        private System.Windows.Forms.Label label3;
    }
}