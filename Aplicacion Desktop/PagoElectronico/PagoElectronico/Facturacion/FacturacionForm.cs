using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;
using PagoElectronico.DB;

namespace PagoElectronico.Facturacion
{
    public partial class FacturacionForm : Form
    {
        Cliente cliente;
        List<Cuenta> cuentas = new List<Cuenta>();
        public FacturacionForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CenterToScreen();
            cargarComboCuentas();
            labelCosto.Text = "";
            labelTipo.Text = "";
        }



        public void cargarComboCuentas()
        {
            cuentas = CuentaDB.obtenerCuentasCliente(this.cliente);
            foreach (Cuenta cuenta in cuentas)
            {

                comboCuentas.Items.Add(Convert.ToInt64(cuenta.numero));
            }
        }

        private void comboCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboCuentas_SelectedValueChanged(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            cuenta = cuentas.Find(cta => cta.numero == (Convert.ToDouble(comboCuentas.Text)));
            labelTipo.Text = TipoCuentaDB.getTipo(cuenta.tipo);
            labelCosto.Text =string.Format("{0:$0.00}", TipoCuentaDB.obtenerCosto(cuenta.tipo).costoApertura);
        }
    }
}

