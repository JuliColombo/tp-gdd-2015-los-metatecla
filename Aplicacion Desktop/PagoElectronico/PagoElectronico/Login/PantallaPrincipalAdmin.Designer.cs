namespace PagoElectronico.Login
{
    partial class PantallaPrincipalAdmin
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
            this.btnListados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListados
            // 
            this.btnListados.Location = new System.Drawing.Point(68, 205);
            this.btnListados.Name = "btnListados";
            this.btnListados.Size = new System.Drawing.Size(135, 23);
            this.btnListados.TabIndex = 0;
            this.btnListados.Text = "Consultar Estadísticas";
            this.btnListados.UseVisualStyleBackColor = true;
            this.btnListados.Click += new System.EventHandler(this.btnListados_Click);
            // 
            // PantallaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnListados);
            this.Name = "PantallaPrincipalAdmin";
            this.Text = "PantallaPrincipalAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListados;
    }
}