using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btn_hash_Click(object sender, EventArgs e)
        {
            label_estado.Text = PagoElectronico.DB.UsuarioDB.SHA256(textBox_password.Text);
        }

        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
            if (PagoElectronico.DB.UsuarioDB.autentificar(textBox_username.Text, textBox_password.Text))
            {
                label_estado.Text = "Todo piola";
            }
            else
            {
                label_estado.Text = "No se puede ingresar";
            }
        }

        
    }
}

