using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class PantallaPrincipal : Form
    {
        public Dominio.Cliente cliente { get; set; }

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        public PantallaPrincipal(int idCli)
        {
            InitializeComponent();
            cliente = DB.ClienteDB.getCliente(idCli);
            cargarComponentes();
        }

        private void cargarComponentes()
        {
            labelNomYApe.Text = cliente.apellido + ", " + cliente.nombre;
            labelDoc.Text = cliente.documento.ToString();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Form f = new Depositos.DatosDepositoForm(cliente);
            f.ShowDialog();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Form f = new Transferencias.SeleccionDeCuentaTransForm(cliente);
            f.ShowDialog();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Form f = new Retiros.SeleccionDeCuentaForm(cliente);
            f.ShowDialog();
        }


    }
}
