using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Consulta_Saldos
{
    public partial class ConsultaSaldoForm : Form
    {
        public ConsultaSaldoForm(Dominio.Cuenta cuenta)
        {
            InitializeComponent();
            cargarDepositos(cuenta);
            cargarRetiros(cuenta);
            cargarTransferencias(cuenta);
            mostrarSaldo(cuenta);
        }

        private void mostrarSaldo(PagoElectronico.Dominio.Cuenta cuenta)
        {
            label_saldo.Text = cuenta.saldo.ToString();
        }

        private void cargarTransferencias(PagoElectronico.Dominio.Cuenta cuenta)
        {
            List<Dominio.Transferencia> transferencias = DB.CuentaDB.getUltimas10Transferencias(cuenta.numero);
            
            DataTable Tabla = new DataTable();

            Tabla.Columns.Add(new DataColumn("Cuenta Destino"));
            Tabla.Columns.Add(new DataColumn("Fecha"));
            Tabla.Columns.Add(new DataColumn("Moneda"));
            Tabla.Columns.Add(new DataColumn("Importe"));

            foreach (Dominio.Transferencia transferencia in transferencias)
            {

                DataRow Renglon = Tabla.NewRow();
                Renglon[0] = transferencia.cuenta_destino.ToString();
                Renglon[1] = transferencia.fecha.ToString();
                Renglon[2] = DB.MonedaDB.getMoneda(transferencia.moneda);
                Renglon[3] = transferencia.importe.ToString();


                Tabla.Rows.Add(Renglon);
                
            }
            listado_transferencias.DataSource = Tabla;
        }

        private void cargarRetiros(PagoElectronico.Dominio.Cuenta cuenta)
        {
            List<Dominio.Operacion> retiros = DB.CuentaDB.getUltimos5Retiros(cuenta.numero);

            DataTable Tabla = crearTablaOperacion();

            foreach (Dominio.Operacion retiro in retiros)
            {

                cargarGrilla(listado_retiros, retiro, Tabla);
            }

            listado_retiros.DataSource = Tabla;
        }


        private void cargarDepositos(PagoElectronico.Dominio.Cuenta cuenta)
        {
            List<Dominio.Operacion> depositos = DB.CuentaDB.getUltimos5Depositos(cuenta.numero);

            DataTable Tabla = crearTablaOperacion();
            
            foreach (Dominio.Operacion deposito in depositos)
            {

                cargarGrilla(listado_depositos, deposito, Tabla);
            }
            listado_depositos.DataSource = Tabla;
        }

        public void cargarGrilla(DataGridView grilla, Dominio.Operacion op, DataTable Tabla)
        {
            

            DataRow Renglon = Tabla.NewRow();
            Renglon[0] = op.codigo.ToString();
            Renglon[1] = op.fecha.ToString();
            Renglon[2] = DB.MonedaDB.getMoneda(op.moneda);
            Renglon[3] = op.importe.ToString();


            Tabla.Rows.Add(Renglon);
                      
        }

        private static DataTable crearTablaOperacion()
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add(new DataColumn("Código"));
            Tabla.Columns.Add(new DataColumn("Fecha"));
            Tabla.Columns.Add(new DataColumn("Moneda"));
            Tabla.Columns.Add(new DataColumn("Importe"));
            return Tabla;
        }

    }
    
}
