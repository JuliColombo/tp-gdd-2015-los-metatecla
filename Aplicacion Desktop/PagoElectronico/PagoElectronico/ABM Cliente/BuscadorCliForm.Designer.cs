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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.labelErrorSeleccion = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_ABTarjetas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(326, 9);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(100, 20);
            this.boxNombre.TabIndex = 5;
            // 
            // boxApellido
            // 
            this.boxApellido.Location = new System.Drawing.Point(326, 40);
            this.boxApellido.Name = "boxApellido";
            this.boxApellido.Size = new System.Drawing.Size(100, 20);
            this.boxApellido.TabIndex = 6;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "Pasaporte"});
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(326, 71);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDoc.TabIndex = 7;
            // 
            // boxDocumento
            // 
            this.boxDocumento.Location = new System.Drawing.Point(326, 104);
            this.boxDocumento.Name = "boxDocumento";
            this.boxDocumento.Size = new System.Drawing.Size(100, 20);
            this.boxDocumento.TabIndex = 8;
            this.boxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxDocumento_KeyPress);
            // 
            // boxMail
            // 
            this.boxMail.Location = new System.Drawing.Point(326, 138);
            this.boxMail.Name = "boxMail";
            this.boxMail.Size = new System.Drawing.Size(100, 20);
            this.boxMail.TabIndex = 9;
            // 
            // listado
            // 
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Location = new System.Drawing.Point(29, 211);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(559, 150);
            this.listado.TabIndex = 10;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(326, 173);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 11;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(351, 367);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(194, 367);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(513, 367);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 14;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // labelErrorSeleccion
            // 
            this.labelErrorSeleccion.AutoSize = true;
            this.labelErrorSeleccion.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSeleccion.Location = new System.Drawing.Point(479, 413);
            this.labelErrorSeleccion.Name = "labelErrorSeleccion";
            this.labelErrorSeleccion.Size = new System.Drawing.Size(109, 13);
            this.labelErrorSeleccion.TabIndex = 15;
            this.labelErrorSeleccion.Text = "Seleccione un cliente";
            this.labelErrorSeleccion.Visible = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(29, 367);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 16;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(217, 173);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_ABTarjetas
            // 
            this.btn_ABTarjetas.Location = new System.Drawing.Point(217, 403);
            this.btn_ABTarjetas.Name = "btn_ABTarjetas";
            this.btn_ABTarjetas.Size = new System.Drawing.Size(184, 23);
            this.btn_ABTarjetas.TabIndex = 18;
            this.btn_ABTarjetas.Text = "Asociar / Desasociar Tarjetas";
            this.btn_ABTarjetas.UseVisualStyleBackColor = true;
            this.btn_ABTarjetas.Click += new System.EventHandler(this.btn_ABTarjetas_Click);
            // 
            // BuscadorCliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 433);
            this.Controls.Add(this.btn_ABTarjetas);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.labelErrorSeleccion);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
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
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label labelErrorSeleccion;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_ABTarjetas;
    }
}