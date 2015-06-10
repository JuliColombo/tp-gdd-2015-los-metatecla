using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ABTarjetas : Form
    {
        public int idCliente { get; set; }

        public ABTarjetas()
        {
            InitializeComponent();
        }

        public ABTarjetas(int idCli, string cliente)
        {
            InitializeComponent();
            this.idCliente = idCli;
            listaTarjetas.DataSource = DB.TarjetaDB.buscarTarjetas(idCliente);
            labelCliente.Text = cliente;        
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            AltaTarjeta at = new AltaTarjeta(idCliente);
            at.Owner = this;
            at.ShowDialog();
            listaTarjetas.DataSource = DB.TarjetaDB.buscarTarjetas(idCliente);
        }
    }
}
