using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.DB;
using PagoElectronico.Dominio;
using System.Globalization;

namespace PagoElectronico.Transferencias
{
    public partial class TransferenciaForm : Form
    {
        NumberFormatInfo provider = new NumberFormatInfo();
        Cuenta destino = new Cuenta();
        Cuenta origen = new Cuenta();
        public TransferenciaForm(Cuenta destino, Cuenta origen)
        {
            InitializeComponent();
            CenterToScreen();
            MonedaDB.cargarMonedas(comboMonedas.Items);
            this.destino = destino;
            this.origen = origen;
            labelDestino.Text = Convert.ToString(Convert.ToInt64(destino.numero));
            labelOrigen.Text = Convert.ToString(Convert.ToInt64(origen.numero));
            provider.NumberDecimalSeparator = ".";
            //labelCosto.Text = Convert.ToString(origen.tipo);
            if (!(origen.idPropietario == destino.idPropietario))
            {
                labelCosto.Text = string.Format("{0:$0.00}", (TipoCuentaDB.obtenerCosto(origen.tipo)).costoTrans);
            }
            else { labelCosto.Text = string.Format("$0.00"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloDecimales(e, textImporte);
        }

        private void butonTrans_Click(object sender, EventArgs e)
        {
            if (!(textImporte.Text == ""))
            {
                if ((Convert.ToDouble(textImporte.Text, provider) <= origen.saldo))
                {
                    if (comboMonedas.Text == "Dólar")
                    {
                        realizarTransferencia();
                    }
                    else { MessageBox.Show("El importe debe esta en dolares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("No tiene suficiente saldo en la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("No se ingreso el importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void realizarTransferencia()
        {
            Costos costo = TipoCuentaDB.obtenerCosto(origen.tipo);
            double importe = Convert.ToDouble(textImporte.Text,provider);
            int moneda = MonedaDB.getID(comboMonedas.Text);
            TransferenciaDB.insertarTransferencia(origen,destino,importe,moneda,costo.costoTrans);
            if (origen.idPropietario == destino.idPropietario) 
            {
                MessageBox.Show("Transferencia realizada con EXITO.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transferencia realizada con EXITO. Costo por transferencia pendiente a facturar", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void comboMonedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void butonCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
