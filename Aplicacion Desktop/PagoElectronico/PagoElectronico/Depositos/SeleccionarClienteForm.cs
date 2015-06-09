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
            DB.DocumentoDB.cargarTiposDocumento(comboBox_tipoDoc.Items);
        }


        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                if(validaciones())
                {

                PagoElectronico.Dominio.Cliente cliente = PagoElectronico.DB.ClienteDB.crearCliente(textBox_nombre.Text, textBox_apellido.Text, textBox_documento.Text);

                DatosDepositoForm datos_form = new PagoElectronico.Depositos.DatosDepositoForm(cliente);
                datos_form.ShowDialog();

                } else {
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

            if (comboBox_tipoDoc.Text == "")
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
            return PagoElectronico.DB.ClienteDB.existeCliente(textBox_nombre.Text, textBox_apellido.Text, textBox_documento.Text, comboBox_tipoDoc.Text);
        }

    }
}

