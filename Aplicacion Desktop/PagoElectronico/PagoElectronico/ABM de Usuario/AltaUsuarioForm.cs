using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class AltaUsuarioForm : Form
    {
        public AltaUsuarioForm()
        {
            InitializeComponent();
            DB.RolDB.cargarRoles(comboBox1.Items);
        }

        public Dominio.Usuario crearUsuario()
        {
            Dominio.Usuario usuario = new Dominio.Usuario();
            usuario.contraseña = textBox_password.Text;
            usuario.username = textBox_username.Text;
            usuario.roles.Add(DB.RolDB.getId(comboBox1.Text));

            return usuario;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                if (validarUsername())
                {
                    Dominio.Usuario usuario = crearUsuario();
                    //Dominio.Cliente cliente = new Dominio.Cliente();
                    Form fcliente = new ABM_Cliente.ABMCliForm(usuario);
                    fcliente.ShowDialog();
                    this.Close();
                }
                else
                {
                    Form f = new UI.ErrorForm("Ya existe ese nombre de usuario");
                    f.ShowDialog();
                }
            }
        }

        private bool validarUsername()
        {
            return !DB.UsuarioDB.existe(textBox_username.Text);
        }

        private bool validarCamposVacios()
        {
            bool valido = true;
            if (textBox_username.Text == "")
            {
                valido = false;
                labelError_username.Visible = true;
            };
            if (textBox_password.Text == "")
            {
                valido = false;
                labelError_password.Visible = true;
            };
            if (comboBox1.Text == "")
            {
                valido = false;
                labelError_rol.Visible = true;
            };
            
            return valido;
        }
    }
}
