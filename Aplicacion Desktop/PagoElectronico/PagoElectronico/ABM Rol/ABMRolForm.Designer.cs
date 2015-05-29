namespace PagoElectronico.ABM_Rol
{
    partial class ABMRolForm
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
            this.gestionRoles = new System.Windows.Forms.GroupBox();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonTerminar = new System.Windows.Forms.Button();
            this.botonInfo = new System.Windows.Forms.Button();
            this.gestionRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionRoles
            // 
            this.gestionRoles.Controls.Add(this.dataGridRoles);
            this.gestionRoles.Controls.Add(this.botonEliminar);
            this.gestionRoles.Controls.Add(this.botonModificar);
            this.gestionRoles.Controls.Add(this.botonCrear);
            this.gestionRoles.Location = new System.Drawing.Point(1, 0);
            this.gestionRoles.Name = "gestionRoles";
            this.gestionRoles.Size = new System.Drawing.Size(474, 245);
            this.gestionRoles.TabIndex = 0;
            this.gestionRoles.TabStop = false;
            this.gestionRoles.Text = "Gestion de Roles";
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Location = new System.Drawing.Point(3, 16);
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.Size = new System.Drawing.Size(440, 191);
            this.dataGridRoles.TabIndex = 3;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(173, 213);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(92, 213);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 1;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(11, 213);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 0;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonTerminar
            // 
            this.botonTerminar.Location = new System.Drawing.Point(355, 252);
            this.botonTerminar.Name = "botonTerminar";
            this.botonTerminar.Size = new System.Drawing.Size(75, 23);
            this.botonTerminar.TabIndex = 2;
            this.botonTerminar.Text = "Terminar";
            this.botonTerminar.UseVisualStyleBackColor = true;
            // 
            // botonInfo
            // 
            this.botonInfo.Location = new System.Drawing.Point(12, 252);
            this.botonInfo.Name = "botonInfo";
            this.botonInfo.Size = new System.Drawing.Size(140, 23);
            this.botonInfo.TabIndex = 3;
            this.botonInfo.Text = "Informacion Del Rol";
            this.botonInfo.UseVisualStyleBackColor = true;
            // 
            // ABMRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 287);
            this.Controls.Add(this.botonInfo);
            this.Controls.Add(this.botonTerminar);
            this.Controls.Add(this.gestionRoles);
            this.Name = "ABMRolForm";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.ABMRolForm_Load);
            this.gestionRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gestionRoles;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.Button botonTerminar;
        private System.Windows.Forms.Button botonInfo;



    }
}