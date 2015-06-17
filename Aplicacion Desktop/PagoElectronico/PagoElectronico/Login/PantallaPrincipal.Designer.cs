namespace PagoElectronico.Login
{
    partial class PantallaPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelNomYApe = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnABMTarjetas = new System.Windows.Forms.Button();
            this.listadoCuentas = new System.Windows.Forms.DataGridView();
            this.btn_modifCuenta = new System.Windows.Forms.Button();
            this.labelErrorSeleccion = new System.Windows.Forms.Label();
            this.btn_listadoSaldo = new System.Windows.Forms.Button();
            this.btn_cerrarCuenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRetiro);
            this.groupBox1.Controls.Add(this.btnTransferencia);
            this.groupBox1.Controls.Add(this.btnDeposito);
            this.groupBox1.Location = new System.Drawing.Point(13, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(339, 28);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 2;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(167, 28);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(87, 23);
            this.btnTransferencia.TabIndex = 1;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(16, 28);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDoc);
            this.groupBox2.Controls.Add(this.labelNomYApe);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Usuario";
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Location = new System.Drawing.Point(15, 44);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(35, 13);
            this.labelDoc.TabIndex = 1;
            this.labelDoc.Text = "label2";
            // 
            // labelNomYApe
            // 
            this.labelNomYApe.AutoSize = true;
            this.labelNomYApe.Location = new System.Drawing.Point(15, 20);
            this.labelNomYApe.Name = "labelNomYApe";
            this.labelNomYApe.Size = new System.Drawing.Size(35, 13);
            this.labelNomYApe.TabIndex = 0;
            this.labelNomYApe.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cerrarCuenta);
            this.groupBox3.Controls.Add(this.btn_listadoSaldo);
            this.groupBox3.Controls.Add(this.btn_modifCuenta);
            this.groupBox3.Controls.Add(this.btnABMTarjetas);
            this.groupBox3.Location = new System.Drawing.Point(13, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 68);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones de cuenta";
            // 
            // btnABMTarjetas
            // 
            this.btnABMTarjetas.Location = new System.Drawing.Point(16, 28);
            this.btnABMTarjetas.Name = "btnABMTarjetas";
            this.btnABMTarjetas.Size = new System.Drawing.Size(162, 23);
            this.btnABMTarjetas.TabIndex = 0;
            this.btnABMTarjetas.Text = "Asociar / Desasociar Tarjetas";
            this.btnABMTarjetas.UseVisualStyleBackColor = true;
            this.btnABMTarjetas.Click += new System.EventHandler(this.btnABMTarjetas_Click);
            // 
            // listadoCuentas
            // 
            this.listadoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoCuentas.Location = new System.Drawing.Point(105, 98);
            this.listadoCuentas.Name = "listadoCuentas";
            this.listadoCuentas.Size = new System.Drawing.Size(624, 99);
            this.listadoCuentas.TabIndex = 4;
            // 
            // btn_modifCuenta
            // 
            this.btn_modifCuenta.Location = new System.Drawing.Point(205, 28);
            this.btn_modifCuenta.Name = "btn_modifCuenta";
            this.btn_modifCuenta.Size = new System.Drawing.Size(162, 23);
            this.btn_modifCuenta.TabIndex = 1;
            this.btn_modifCuenta.Text = "Modificar Cuenta";
            this.btn_modifCuenta.UseVisualStyleBackColor = true;
            this.btn_modifCuenta.Click += new System.EventHandler(this.btn_modifCuenta_Click);
            // 
            // labelErrorSeleccion
            // 
            this.labelErrorSeleccion.AutoSize = true;
            this.labelErrorSeleccion.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSeleccion.Location = new System.Drawing.Point(612, 200);
            this.labelErrorSeleccion.Name = "labelErrorSeleccion";
            this.labelErrorSeleccion.Size = new System.Drawing.Size(117, 13);
            this.labelErrorSeleccion.TabIndex = 5;
            this.labelErrorSeleccion.Text = "Seleccione una cuenta";
            this.labelErrorSeleccion.Visible = false;
            // 
            // btn_listadoSaldo
            // 
            this.btn_listadoSaldo.Location = new System.Drawing.Point(397, 28);
            this.btn_listadoSaldo.Name = "btn_listadoSaldo";
            this.btn_listadoSaldo.Size = new System.Drawing.Size(162, 23);
            this.btn_listadoSaldo.TabIndex = 2;
            this.btn_listadoSaldo.Text = "Consulta de Saldo";
            this.btn_listadoSaldo.UseVisualStyleBackColor = true;
            this.btn_listadoSaldo.Click += new System.EventHandler(this.btn_listadoSaldo_Click);
            // 
            // btn_cerrarCuenta
            // 
            this.btn_cerrarCuenta.Location = new System.Drawing.Point(588, 28);
            this.btn_cerrarCuenta.Name = "btn_cerrarCuenta";
            this.btn_cerrarCuenta.Size = new System.Drawing.Size(162, 23);
            this.btn_cerrarCuenta.TabIndex = 3;
            this.btn_cerrarCuenta.Text = "Dar de Baja";
            this.btn_cerrarCuenta.UseVisualStyleBackColor = true;
            this.btn_cerrarCuenta.Click += new System.EventHandler(this.btn_cerrarCuenta_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 380);
            this.Controls.Add(this.labelErrorSeleccion);
            this.Controls.Add(this.listadoCuentas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelNomYApe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnABMTarjetas;
        private System.Windows.Forms.DataGridView listadoCuentas;
        private System.Windows.Forms.Button btn_modifCuenta;
        private System.Windows.Forms.Label labelErrorSeleccion;
        private System.Windows.Forms.Button btn_listadoSaldo;
        private System.Windows.Forms.Button btn_cerrarCuenta;
    }
}