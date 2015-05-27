namespace PagoElectronico.ABM_Cliente
{
    partial class ABMClienteForm
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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(80, 46);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(112, 50);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "Alta";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMB
            // 
            this.buttonMB.Location = new System.Drawing.Point(80, 134);
            this.buttonMB.Name = "buttonMB";
            this.buttonMB.Size = new System.Drawing.Size(112, 50);
            this.buttonMB.TabIndex = 2;
            this.buttonMB.Text = "Modificar / Eliminar";
            this.buttonMB.UseVisualStyleBackColor = true;
            this.buttonMB.Click += new System.EventHandler(this.buttonMB_Click);
            // 
            // ABMClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.buttonMB);
            this.Controls.Add(this.buttonA);
            this.Name = "ABMClienteForm";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonMB;
    }
}