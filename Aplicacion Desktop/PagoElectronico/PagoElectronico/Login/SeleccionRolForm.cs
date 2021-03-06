﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;
using PagoElectronico.DB;

namespace PagoElectronico.Login
{
    public partial class SeleccionRolForm : Form
    {
        List<Rol> roles = new List<Rol>();
        Usuario usuario;
        int idUser;
        public SeleccionRolForm(List<Rol> rolesUsuario, int idUsuario)
        {
            InitializeComponent();
            CenterToScreen();
            usuario = UsuarioDB.getUsuario(idUsuario);
            idUser = idUsuario;
            labelUsuario.Text = usuario.username;
            this.roles = rolesUsuario;
            cargarComboRoles();
            
        }

        private void cargarComboRoles()
        {
            foreach (Rol rol in roles)
            {
                comboRoles.Items.Add(rol.nombre);
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (!(comboRoles.Text == ""))
            {
                int idRol = RolDB.getId(comboRoles.Text);
                Rol rol = RolDB.getRol(idRol);
                if (rol.habilitado)
                {
                    PantallaPrincipal pantalla = new PantallaPrincipal(idUser, idRol);
                    pantalla.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("El rol elegido se encuentra inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("No se selecciono ningun rol", "Error, vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboRoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
