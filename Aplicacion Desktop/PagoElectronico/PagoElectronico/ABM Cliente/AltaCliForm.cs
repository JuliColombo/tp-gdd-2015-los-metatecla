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
    public partial class AltaCliForm : Form
    {
        PagoElectronico.Dominio.Cliente cliente;

        public AltaCliForm()
        {
            InitializeComponent();
        }

        private void AltaCliForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

  /*    ESTO ESTA SIN TERMINAR (IGUAL NI SE ESTA USANDO)
        private void cargarCliente()
        {
            cliente = new PagoElectronico.Dominio.Cliente();
            cliente.nombre = this.boxNombre.Text;
            cliente.apellido = this.boxApellido.Text;
            cliente.tipo_doc = this.comboBoxTipoDoc.Text;
            cliente.documento = Convert.ToInt32(this.boxDocumento.Text);
            cliente.domicilio.calle = this.boxCalle.Text;
            cliente.domicilio.numero = Convert.ToInt32(this.boxAltura.Text);
            cliente.domicilio.piso = Convert.ToInt32(this.boxPiso.Text);
        }
  */

        private bool validarCampos()
        {
            if (boxNombre.Text == "") {return false;};
            if (boxApellido.Text == "") {return false;};
            if (boxPais.Text == "") {return false;};
            if (comboBoxTipoDoc.Text == "") {return false;};
            if (boxDocumento.Text == "") {return false;};
            if (boxCalle.Text == "") {return false;};
            if (boxAltura.Text == "") { return false; };
            if (boxDepto.Text == "") { return false; };
            if (boxPiso.Text == "") { return false; };
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.validarCampos();
            int id_domicilio = this.insertarDomicilio();
            int id_pais = this.insertarPais();
            int tipo_doc = this.insertarDocumento();
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            /*FALTA LA FECHA DE NACIMIENTO*/
            conexion.query = "INSERT INTO LOS_METATECLA.Cliente (Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, " + 
                "Cli_Pais_Codigo, Id_Domicilio, Cli_Mail) values ('" + boxNombre.Text + "', '" + boxApellido.Text +
                "', '" + tipo_doc + "', '" + boxDocumento.Text + "', '" + id_pais + "', '" + id_domicilio + "', '" +
                boxMail.Text + "')";
            conexion.ejecutarNoQuery();
        }

        private int insertarDomicilio()
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = "INSERT INTO LOS_METATECLA.Domicilio (Dom_Calle, Dom_Nro, Dom_Piso, Dom_Depto) values ('" + 
                boxCalle.Text + "', '" + boxAltura.Text + "', '" + boxPiso.Text + "', '" + boxDepto.Text + "')";
            conexion.ejecutarNoQuery();
            conexion.query = "SELECT Id_Domicilio FROM LOS_METATECLA.Domicilio WHERE Dom_Calle = '" + boxCalle.Text +
                "' AND Dom_Nro = '" + boxAltura.Text + "' AND Dom_Piso = '" + boxPiso.Text + "' AND Dom_Depto = '" 
                + boxDepto.Text + "'";
            conexion.ejecutarQuery();
            int id = conexion.lector.GetInt32(0);
            conexion.cerrarConexion();
            return id;
        }

        private int insertarPais()
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = "INSERT INTO LOS_METATECLA.PAIS (Pais_Desc) values ('" + boxPais.Text + "')";
            conexion.ejecutarNoQuery();
            conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = "SELECT Pais_Codigo FROM LOS_METATECLA.Pais WHERE Pais_desc = '" + boxPais.Text + "'";
            conexion.ejecutarQuery();
            int id = conexion.lector.GetInt32(0);
            conexion.cerrarConexion();
            return id;
        }

        private int insertarDocumento()
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = "INSERT INTO LOS_METATECLA.Documento (Doc_Tipo_Desc) values ('" + comboBoxTipoDoc.Text + "')";
            conexion.ejecutarNoQuery();
            conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = "SELECT Doc_Tipo_Cod FROM LOS_METATECLA.Documento WHERE Doc_Tipo_Desc = '" + comboBoxTipoDoc.Text + "'";
            conexion.ejecutarQuery();
            int id = conexion.lector.GetInt32(0);
            conexion.cerrarConexion();
            return id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxPiso.Text = "";
            boxPais.Text = "";
            boxNombre.Text = "";
            boxMail.Text = "";
            boxFecha.Text = "";
            boxDocumento.Text = "";
            boxDepto.Text = "";
            boxCalle.Text = "";
            boxApellido.Text = "";
            boxAltura.Text = "";
            comboBoxTipoDoc.Text = "";
        }

    }
}
