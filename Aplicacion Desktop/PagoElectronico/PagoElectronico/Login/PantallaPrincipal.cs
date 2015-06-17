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
        public Dominio.Rol rol { get; set; }
        public List<Dominio.Cuenta> cuentas = new List<Dominio.Cuenta>();

        public PantallaPrincipal(int idCli, int idRol)
        {
            InitializeComponent();
            cliente = DB.ClienteDB.getCliente(idCli);
            rol = DB.RolDB.getRol(idRol);
            cargarComponentes();
            botonesHabilitados();
        }

        private void botonesHabilitados()
        {
            groupAdm.Visible = false;
            if (!rol.funcionalidades.Exists(func => func.nombre == "ABM Rol"))
            {
                buttonABMRol.Visible = false;

            }
            else { groupAdm.Visible = true; }
            if (!rol.funcionalidades.Exists(func => func.nombre == "ABM Usuario"))
            { buttonUsuarios.Visible = false;

            }
            else { groupAdm.Visible = true; }
            if (!rol.funcionalidades.Exists(func => func.nombre == "ABM Cliente"))
            {
                buttonClientes.Visible = false;

            }
            else { groupAdm.Visible = true; }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Listado Estadístico"))
            {
                buttonEstadisticas.Visible = false;
            }
            else { groupAdm.Visible = true; }
            if (!rol.funcionalidades.Exists(func => func.nombre == "ABM Cuenta"))
            {
                btn_cerrarCuenta.Visible = false;
                btn_modifCuenta.Visible = false;
                btn_nuevaCuenta.Visible = false;
                
            }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Depósito"))
            {
                btnDeposito.Visible = false;
            }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Retiro"))
            {
                btnRetiro.Visible = false;
            }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Transferencia"))
            {
                btnTransferencia.Visible = false;
            }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Facturación"))
            {
                buttonFacturacion.Visible = false;
            }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Consulta de Saldos"))
            {
                btn_listadoSaldo.Visible = false;
            }
            if (!rol.funcionalidades.Exists(func => func.nombre == "Asociar tarjetas"))
            {
                btnABMTarjetas.Visible = false;
            }


            
        }
        private void cargarComponentes()
        {
            labelNomYApe.Text = cliente.apellido + ", " + cliente.nombre;
            labelDoc.Text = cliente.documento.ToString();
            cargarCuentas();
        }

        private void cargarCuentas()
        {
            
            cuentas = DB.CuentaDB.obtenerCuentasAbiertasCliente(cliente);

            DataTable Tabla = new DataTable();
            Tabla.Columns.Add(new DataColumn("Número"));
            Tabla.Columns.Add(new DataColumn("Fecha de Creación"));
            Tabla.Columns.Add(new DataColumn("Fecha de Cierre"));
            Tabla.Columns.Add(new DataColumn("Moneda"));
            Tabla.Columns.Add(new DataColumn("Tipo"));
            Tabla.Columns.Add(new DataColumn("Saldo"));

            foreach(Dominio.Cuenta c in cuentas)
            {

     
            DataRow Renglon = Tabla.NewRow();
            Renglon[0] = c.numero.ToString();
            Renglon[1] = c.fecha_creacion.ToString();
            Renglon[2] = c.fecha_cierre.ToString();
            Renglon[3] = DB.MonedaDB.getMoneda(c.moneda);
            Renglon[4] = DB.TipoCuentaDB.getTipo(c.tipo);
            Renglon[5] = c.saldo.ToString();

            Tabla.Rows.Add(Renglon);
            
            }

            listadoCuentas.DataSource = Tabla;
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

        private void btn_listadoSaldo_Click(object sender, EventArgs e)
        {
            if (listadoCuentas.SelectedRows.Count == 1)
            {
                Dominio.Cuenta cuenta = cuentas.Find(c => c.numero == Convert.ToInt64(listadoCuentas.CurrentRow.Cells[0].Value));
                labelErrorSeleccion.Visible = false;

                Form f = new Consulta_Saldos.ConsultaSaldoForm(cuenta);
                f.ShowDialog();
                
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
        }

        private void btn_cerrarCuenta_Click(object sender, EventArgs e)
        {
            if (listadoCuentas.SelectedRows.Count == 1)
            {
                Form f;
                long nro_cuenta = Convert.ToInt64(listadoCuentas.CurrentRow.Cells[0].Value);

                if(noTieneTransaccionesPendientes(nro_cuenta)){
                DB.CuentaDB.cerrarCuenta(nro_cuenta);
               
                f = new UI.ExitoForm("Cuenta cerrada con éxito");
                f.ShowDialog();

                cargarCuentas();

                } else {
                    f = new UI.ErrorForm("No se puede cerrar esta cuenta." + 'n' + "Todos los costos de las transacciones pendientes deben estar pagos");
                } 
            }
            else
            {
                labelErrorSeleccion.Visible = true;
            }
        }

        private bool noTieneTransaccionesPendientes(long nro_cuenta)
        {
            return !DB.CuentaDB.tienePagosPendientes(nro_cuenta);
        }

        private void btn_nuevaCuenta_Click(object sender, EventArgs e)
        {
            Form f = new ABM_Cuenta.CrearCuentaForm();
            f.ShowDialog();

            cargarCuentas();
        }


    }
}
