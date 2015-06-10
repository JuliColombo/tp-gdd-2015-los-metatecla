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

namespace PagoElectronico.Retiros
{
    public partial class SeleccionDeCuentaForm : Form
    {
        Cliente cli = null;
        List<Cuenta> cuentas = new List<Cuenta>();
        public SeleccionDeCuentaForm(Cliente cliente)
        {
            InitializeComponent();
            this.CenterToScreen();
            cli = cliente;
            cargarCombo();
        }

        public void cargarCombo()
        {
            cuentas = CuentaDB.obtenerCuentasCliente(cli);
            foreach (Cuenta cuenta in cuentas)
            {
                comboCuentas.Items.Add(cuenta.numero);
            }
        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(comboCuentas.Text);
            Cuenta cuentaSeleccionada = cuentas.Find(cuenta => cuenta.numero == numero);
            switch (cuentaSeleccionada.estado)
            {
                case 1: MessageBox.Show("La cuenta esta Pendiente de Activacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 2:
                    if (cuentaSeleccionada.saldo > 0)
                    {
                        GenerarRetiroForm retiro = new GenerarRetiroForm(cuentaSeleccionada);
                        retiro.ShowDialog();
                    }
                    else { MessageBox.Show("La cuenta no tiene saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        break;
                case 3: MessageBox.Show("La cuenta esta Inhabilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 4: MessageBox.Show("La cuenta se encuentra Cerrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void SeleccionDeCuentaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
