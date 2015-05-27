namespace PagoElectronico
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
            this.SuspendLayout();
            // 
            // btn_abm_cliente
            // 
            this.btn_abm_cliente.Location = new System.Drawing.Point(93, 44);
            this.btn_abm_cliente.Name = "btn_abm_cliente";
            this.btn_abm_cliente.Size = new System.Drawing.Size(106, 44);
            this.btn_abm_cliente.TabIndex = 0;
            this.btn_abm_cliente.Text = "ABM Cliente";
            this.btn_abm_cliente.UseVisualStyleBackColor = true;
            this.btn_abm_cliente.Click += new System.EventHandler(this.btn_alta_cliente_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(93, 114);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 44);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_abm_cliente);
            this.Name = "InicioForm";
            this.Text = "Pago Electronico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_abm_cliente;
        private System.Windows.Forms.Button btn_login;

    }
}

