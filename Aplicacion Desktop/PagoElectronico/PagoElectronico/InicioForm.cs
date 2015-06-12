using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.ABM_Rol;
using PagoElectronico.Dominio;
using PagoElectronico.Retiros;
using PagoElectronico.Transferencias;

namespace PagoElectronico
{
    public partial class InicioForm : Form
    {
        public string texto;

        public InicioForm()
        {
            InitializeComponent();

        }


        private void btn_alta_cliente_Click(object sender, EventArgs e)
        {
            Form f = new PagoElectronico.ABM_Cliente.BuscadorCliForm();
            f.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form f = new PagoElectronico.Login.LoginForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new PagoElectronico.ABM_Cuenta.CrearCuentaForm();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMRolForm rol = new ABMRolForm();
            rol.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new PagoElectronico.Depositos.SeleccionarClienteForm();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        { //Creamos un cliente para probar
            Cliente cli = new Cliente();
            cli.id = 1;
            cli.nombre = "pepe";
            cli.apellido = "gomez";
            cli.documento = 13372098;
            cli.tipo_doc = 10002;
            SeleccionDeCuentaForm selec = new SeleccionDeCuentaForm(cli);
            selec.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.id = 1;
            cli.nombre = "pepe";
            cli.apellido = "gomez";
            cli.documento = 13372098;
            cli.tipo_doc = 10002;
            SeleccionDeCuentaTransForm selec = new SeleccionDeCuentaTransForm(cli);
            selec.ShowDialog();
        }

    }
}
