using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class CrearCuentaForm : Form
    {
        public CrearCuentaForm()
        {
            InitializeComponent();
            DB.PaisDB.cargarPaises(comboBoxPais.Items);
            DB.TipoCuentaDB.cargarTipos(comboBox_tipo.Items);
        }


        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                crearCuenta(textBox_nro_cuenta.Text, textBox_usuario.Text, comboBoxPais.Text, comboBox_tipo.Text, maskedTextBox_fecha.Text);
                limpiar();

                Form exito = new CuentaCreadaExitoForm();
                exito.ShowDialog();
            }
            else
            {
                if (validarCamposVacios())
                {
                     ventanaDeError("No se pudo crear cuenta. Hay un error en los datos ingresados."); 
                }
            }
        }

       
        private bool validarCamposVacios()
        {
            bool valido = true;
            if (textBox_usuario.Text == "")
            {
                valido = false;
               labelError_usuario.Visible = true;
            };

            if (textBox_nro_cuenta.Text == "")
            {
                valido = false;
                labelError_nro_cuenta.Visible = true;
            };

            if (comboBoxPais.Text == "")
            {
                valido = false;
                labelError_pais.Visible = true;
            };

            if (comboBox_tipo.Text == "")
            {
                valido = false;
                labelError_tipo.Visible = true;
            };

            if (maskedTextBox_fecha.Text == "")
            {
                valido = false;
                labelError_fecha.Visible = true;
            };

            return valido;
        }

        private void crearCuenta(string nro_cuenta, string usuario, string pais, string tipo, string fecha)
        {
            PagoElectronico.DB.CuentaDB.crearCuenta(nro_cuenta, usuario, pais, tipo, fecha); //falta estado, fecha y moneda TODO 
        }


        private void ventanaDeError(String error)
        {
            Form f = new PagoElectronico.Login.ErrorForm(error);
            f.ShowDialog();
        }

        private bool validaciones()
        {
            return validarUsuario(textBox_usuario.Text) && validadNroCuenta(textBox_nro_cuenta.Text) && validarFechaApertura(maskedTextBox_fecha.Text);
        }

        private bool validarFechaApertura(string fecha)
        {
            DateTime date = Convert.ToDateTime(fecha);
            DateTime fecha_sistema = Convert.ToDateTime(PagoElectronico.Dominio.Config.fechaSystem());

            int comparacion = DateTime.Compare(date, fecha_sistema);

            if(comparacion <= 0){ //BELLO MI CODIGO ;)
                return true;
            }else{
                return false;
                }

        }

        private bool validadNroCuenta(string nro_cuenta)
        {
            return PagoElectronico.DB.CuentaDB.noExisteCuenta(nro_cuenta); 
        }

        private bool validarUsuario(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.existe(usuario); 
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox_nro_cuenta.Text = "";
            textBox_usuario.Text = "";
            comboBox_tipo.Text = "";
            comboBoxPais.Text = "";
            maskedTextBox_fecha.Text = "";
            labelError_fecha.Visible = false;
            labelError_usuario.Visible = false;
            labelError_nro_cuenta.Visible = false;
            labelError_tipo.Visible = false;
            labelError_pais.Visible = false;
        }

       

    }
}
