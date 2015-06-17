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
    public partial class PantallaPrincipalAdmin : Form
    {
        public PantallaPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            Form f = new Listados.EstadisticasForm();
            f.ShowDialog();
        }
    }
}
