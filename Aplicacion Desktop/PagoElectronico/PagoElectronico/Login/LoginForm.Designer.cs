namespace PagoElectronico.Login
{
    partial class LoginForm
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
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label_estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(20, 23);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(23, 48);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(176, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(23, 115);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(176, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(20, 90);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(161, 186);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(89, 36);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Autentificarse";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click_1);
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(32, 161);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(0, 13);
            this.label_estado.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label_estado;
    }
}