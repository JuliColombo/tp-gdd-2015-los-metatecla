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

namespace PagoElectronico.Transferencias
{
    public partial class SeleccionDeCuentaTransForm : Form
    {
        Cliente cli = null;
        List<Cuenta> misCuentas = new List<Cuenta>();
        List<Cuenta> cuentas = new List<Cuenta>();
        public SeleccionDeCuentaTransForm(Cliente cliente)
        {
            InitializeComponent();
            CenterToScreen();
            cli = cliente;
            cargarComboMisCuentas();
            cargarComboCuentas();
        }

        public void cargarComboMisCuentas()
        {
            misCuentas = CuentaDB.obtenerCuentasCliente(cli);
            foreach (Cuenta cuenta in misCuentas)
            {
                comboMisCuentas.Items.Add(Convert.ToInt64(cuenta.numero));
            }
        }

        public void cargarComboCuentas()
        {
            cuentas = CuentaDB.obtenerCuentasTransferibles();
            foreach (Cuenta cuenta in cuentas)
            {   

                comboCuentas.Items.Add(Convert.ToInt64(cuenta.numero));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Cuenta cuentaDestinoSeleccionada = new Cuenta();
            Cuenta cuentaOrigenSeleccionada = new Cuenta();
            double numeroDestino = Convert.ToDouble(comboCuentas.Text);
            double numeroOrigen = Convert.ToDouble(comboMisCuentas.Text);
            cuentaDestinoSeleccionada = cuentas.Find(cuenta => cuenta.numero == numeroDestino);
            cuentaOrigenSeleccionada = misCuentas.Find(cuenta => cuenta.numero == numeroOrigen);
            if (cuentaOrigenSeleccionada.saldo > 0)
            {
                TransferenciaForm trans = new TransferenciaForm(cuentaDestinoSeleccionada, cuentaOrigenSeleccionada);
                trans.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("La cuenta no tiene saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboMisCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
