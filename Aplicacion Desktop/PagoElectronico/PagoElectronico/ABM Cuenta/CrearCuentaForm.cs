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
                crearCuenta(textBox_nro_cuenta.Text, textBox_usuario.Text, comboBoxPais.Text, comboBox_tipo.Text);
            }
            else
            {
                ventanaDeError("No se pudo crear cuenta");
            }
        }

        private void crearCuenta(string nro_cuenta, string usuario, string pais, string tipo)
        {
            PagoElectronico.DB.CuentaDB.crearCuenta(nro_cuenta, usuario, pais, tipo); //falta estado, fecha y moneda TODO 
        }


        private void ventanaDeError(String error)
        {
            Form f = new PagoElectronico.Login.ErrorForm(error);
            f.ShowDialog();
        }

        private bool validaciones()
        {
            return validarUsuario(textBox_usuario.Text) && validadNroCuenta(textBox_nro_cuenta.Text);
            //TODO validarFechaApertura(textBox_fecha.Text);
        }

        private bool validadNroCuenta(string nro_cuenta)
        {
            return PagoElectronico.DB.CuentaDB.noExisteCuenta(nro_cuenta); 
        }

        private bool validarUsuario(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.existe(usuario); 
        }



    }
}
