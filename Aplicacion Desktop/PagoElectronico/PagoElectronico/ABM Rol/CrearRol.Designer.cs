namespace PagoElectronico.ABM_Rol
{
    partial class CrearRol
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.Funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.botonCrearGuardar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionalidades: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado del Rol:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(111, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Habilitado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(86, 15);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(295, 20);
            this.nombreText.TabIndex = 4;
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(29, 54);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(352, 139);
            this.Funcionalidades.TabIndex = 5;
            // 
            // botonCrearGuardar
            // 
            this.botonCrearGuardar.Location = new System.Drawing.Point(225, 228);
            this.botonCrearGuardar.Name = "botonCrearGuardar";
            this.botonCrearGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonCrearGuardar.TabIndex = 6;
            this.botonCrearGuardar.Text = "Crear";
            this.botonCrearGuardar.UseVisualStyleBackColor = true;
            this.botonCrearGuardar.Click += new System.EventHandler(this.botonCrearGuardar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(306, 228);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "* Campos Obligatorios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nueva Funcionalidad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonCrearGuardar);
            this.Controls.Add(this.Funcionalidades);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearRol";
            this.Text = "Crear Nuevo Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.CheckedListBox Funcionalidades;
        private System.Windows.Forms.Button botonCrearGuardar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}