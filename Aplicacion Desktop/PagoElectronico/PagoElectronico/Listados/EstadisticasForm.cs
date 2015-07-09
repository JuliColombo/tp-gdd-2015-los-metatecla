using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Listados
{
    public partial class EstadisticasForm : Form
    {
        public EstadisticasForm()
        {
            InitializeComponent();
            cargarAnios();
        }

        private void cargarAnios()
        {
            int contador = 15; //Se buscarán 15 años hacia atrás
            int año = Convert.ToInt32(Dominio.Config.fechaSystem().Substring(0, 4));
            while (contador != 0)
            {
                comboBoxAño.Items.Add(año);
                año--;
                contador--;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarVacios())
            {
                labelError.Visible = false;
                labelCargando.Visible = true;
                this.Refresh();
                ejecutarConsulta();
                labelCargando.Visible = false;
            }
        }

        private void ejecutarConsulta(){
            List<int> trimestre = cargarMeses();
            switch (comboBoxListado.Text)
            {
                case "Clientes con cuentas inhabilitadas":
                    listado.DataSource = DB.ListadoDB.CliCuentasInhabilitadas(comboBoxAño.Text, trimestre);
                    break;
                case "Cliente con mayor comisión":
                    listado.DataSource = DB.ListadoDB.cliComisiones(comboBoxAño.Text, trimestre);
                    break;
                case "Clientes con mayores transacciones propias":
                    listado.DataSource = DB.ListadoDB.cliTransacciones(comboBoxAño.Text, trimestre);
                    break;
                case "Paises con mayores movimientos":
                    listado.DataSource = DB.ListadoDB.movimientosPaises(comboBoxAño.Text, trimestre);
                    break;
                case "Facturación por tipo de cuenta":
                    listado.DataSource = DB.ListadoDB.tipoCuentaFact(comboBoxAño.Text, trimestre);
                    break;
            }
        }

        private bool validarVacios()
        {
            bool valida = true;
            if ((comboBoxAño.Text == "") || (comboBoxTrimestre.Text == "") || (comboBoxListado.Text == ""))
            {
                valida = false;
                labelError.Visible = true;
            }
            return valida;
        }

        private List<int> cargarMeses()
        {
            List<int> trimestre = new List<int>();
            switch(comboBoxTrimestre.Text){
                case "Enero - Febrero - Marzo": 
                    trimestre.Add(1);
                    trimestre.Add(2);
                    trimestre.Add(3);
                    break;
                case "Abril - Mayo - Junio":
                    trimestre.Add(4);
                    trimestre.Add(5);
                    trimestre.Add(6);
                    break;
                case "Julio - Agosto - Septiembre":
                    trimestre.Add(7);
                    trimestre.Add(8);
                    trimestre.Add(9);
                    break;
                case "Octubre - Noviembre - Diciembre":
                    trimestre.Add(10);
                    trimestre.Add(11);
                    trimestre.Add(12);
                    break;
            }
            return trimestre;
        }
    }
}
