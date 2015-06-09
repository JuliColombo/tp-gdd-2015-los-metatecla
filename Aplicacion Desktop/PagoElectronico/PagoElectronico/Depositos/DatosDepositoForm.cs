using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Depositos
{
    public partial class DatosDepositoForm : Form
    {
       
        public DatosDepositoForm(PagoElectronico.Dominio.Cliente cliente)
        {
            InitializeComponent();

            label_apellido.Text = cliente.apellido;
            label_documento.Text = cliente.documento.ToString();
            label_nombre.Text = cliente.nombre;

            DB.MonedaDB.cargarMonedas(comboBox_moneda.Items);
            
           foreach(double numero in cliente.numeros_cuentas){
                comboBox_cuenta.Items.Add(numero);
            }

           foreach (double tarjeta in cliente.numeros_tarjetas)
           {
               comboBox_tarjeta.Items.Add(tarjeta);
           }
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {

        }
    }
}
