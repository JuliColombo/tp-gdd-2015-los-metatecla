﻿namespace PagoElectronico
{
    partial class InicioForm
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
            this.btn_abm_cliente = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnListados = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_abm_cliente
            // 
            this.btn_abm_cliente.Location = new System.Drawing.Point(12, 12);
            this.btn_abm_cliente.Name = "btn_abm_cliente";
            this.btn_abm_cliente.Size = new System.Drawing.Size(106, 44);
            this.btn_abm_cliente.TabIndex = 0;
            this.btn_abm_cliente.Text = "ABM Cliente";
            this.btn_abm_cliente.UseVisualStyleBackColor = true;
            this.btn_abm_cliente.Click += new System.EventHandler(this.btn_alta_cliente_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(124, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 44);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Prueba ABM Rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Depósitos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Prueba Retiros";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "Prueba Transferencias";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "Prueba Facturacion";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnListados
            // 
            this.btnListados.Location = new System.Drawing.Point(13, 213);
            this.btnListados.Name = "btnListados";
            this.btnListados.Size = new System.Drawing.Size(75, 23);
            this.btnListados.TabIndex = 8;
            this.btnListados.Text = "Listado";
            this.btnListados.UseVisualStyleBackColor = true;
            this.btnListados.Click += new System.EventHandler(this.btnListados_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(124, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "PantallaPpal";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 265);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnListados);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_abm_cliente);
            this.Name = "InicioForm";
            this.Text = "Pago Electronico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_abm_cliente;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnListados;
        private System.Windows.Forms.Button button7;

    }
}

