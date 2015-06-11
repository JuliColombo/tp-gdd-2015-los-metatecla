using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;

namespace PagoElectronico.Retiros
{
    public partial class ChequeForm : Form
    {
        public ChequeForm(string banco, string codigo, Cuenta cuenta, string fecha, string importe)
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            labelBanco.Parent = pictureBox1; 
            labelBanco.BackColor = Color.Transparent;
            labelCodigo.Parent = pictureBox1;
            labelCodigo.BackColor = Color.Transparent;
            labelCliente.Parent = pictureBox1;
            labelCliente.BackColor = Color.Transparent;
            labelFecha.Parent = pictureBox1;
            labelFecha.BackColor = Color.Transparent;
            labelImporte.Parent = pictureBox1;
            labelImporte.BackColor = Color.Transparent; 
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            labelImporte.Text = string.Format("{0:0.00}",Convert.ToDouble(importe,provider));
            labelFecha.Text = fecha;
            labelCliente.Text = cuenta.dueño.apellido + ", " + cuenta.dueño.nombre;
            labelCodigo.Text = codigo;
            labelBanco.Text = banco;


        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
