﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class BuscadorCliForm : Form
    {

        public BuscadorCliForm()
        {
            InitializeComponent();
        }

        private void buscar()
        {
            listado.DataSource = DB.ClienteDB.buscarClientes(boxNombre.Text, boxApellido.Text, comboBoxTipoDoc.Text, boxDocumento.Text, boxMail.Text);
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos()){
                this.buscar();
            }
        }

        private bool validarCampos()
        {
            return true;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (listado.SelectedRows.Count == 1)
            {
                int idCliente = Convert.ToInt32(listado.CurrentRow.Cells[5].Value);
                ABMCliForm mb = new ABMCliForm(idCliente);
                mb.Owner = this;
                mb.ShowDialog();
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //ABMCliForm mb = new ABMCliForm(0);
            ABM_de_Usuario.AltaUsuarioForm mb = new PagoElectronico.ABM_de_Usuario.AltaUsuarioForm();
            mb.Owner = this;
            mb.ShowDialog();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            boxApellido.Text = "";
            boxDocumento.Text = "";
            boxMail.Text = "";
            boxNombre.Text = "";
            comboBoxTipoDoc.Text = "";
        }

        private void boxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listado.SelectedRows.Count == 1)
            {
                int idCliente = Convert.ToInt32(listado.CurrentRow.Cells[5].Value);
                DB.ClienteDB.darDeBaja(idCliente);
                this.buscar();
                MessageBox.Show("Cliente eliminado correctamente");
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
        }

        private void btn_ABTarjetas_Click(object sender, EventArgs e)
        {
            if (listado.SelectedRows.Count == 1)
            {
                int idCli = Convert.ToInt32(listado.CurrentRow.Cells[5].Value);
                string nombre = Convert.ToString(listado.CurrentRow.Cells[0].Value) + " " + Convert.ToString(listado.CurrentRow.Cells[1].Value);
                BuscadorTarjetas tarj = new BuscadorTarjetas(idCli, nombre);
                tarj.Owner = this;
                tarj.ShowDialog();
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
        }
    }
}
