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
    public partial class ABMClienteForm : Form
    {
        public PagoElectronico.InicioForm padre ;

        public ABMClienteForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnClosed(EventArgs e)
        {
            Owner.Show();
            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliForm alta = new AltaCliForm();
            alta.Owner = this;
            alta.Show();
        }

    }
}
