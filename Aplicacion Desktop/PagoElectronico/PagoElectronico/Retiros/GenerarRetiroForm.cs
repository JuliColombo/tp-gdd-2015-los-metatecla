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
using System.Globalization;

namespace PagoElectronico.Retiros
{
    public partial class GenerarRetiroForm : Form
    {
        NumberFormatInfo provider = new NumberFormatInfo();
        
        List<Banco> bancos;
        Cuenta cuentaARetirar;
        public GenerarRetiroForm(Cuenta cuenta)
        {
            InitializeComponent();
            CenterToScreen();
            cargarComboBancos();
            MonedaDB.cargarMonedas(comboMonedas.Items);
            cuentaARetirar = cuenta;
            provider.NumberDecimalSeparator = ".";
        }

        private void cargarComboBancos()
        {
            bancos = BancoDB.obtenerBancos();
            foreach (Banco banco in bancos)
            {
                comboBancos.Items.Add(banco.nombre + " " + banco.codigo);
            }
        }

        private void botonRetirar_Click(object sender, EventArgs e)
        {
            if (!(importeText.Text == ""))
            {
                if (Convert.ToDouble(importeText.Text, provider) <= cuentaARetirar.saldo)
                {
                    if (comboMonedas.Text == "Dólar")
                    {
                        generarCheque();
                    }
                    else { MessageBox.Show("El importe debe ser en Dolares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("No tiene suficiente saldo en la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generarCheque()
        {
            if (!(comboBancos.Text == ""))
            {

                Banco bancoSelec = bancos.Find(banco => banco.nombre + " " + banco.codigo == comboBancos.Text);
                double codigoRetiro = RetiroDB.obtenerUlltimoCodigo();
                if (codigoRetiro != -1)
                {
                    codigoRetiro++;
                }
                else { codigoRetiro = 18181818181; }
                RetiroDB.insertarRetiro(codigoRetiro, Convert.ToDouble(importeText.Text, provider), comboMonedas.Text, cuentaARetirar);
                double codigoCheque = RetiroDB.obtenerUlltimoCodigo();
                if (codigoCheque != -1)
                {
                    codigoCheque++;
                }
                else { codigoRetiro = 25252525252; }
                ChequeDB.insertarCheque(bancoSelec, cuentaARetirar.idPropietario, Convert.ToDouble(importeText.Text, provider), comboMonedas.Text, codigoCheque, codigoRetiro);
                cuentaARetirar.saldo = cuentaARetirar.saldo - Convert.ToDouble(importeText.Text, provider);
                string fecha = PagoElectronico.Dominio.Config.fechaSystem();
                ChequeForm cheque = new ChequeForm(comboBancos.Text,Convert.ToString(codigoCheque),cuentaARetirar,fecha,importeText.Text);
                this.Close();
                cheque.ShowDialog();
            }
            else { MessageBox.Show("Banco Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void importeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloDecimales(e,importeText);
        }
    }
}
