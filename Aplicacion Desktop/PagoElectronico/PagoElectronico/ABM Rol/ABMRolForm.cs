﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.DB;
using PagoElectronico.Dominio;
namespace PagoElectronico.ABM_Rol
{

    public partial class ABMRolForm : Form
    {
        public ABMRolForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            actualizarDataGrid();

        }

        private void actualizarDataGrid()
        {

            dataGridRoles.DataSource = RolDB.obtenerRoles();
            dataGridRoles.Columns[0].Visible = false;
            dataGridRoles.Columns[1].HeaderText = "Nombre del Rol";
            dataGridRoles.Columns[1].Width = 250;
            dataGridRoles.Columns[2].Visible = false;
            dataGridRoles.Columns[3].HeaderText = "Estado";
            
        }

        private void ABMRolForm_Load(object sender, EventArgs e)
        {

        }

        // Si se hace click en crear se abre nueva ventana con las opciones correspondientes
        private void botonCrear_Click(object sender, EventArgs e)
        {
            CrearRol creacion = new CrearRol();
            creacion.ShowDialog();
            actualizarDataGrid();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridRoles.RowCount > 0)
            {
                Rol rol = dataGridRoles.CurrentRow.DataBoundItem as Rol;
                ModificarForm modForm = new ModificarForm(rol);
                modForm.ShowDialog();
                actualizarDataGrid();
            }
            else { MessageBox.Show("No se selecciono ningun rol o bien no existe ninguno", "Error, vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void botonTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridRoles.RowCount > 0)
            {
                Rol rol = dataGridRoles.CurrentRow.DataBoundItem as Rol;
                if (rol.habilitado)
                {
                    rol.habilitado = false;
                    RolDB roldb = new RolDB();
                    roldb.deshabilitarRol(rol);
                    actualizarDataGrid();
                    MessageBox.Show("Se inhabilito el ROL", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("El ROL ya se encuentra inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("No se selecciono ningun rol o bien no existe ninguno", "Error, vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void botonInfo_Click(object sender, EventArgs e)
        {

            if (dataGridRoles.RowCount > 0)
            {
                Rol rol = dataGridRoles.CurrentRow.DataBoundItem as Rol;
                InfoForm info = new InfoForm(rol);
                info.ShowDialog();
            }
            else { MessageBox.Show("No se selecciono ningun rol o bien no existe ninguno","Error, vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

     
    }
}
