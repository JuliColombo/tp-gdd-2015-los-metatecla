﻿namespace PagoElectronico.ABM_Cliente
{
    partial class BuscadorCliForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxApellido = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.boxDocumento = new System.Windows.Forms.TextBox();
            this.boxMail = new System.Windows.Forms.TextBox();
            this.listado = new System.Windows.Forms.DataGridView();
            this.botonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(162, 9);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(100, 20);
            this.boxNombre.TabIndex = 5;
            // 
            // boxApellido
            // 
            this.boxApellido.Location = new System.Drawing.Point(162, 40);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Size = new System.Drawing.Size(100, 20);
            this.boxApellido.TabIndex = 6;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "Pasaporte"});
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(162, 71);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDoc.TabIndex = 7;
            // 
            // boxDocumento
            // 
            this.boxDocumento.Location = new System.Drawing.Point(162, 104);
            this.boxDocumento.Name = "boxDocumento";
            this.boxDocumento.Size = new System.Drawing.Size(100, 20);
            this.boxDocumento.TabIndex = 8;
            // 
            // boxMail
            // 
            this.boxMail.Location = new System.Drawing.Point(162, 138);
            this.boxMail.Name = "boxMail";
            this.boxMail.Size = new System.Drawing.Size(100, 20);
            this.boxMail.TabIndex = 9;
            // 
            // listado
            // 
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Location = new System.Drawing.Point(29, 211);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(240, 150);
            this.listado.TabIndex = 10;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(106, 173);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 11;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // BuscadorCliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 373);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.boxMail);
            this.Controls.Add(this.boxDocumento);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.boxApellido);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscadorCliForm";
            this.Text = "Buscador de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.TextBox boxApellido;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.TextBox boxDocumento;
        private System.Windows.Forms.TextBox boxMail;
        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.Button botonBuscar;
    }
}