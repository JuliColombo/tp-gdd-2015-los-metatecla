using System;
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
    public partial class GenerarRetiroForm : Form
    {
        public GenerarRetiroForm(Cuenta cuenta)
        {
            InitializeComponent();
        }
    }
}
