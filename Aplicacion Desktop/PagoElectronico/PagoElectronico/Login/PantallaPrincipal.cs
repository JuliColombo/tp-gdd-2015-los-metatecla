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
        public List<Dominio.Cuenta> cuentas = new List<Dominio.Cuenta>();

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
            cargarCuentas();
        }

        private void cargarCuentas()
        {
            
            cuentas = DB.CuentaDB.obtenerCuentasCliente(cliente);

            foreach(Dominio.Cuenta c in cuentas)
            {

            DataTable Tabla = new DataTable();
            Tabla.Columns.Add(new DataColumn("Numero"));
            Tabla.Columns.Add(new DataColumn("Fecha de Creacion"));
            Tabla.Columns.Add(new DataColumn("Fecha de Cierre"));
            Tabla.Columns.Add(new DataColumn("Moneda"));
            Tabla.Columns.Add(new DataColumn("Tipo"));
            Tabla.Columns.Add(new DataColumn("Saldo"));

            DataRow Renglon = Tabla.NewRow();
            Renglon[0] = c.numero.ToString();
            Renglon[1] = c.fecha_creacion.ToString();
            Renglon[2] = c.fecha_cierre.ToString();
            Renglon[3] = DB.MonedaDB.getMoneda(c.moneda);
            Renglon[4] = DB.TipoCuentaDB.getTipo(c.tipo);
            Renglon[5] = c.saldo.ToString();

            Tabla.Rows.Add(Renglon);
            listadoCuentas.DataSource = Tabla;
            }
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

        private void btnABMTarjetas_Click(object sender, EventArgs e)
        {
            Form f = new ABM_Cliente.BuscadorTarjetas(cliente.id, cliente.nombre + " " + cliente.apellido);
            f.ShowDialog();
        }

        private void btn_modifCuenta_Click(object sender, EventArgs e)
        {
            if (listadoCuentas.SelectedRows.Count == 1)
            {
                Dominio.Cuenta cuenta = cuentas.Find(c => c.numero == Convert.ToInt64(listadoCuentas.CurrentRow.Cells[0].Value));
                labelErrorSeleccion.Visible = false;

                Form f = new ABM_Cuenta.CrearCuentaForm(cuenta);
                f.ShowDialog();
                cargarCuentas();
                
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
            
        }


    }
}
