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
            this.cargarDomicilio();

            DB.PaisDB.insertar(boxPais.Text);
            int idPais = DB.PaisDB.getID(boxPais.Text);

            DB.DocumentoDB.insertar(comboBoxTipoDoc.Text);
            int idTipoDoc = DB.DocumentoDB.getID(comboBoxTipoDoc.Text);

            cliente = new PagoElectronico.Dominio.Cliente();
            cliente.nombre = this.boxNombre.Text;
            cliente.apellido = this.boxApellido.Text;
            cliente.tipo_doc = idTipoDoc;
            cliente.documento = Convert.ToInt32(this.boxDocumento.Text);
            cliente.domicilio.calle = this.boxCalle.Text;
            cliente.domicilio.numero = Convert.ToInt32(this.boxAltura.Text);
            cliente.domicilio.piso = Convert.ToInt32(this.boxPiso.Text);
        }
 */

        private bool validarCampos()
        {
            bool valido = true;
            if (boxNombre.Text == "") {
                valido = false;
                labelErrorNom.Visible = true;
            };
            if (boxApellido.Text == "") {
                valido = false;
                labelErrorApe.Visible = true;
            };
            if (boxPais.Text == "") {
                valido = false;
                labelErrorPais.Visible = true;
            };
            if (comboBoxTipoDoc.Text == "") {
                valido = false;
                labelErrorTDoc.Visible = true;
            };
            if (boxDocumento.Text == "") {
                valido = false;
                labelErrorNDoc.Visible = true;
            };
            if (boxCalle.Text == "") {
                valido = false;
                labelErrorCal.Visible = true;
            };
            if (boxAltura.Text == "") {
                valido = false;
                labelErrorAlt.Visible = true;
            };
            if (boxDepto.Text == "") {
                valido = false;
                labelErrorDep.Visible = true;
            };
            if (boxPiso.Text == "") {
                valido = false;
                labelErrorPiso.Visible = true;
            };
            return valido;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                int id_domi = insertarDomicilio();
                if (DB.DocumentoDB.validar(comboBoxTipoDoc.Text) && DB.PaisDB.validar(boxPais.Text))
                {
                    double id_docu = DB.DocumentoDB.getID(comboBoxTipoDoc.Text);
                    double id_pais = DB.PaisDB.getID(boxPais.Text);
                    insertarCliente(id_domi, id_docu, id_pais);
                }
            }

        }

        private void insertarCliente(int id_domi, double id_docu, double id_pais)
        {
            PagoElectronico.Dominio.Cliente cliente = new PagoElectronico.Dominio.Cliente();
            cliente.nombre = this.boxNombre.Text;
            cliente.apellido = this.boxApellido.Text;
            cliente.mail = this.boxMail.Text;
            cliente.domicilio = id_domi;
            cliente.tipo_doc = id_docu;
            cliente.pais = id_pais;
            cliente.documento = Convert.ToInt32(boxDocumento.Text);
        
            DB.ClienteDB.insertar(cliente);
        }

        private int insertarDomicilio()
        {
            PagoElectronico.Dominio.Domicilio domicilio = new PagoElectronico.Dominio.Domicilio();
            domicilio.calle = boxCalle.Text;
            domicilio.numero = Convert.ToInt32(boxAltura.Text);
            domicilio.piso = Convert.ToInt32(boxPiso.Text);
            domicilio.depto = boxDepto.Text;
            DB.DomicilioDB.insertar(domicilio);
            int id = DB.DomicilioDB.getID(domicilio);
            return id;
        }

        private double validarPais()
        {
            DB.PaisDB.validar(boxPais.Text);
            return DB.PaisDB.getID(boxPais.Text);
        }

        private double validarDocumento()
        {
            DB.DocumentoDB.validar(comboBoxTipoDoc.Text);
            return DB.DocumentoDB.getID(comboBoxTipoDoc.Text);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
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

        private void boxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
