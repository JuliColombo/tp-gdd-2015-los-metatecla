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
    public partial class BuscadorTarjetas : Form
    {
        public int idCliente { get; set; }

        public BuscadorTarjetas()
        {
            InitializeComponent();
        }

        public BuscadorTarjetas(int idCli, string cliente)
        {
            InitializeComponent();
            this.idCliente = idCli;
            buscarTarjetas();
            labelCliente.Text = cliente;        
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            AMTarjeta at = new AMTarjeta(idCliente);
            at.Owner = this;
            at.ShowDialog();
            buscarTarjetas();
        }

        private void buscarTarjetas()
        {
            listaTarjetas.DataSource = DB.TarjetaDB.buscarTarjetas(idCliente);
        }

        private void btnDesasociar_Click(object sender, EventArgs e)
        {
            if (listaTarjetas.SelectedRows.Count == 1)
            {
                string ultimos4 = Convert.ToString(listaTarjetas.CurrentRow.Cells[0].Value);
                DB.TarjetaDB.darDeBaja(ultimos4, idCliente);
                buscarTarjetas();
                labelErrorSeleccion.Visible = false;
                MessageBox.Show("Tarjeta desasociada correctamente");
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
        }
    }
}
