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
        Cuenta destino;
        Cuenta origen;
        public TransferenciaForm(Cuenta destino, Cuenta origen)
        {
            InitializeComponent();
            MonedaDB.cargarMonedas(comboMonedas.Items);
            this.destino = destino;
            this.origen = origen;
            labelDestino.Text = Convert.ToString(destino.numero);
            labelOrigen.Text = Convert.ToString(origen.numero);
            provider.NumberDecimalSeparator = ".";
            //labelCosto.Text = Convert.ToString(origen.tipo);
            labelCosto.Text = Convert.ToString(TipoCuentaDB.obtenerCosto(origen.tipo));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloDecimales(e, textImporte);
        }
    }
}
