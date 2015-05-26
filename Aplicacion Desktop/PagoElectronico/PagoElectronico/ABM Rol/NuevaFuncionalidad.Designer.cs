namespace PagoElectronico.ABM_Rol
{
    partial class NuevaFuncionalidad
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
            this.textNombreFunc = new System.Windows.Forms.TextBox();
            this.botonCrearFunc = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Funcionalidad:";
            // 
            // textNombreFunc
            // 
            this.textNombreFunc.Location = new System.Drawing.Point(134, 23);
            this.textNombreFunc.Name = "textNombreFunc";
            this.textNombreFunc.Size = new System.Drawing.Size(184, 20);
            this.textNombreFunc.TabIndex = 1;
            // 
            // botonCrearFunc
            // 
            this.botonCrearFunc.Location = new System.Drawing.Point(112, 55);
            this.botonCrearFunc.Name = "botonCrearFunc";
            this.botonCrearFunc.Size = new System.Drawing.Size(100, 23);
            this.botonCrearFunc.TabIndex = 2;
            this.botonCrearFunc.Text = "Crear";
            this.botonCrearFunc.UseVisualStyleBackColor = true;
            this.botonCrearFunc.Click += new System.EventHandler(this.botonCrearFunc_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(218, 55);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(100, 23);
            this.Volver.TabIndex = 3;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // NuevaFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 90);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.botonCrearFunc);
            this.Controls.Add(this.textNombreFunc);
            this.Controls.Add(this.label1);
            this.Name = "NuevaFuncionalidad";
            this.Text = "Nueva Funcionalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreFunc;
        private System.Windows.Forms.Button botonCrearFunc;
        private System.Windows.Forms.Button Volver;
    }
}