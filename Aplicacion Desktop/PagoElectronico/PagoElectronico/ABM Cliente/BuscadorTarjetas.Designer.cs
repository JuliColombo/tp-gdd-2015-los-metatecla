﻿namespace PagoElectronico.ABM_Cliente
{
    partial class BuscadorTarjetas
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
            this.listaTarjetas = new System.Windows.Forms.DataGridView();
            this.labelCliente = new System.Windows.Forms.Label();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.btnDesasociar = new System.Windows.Forms.Button();
            this.labelErrorSeleccion = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // listaTarjetas
            // 
            this.listaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaTarjetas.Location = new System.Drawing.Point(24, 53);
            this.listaTarjetas.Name = "listaTarjetas";
            this.listaTarjetas.Size = new System.Drawing.Size(443, 110);
            this.listaTarjetas.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(21, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(46, 18);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "label1";
            // 
            // btnAsociar
            // 
            this.btnAsociar.Location = new System.Drawing.Point(41, 194);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(111, 38);
            this.btnAsociar.TabIndex = 2;
            this.btnAsociar.Text = "Asociar Tarjeta";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // btnDesasociar
            // 
            this.btnDesasociar.Location = new System.Drawing.Point(331, 194);
            this.btnDesasociar.Name = "btnDesasociar";
            this.btnDesasociar.Size = new System.Drawing.Size(111, 38);
            this.btnDesasociar.TabIndex = 3;
            this.btnDesasociar.Text = "Desasociar Tarjeta";
            this.btnDesasociar.UseVisualStyleBackColor = true;
            this.btnDesasociar.Click += new System.EventHandler(this.btnDesasociar_Click);
            // 
            // labelErrorSeleccion
            // 
            this.labelErrorSeleccion.AutoSize = true;
            this.labelErrorSeleccion.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSeleccion.Location = new System.Drawing.Point(182, 251);
            this.labelErrorSeleccion.Name = "labelErrorSeleccion";
            this.labelErrorSeleccion.Size = new System.Drawing.Size(117, 13);
            this.labelErrorSeleccion.TabIndex = 4;
            this.labelErrorSeleccion.Text = "Seleccione una Tarjeta";
            this.labelErrorSeleccion.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(185, 194);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 38);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BuscadorTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.labelErrorSeleccion);
            this.Controls.Add(this.btnDesasociar);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.listaTarjetas);
            this.Name = "BuscadorTarjetas";
            this.Text = "Asociar / Desasociar Tarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.listaTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaTarjetas;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.Button btnDesasociar;
        private System.Windows.Forms.Label labelErrorSeleccion;
        private System.Windows.Forms.Button btnModificar;
    }
}