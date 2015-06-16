using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;
using PagoElectronico.DB;
using System.Data.SqlClient;

namespace PagoElectronico.Facturacion
{
    public partial class FacturacionForm : Form
    {
        Cliente cliente;
        List<Cuenta> cuentas = new List<Cuenta>();
        DataTable tablaFactura = new DataTable();
        public FacturacionForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CenterToScreen();
            cargarComboCuentas();
            cargarDataFactura();
            labelCosto.Text = "";
            labelTipo.Text = "";

        }

        public void cargarDataFactura()
        {
            foreach (Cuenta cuenta in cuentas) 
            {
               FacturaDB.obtenerItemsFactura(cuenta, tablaFactura);
            }
            dataFactura.DataSource = tablaFactura;
            dataFactura.Columns[0].Visible = false;
            dataFactura.Columns[3].Visible = false;
            dataFactura.Columns[4].Visible = false;
            dataFactura.Columns[1].HeaderText = "Descripcion";
            dataFactura.Columns[2].HeaderText = "Importe";
            dataFactura.Columns[5].HeaderText = "Numero Cuenta";
            dataFactura.Columns[5].Width = 125;
            dataFactura.Columns[1].Width = 175;
            tablaFactura = new DataTable();
        }


        public void cargarComboCuentas()
        {
            cuentas = CuentaDB.obtenerCuentasCliente(this.cliente);
            foreach (Cuenta cuenta in cuentas)
            {

                comboCuentas.Items.Add(Convert.ToInt64(cuenta.numero));
            }
        }

        private void comboCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboCuentas_SelectedValueChanged(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            cuenta = cuentas.Find(cta => cta.numero == (Convert.ToDouble(comboCuentas.Text)));
            labelTipo.Text = TipoCuentaDB.getTipo(cuenta.tipo);
            labelCosto.Text =string.Format("{0:0.00}", TipoCuentaDB.obtenerCosto(cuenta.tipo).costoApertura);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(labelCosto.Text);
            int cantsus = Convert.ToInt32(textSuscrip.Text);
            double importe = costo*cantsus;
            string str = string.Format("Costo por Suscripcion (Cant. {0})",textSuscrip.Text);
            FacturaDB.insertarItemPendiente(str, importe, Convert.ToInt64(comboCuentas.Text),cantsus);
            cargarDataFactura();
        }

        private void textSuscrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void bontonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonFactura_Click(object sender, EventArgs e)
        {
            FacturaDB.insertarFactura(cliente.id, dataFactura.Rows);



        }
    }
}

