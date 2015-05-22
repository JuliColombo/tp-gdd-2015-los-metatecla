using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class InicioForm : Form
    {
        public string texto;

        public InicioForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoElectronico.ABM_Cliente.ABMClienteForm ventanaABMCliente = new PagoElectronico.ABM_Cliente.ABMClienteForm();
            ventanaABMCliente.Owner = this;
            ventanaABMCliente.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = "INSERT INTO LOS_METATECLA.Cliente (Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, Cli_Pais_Codigo, Id_Domicilio)" +
                                "values ('" + "juli" + "', 10002, 100, 132, 54)";
            conexion.ejecutarNoQuery();
        }

    }
}
