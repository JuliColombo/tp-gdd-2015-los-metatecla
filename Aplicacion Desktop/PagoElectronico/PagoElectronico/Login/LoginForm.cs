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


        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
            if (PagoElectronico.DB.UsuarioDB.autentificar(textBox_username.Text, textBox_password.Text))
            {
                label_estado.Text = "Todo piola";
            }
            else
            {
                label_estado.Text = "No se puede ingresar";
                if (existeUsuario(textBox_username.Text))
                {
                    label_estado.Text = "No se puede ingresar pero SI existe el usuario " + textBox_username.Text;
                    agregarIntentoFallido(textBox_username.Text);


                    if (numerosDeIntentos(textBox_username.Text) > 3)
                    {
                        label_estado.Text = "Ya van 3 intentos fallidos";
                    }
                }
                else
                {
                    label_estado.Text = "No existe ese usuario";
                }
      

            }
        }

        private int numerosDeIntentos(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.numeroDeIntentos(usuario);
        }

        private bool existeUsuario(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.existe(usuario);
        }

        private void agregarIntentoFallido(string usuario)
        {
            PagoElectronico.DB.UsuarioDB.agregarIntentoFallido(usuario);
        }

        
    }
}

