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
        PagoElectronico.Dominio.Cliente cli;
       
        public DatosDepositoForm(PagoElectronico.Dominio.Cliente cliente)
        {
            InitializeComponent();

            cli = cliente;

            label_apellido.Text = cliente.apellido;
            label_documento.Text = cliente.documento.ToString();
            label_nombre.Text = cliente.nombre;

            DB.MonedaDB.cargarMonedas(comboBox_moneda.Items);
            
           foreach(double numero in cliente.numeros_cuentas){
                comboBox_cuenta.Items.Add(numero);
            }

           foreach (int numero in cliente.ultimos_numeros_tarjetas())
           {
               comboBox_tarjeta.Items.Add(numero);
           }
        }



        private void btn_depositar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                if (validaciones())
                {
                    //realizar deposito
                    double codigo_deposito = PagoElectronico.DB.DepositoDB.obtener_ultimo_codigo_deposito() + 1;
                    nuevoDeposito(codigo_deposito, textBox_importe.Text, comboBox_moneda.Text, comboBox_tarjeta.Text, comboBox_cuenta.Text);
                }
                else
                {
                    mostrarError();
                }
            }
        }

        private void nuevoDeposito(double codigo_deposito, string importe, string moneda, string ult_num_tarjeta, string cuenta)
        {
            PagoElectronico.Dominio.Tarjeta tarjeta = cli.buscar_tarjeta(Convert.ToInt32(ult_num_tarjeta));
            int id_moneda = DB.MonedaDB.getID(moneda);
            PagoElectronico.DB.DepositoDB.insertar_deposito(codigo_deposito, Convert.ToDouble(importe), id_moneda, tarjeta.id, Convert.ToInt64(cuenta));

        }

        private void mostrarError()
        {
            switch (error) {
                case 0: ventanaDeError("El importe debe ser mayor a 1.");
                    break;
                case 1: ventanaDeError("La tarjeta seleccionada se encuentra vencida");
                    break;
                case 2: ventanaDeError("Cuenta inhabilitada");
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
            return importeNoNegativo(textBox_importe.Text) && tarjetaNoVencida(comboBox_tarjeta.Text);// && cuenta_habilitada(comboBox_cuenta.Text); 
        }

        private bool tarjetaNoVencida(string ult_numero_tarjeta)
        {
            bool resultado = estaVencida(ult_numero_tarjeta);
            if (resultado)
            {
                error = 1;
            }

            return resultado;
        }

        private bool estaVencida(string ult_numero_tarjeta)
        {
            
            PagoElectronico.Dominio.Tarjeta tarjeta = cli.buscar_tarjeta(Convert.ToInt32(ult_numero_tarjeta));

            DateTime fecha_tarjeta = Convert.ToDateTime(tarjeta.fecha_vencimiento);
            DateTime fecha_sistema = Convert.ToDateTime(PagoElectronico.Dominio.Config.fechaSystem());
            
            return DateTime.Compare(fecha_tarjeta, fecha_sistema) > 0;
           
        }

        private bool importeNoNegativo(string importe)
        {
            double import = Convert.ToDouble(importe);
            if (import < 1)
            {
                error = 0;
            }

            return import > 1;
        }

        private bool cuenta_habilitada(string cuenta)
        {
            bool resultado = DB.CuentaDB.estaHabilitada(Convert.ToInt64(cuenta));

            if (!resultado)
            {
                error = 2;
            }

            return resultado;

        }

        private void label_tarjeta_Click(object sender, EventArgs e)
        {

        }
    }
}
