namespace PagoElectronico.ABM_Cliente
{
    partial class ABTarjetas
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
            ((System.ComponentModel.ISupportInitialize)(this.listaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // listaTarjetas
            // 
            this.listaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaTarjetas.Location = new System.Drawing.Point(24, 135);
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
            // ABTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.listaTarjetas);
            this.Name = "ABTarjetas";
            this.Text = "ABTarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.listaTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaTarjetas;
        private System.Windows.Forms.Label labelCliente;
    }
}