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
        public ABTarjetas()
        {
            InitializeComponent();
        }

        public ABTarjetas(int idCliente, string cliente)
        {
            InitializeComponent();
            listaTarjetas.DataSource = DB.TarjetaDB.buscarTarjetas(idCliente);
            labelCliente.Text = cliente;
        }
    }
}
