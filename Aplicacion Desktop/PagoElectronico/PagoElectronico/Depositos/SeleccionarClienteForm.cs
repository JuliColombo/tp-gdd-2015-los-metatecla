using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Depositos
{
    public partial class SeleccionarClienteForm : Form
    {
        public SeleccionarClienteForm()
        {
            InitializeComponent();
        }


        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                PagoElectronico.Dominio.Cliente cliente = PagoElectronico.DB.ClienteDB.crearCliente(textBox_nombre.Text, textBox_apellido.Text, textBox_documento.Text);

                // DatosDepositoForm datos_form;
            }
            else
            {
                if (validarCamposVacios())
                {
                    ventanaDeError("Hay un error en los datos ingresados.");
                }
            }
        }


        private bool validarCamposVacios()
        {
            bool valido = true;
            if (textBox_nombre.Text == "")
            {
                valido = false;
                labelError_nombre.Visible = true;
            };

            if (textBox_apellido.Text == "")
            {
                valido = false;
                labelError_apellido.Visible = true;
            };

            if (textBox_documento.Text == "")
            {
                valido = false;
                labelError_documento.Visible = true;
            };

            return valido;
        }

        private void ventanaDeError(String error)
        {
            Form f = new PagoElectronico.Login.ErrorForm(error);
            f.ShowDialog();
        }

        private bool validaciones()
        {
            return PagoElectronico.DB.ClienteDB.existeCliente(textBox_nombre.Text, textBox_apellido.Text, textBox_documento.Text);
        }

    }
}

