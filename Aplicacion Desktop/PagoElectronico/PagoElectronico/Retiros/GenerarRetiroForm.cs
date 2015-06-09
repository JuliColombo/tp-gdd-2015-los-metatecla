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
    public partial class GenerarRetiroForm : Form
    {
        Cuenta cuentaARetirar;
        public GenerarRetiroForm(Cuenta cuenta)
        {
            InitializeComponent();
            CenterToScreen();
            cuentaARetirar = cuenta;
        }

        private void botonRetirar_Click(object sender, EventArgs e)
        {
            if (cuentaARetirar.saldo >= Convert.ToSingle(importeText.Text)) {
                if (comboMonedas.Text == "Dolares") { 
                
                }
            }
        }
    
    
    }
}
