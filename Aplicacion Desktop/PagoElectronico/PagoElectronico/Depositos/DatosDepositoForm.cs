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
    public partial class DatosDepositoForm : Form
    {
        int error;
       
        public DatosDepositoForm(PagoElectronico.Dominio.Cliente cliente)
        {
            InitializeComponent();

            label_apellido.Text = cliente.apellido;
            label_documento.Text = cliente.documento.ToString();
            label_nombre.Text = cliente.nombre;

            DB.MonedaDB.cargarMonedas(comboBox_moneda.Items);
            
           foreach(double numero in cliente.numeros_cuentas){
                comboBox_cuenta.Items.Add(numero);
            }

           foreach (double tarjeta in cliente.numeros_tarjetas)
           {
               comboBox_tarjeta.Items.Add(tarjeta);
           }
        }



        private void btn_depositar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                if (validaciones())
                {
                    //realizar deposito
                }
                else
                {
                    mostrarError();
                }
            }
        }

        private void mostrarError()
        {
            switch (error) {
                case 0: ventanaDeError("El importe debe ser mayor a 1.");
                    break;
                case 1: ventanaDeError("La tarjeta seleccionada se encuentra vencida");
                    break;

            }
        }

        private void ventanaDeError(string e)
        {
            Form f = new PagoElectronico.Login.ErrorForm(e);
            f.ShowDialog();
        }



        private bool validarCamposVacios()
        {
            bool valido = true;
            if (textBox_importe.Text == "")
            {
                valido = false;
                labelError_importe.Visible = true;
            };

            
            if (comboBox_moneda.Text == "")
            {
                valido = false;
                labelError_moneda.Visible = true;
            };

            if (comboBox_cuenta.Text == "")
            {
                valido = false;
                labelError_cuenta.Visible = true;
            };

            if (comboBox_tarjeta.Text == "")
            {
                valido = false;
                labelError_tarjeta.Visible = true;
            };

            return valido;
        }



        private bool validaciones()
        {
            return importeNoNegativo(textBox_importe.Text) && tarjetaNoVencida(comboBox_tarjeta.Text); 
        }

        private bool tarjetaNoVencida(string numero_tarjeta)
        {
            bool resultado = PagoElectronico.DB.TarjetaDB.estaVencida(numero_tarjeta);
            if (resultado)
            {
                error = 1;
            }

            return resultado;
        }

        private bool importeNoNegativo(string importe)
        {
            double import = Convert.ToDouble(importe);
            if (import < 1)
            {
                error = 0;
            }

            return import < 1;
        }
    }
}
