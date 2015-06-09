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
    }
}
