namespace PagoElectronico.Depositos
{
    partial class SeleccionarClienteForm
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.labelError_nombre = new System.Windows.Forms.Label();
            this.labelError_apellido = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelError_documento = new System.Windows.Forms.Label();
            this.textBox_documento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba los datos del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(81, 48);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(143, 20);
            this.textBox_nombre.TabIndex = 2;
            // 
            // labelError_nombre
            // 
            this.labelError_nombre.AutoSize = true;
            this.labelError_nombre.ForeColor = System.Drawing.Color.Red;
            this.labelError_nombre.Location = new System.Drawing.Point(250, 51);
            this.labelError_nombre.Name = "labelError_nombre";
            this.labelError_nombre.Size = new System.Drawing.Size(133, 13);
            this.labelError_nombre.TabIndex = 3;
            this.labelError_nombre.Text = "Falta especificar el nombre";
            this.labelError_nombre.Visible = false;
            // 
            // labelError_apellido
            // 
            this.labelError_apellido.AutoSize = true;
            this.labelError_apellido.ForeColor = System.Drawing.Color.Red;
            this.labelError_apellido.Location = new System.Drawing.Point(250, 88);
            this.labelError_apellido.Name = "labelError_apellido";
            this.labelError_apellido.Size = new System.Drawing.Size(134, 13);
            this.labelError_apellido.TabIndex = 6;
            this.labelError_apellido.Text = "Falta especificar el apellido";
            this.labelError_apellido.Visible = false;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(81, 85);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(143, 20);
            this.textBox_apellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            // 
            // labelError_documento
            // 
            this.labelError_documento.AutoSize = true;
            this.labelError_documento.ForeColor = System.Drawing.Color.Red;
            this.labelError_documento.Location = new System.Drawing.Point(248, 124);
            this.labelError_documento.Name = "labelError_documento";
            this.labelError_documento.Size = new System.Drawing.Size(151, 13);
            this.labelError_documento.TabIndex = 9;
            this.labelError_documento.Text = "Falta especificar el documento";
            this.labelError_documento.Visible = false;
            // 
            // textBox_documento
            // 
            this.textBox_documento.Location = new System.Drawing.Point(79, 121);
            this.textBox_documento.Name = "textBox_documento";
            this.textBox_documento.Size = new System.Drawing.Size(143, 20);
            this.textBox_documento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Documento:";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(253, 180);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(129, 29);
            this.btn_seleccionar.TabIndex = 10;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // SeleccionarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 223);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.labelError_documento);
            this.Controls.Add(this.textBox_documento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelError_apellido);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelError_nombre);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionarClienteForm";
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label labelError_nombre;
        private System.Windows.Forms.Label labelError_apellido;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelError_documento;
        private System.Windows.Forms.TextBox textBox_documento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}