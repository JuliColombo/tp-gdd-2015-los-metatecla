namespace PagoElectronico.Listados
{
    partial class EstadisticasForm
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
            this.listado = new System.Windows.Forms.DataGridView();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.comboBoxListado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.SuspendLayout();
            // 
            // listado
            // 
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Location = new System.Drawing.Point(23, 153);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(449, 154);
            this.listado.TabIndex = 0;
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Location = new System.Drawing.Point(295, 12);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(57, 21);
            this.comboBoxAño.TabIndex = 1;
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Items.AddRange(new object[] {
            "Enero - Febrero - Marzo",
            "Abril - Mayo - Junio",
            "Julio - Agosto - Septiembre",
            "Octubre - Noviembre - Diciembre"});
            this.comboBoxTrimestre.Location = new System.Drawing.Point(227, 39);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTrimestre.TabIndex = 2;
            // 
            // comboBoxListado
            // 
            this.comboBoxListado.FormattingEnabled = true;
            this.comboBoxListado.Items.AddRange(new object[] {
            "Clientes con cuentas inhabilitadas",
            "Cliente con mayor comisión",
            "Clientes con mayores transacciones propias",
            "Paises con mayores movimientos",
            "Facturación por tipo de cuenta"});
            this.comboBoxListado.Location = new System.Drawing.Point(193, 66);
            this.comboBoxListado.Name = "comboBoxListado";
            this.comboBoxListado.Size = new System.Drawing.Size(256, 21);
            this.comboBoxListado.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trimestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Listado";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(184, 99);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(121, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Llenar todos los campos";
            this.labelError.Visible = false;
            // 
            // labelCargando
            // 
            this.labelCargando.AutoSize = true;
            this.labelCargando.ForeColor = System.Drawing.Color.Red;
            this.labelCargando.Location = new System.Drawing.Point(316, 134);
            this.labelCargando.Name = "labelCargando";
            this.labelCargando.Size = new System.Drawing.Size(62, 13);
            this.labelCargando.TabIndex = 9;
            this.labelCargando.Text = "Cargando...";
            this.labelCargando.Visible = false;
            // 
            // EstadisticasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 319);
            this.Controls.Add(this.labelCargando);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBoxListado);
            this.Controls.Add(this.comboBoxTrimestre);
            this.Controls.Add(this.comboBoxAño);
            this.Controls.Add(this.listado);
            this.Name = "EstadisticasForm";
            this.Text = "Listados Estadísticos";
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.ComboBox comboBoxListado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelCargando;
    }
}