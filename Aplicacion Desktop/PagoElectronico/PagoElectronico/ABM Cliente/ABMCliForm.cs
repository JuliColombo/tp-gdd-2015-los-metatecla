﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ABMCliForm : Form
    {
        public int idCliente { get; set; }

        public ABMCliForm()
        {
            InitializeComponent();
            DB.PaisDB.cargarPaises(comboBoxPais.Items);
        }

        public ABMCliForm(int id)
        {
            idCliente = id;
            InitializeComponent();
            DB.PaisDB.cargarPaises(comboBoxPais.Items);

            if (idCliente != 0)
            {
                this.cargarCamposAModificar();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private bool validarCampos()
        {
            bool valido = true;
            int doc = 0;
            if (boxNombre.Text == "") {
                valido = false;
                labelErrorNom.Visible = true;
            };
            if (boxApellido.Text == "") {
                valido = false;
                labelErrorApe.Visible = true;
            };
            if (comboBoxPais.Text == ""){
                valido = false;
                labelErrorPais.Visible = true;
            };
            if (comboBoxTipoDoc.Text == "") {
                valido = false;
                labelErrorTDoc.Visible = true;
            };
            if (boxDocumento.Text == ""){
                valido = false;
                labelErrorNDoc.Visible = true;
            }else{
                doc = Convert.ToInt32(boxDocumento.Text);
            }
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
            if (DB.ClienteDB.mailRepetido(boxMail.Text)){
                valido = false;
                labelErrorMail.Visible = true;
            }
            if (DB.ClienteDB.documentoRepetido(doc) && DB.DocumentoDB.validar(comboBoxTipoDoc.Text)){
                valido = false;
                labelErrorTyNDoc.Visible = true;
            }
            return valido;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                int id_domi = insertarDomicilio();
                if (DB.DocumentoDB.validar(comboBoxTipoDoc.Text) && DB.PaisDB.validar(comboBoxPais.Text))
                {
                    double id_docu = DB.DocumentoDB.getID(comboBoxTipoDoc.Text);
                    double id_pais = DB.PaisDB.getID(comboBoxPais.Text);
                    insertarCliente(id_domi, id_docu, id_pais);
                    this.limpiar();

                    Form exito = new AltaClienteExitoForm();
                    exito.ShowDialog();
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
            cliente.fecha_nac = boxFecha.Text;
        
            DB.ClienteDB.insertar(cliente);
        }

        private int insertarDomicilio()
        {
            PagoElectronico.Dominio.Domicilio domicilio = new PagoElectronico.Dominio.Domicilio();
            domicilio.calle = boxCalle.Text;
            domicilio.numero = Convert.ToInt32(boxAltura.Text);
            domicilio.piso = Convert.ToInt32(boxPiso.Text);
            domicilio.depto = boxDepto.Text;
            if (!DB.DomicilioDB.yaExiste(domicilio)) {
                DB.DomicilioDB.insertar(domicilio);
            }
            int id = DB.DomicilioDB.getID(domicilio);
            return id;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            boxPiso.Text = "";
            comboBoxPais.Text = "";
            boxNombre.Text = "";
            boxMail.Text = "";
            boxFecha.Text = "";
            boxDocumento.Text = "";
            boxDepto.Text = "";
            boxCalle.Text = "";
            boxApellido.Text = "";
            boxAltura.Text = "";
            comboBoxTipoDoc.Text = "";
            labelErrorMail.Visible = false;
            labelErrorAlt.Visible = false;
            labelErrorApe.Visible = false;
            labelErrorCal.Visible = false;
            labelErrorDep.Visible = false;
            labelErrorFec.Visible = false;
            labelErrorNDoc.Visible = false;
            labelErrorNom.Visible = false;
            labelErrorPais.Visible = false;
            labelErrorPiso.Visible = false;
            labelErrorTDoc.Visible = false;
            labelErrorTyNDoc.Visible = false;
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

        private void AltaCliForm_Load(object sender, EventArgs e)
        {

        }

        private void boxDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarCamposAModificar()
        {
                Dominio.Cliente cliente = DB.ClienteDB.getCliente(this.idCliente);
                Dominio.Domicilio domicilio = DB.DomicilioDB.getDomicilio(cliente.domicilio);
                string pais = DB.PaisDB.getPais(cliente.pais);
                string tipo_doc = DB.DocumentoDB.getTipoDoc(cliente.tipo_doc);

                boxApellido.Text = cliente.apellido;
                boxNombre.Text = cliente.nombre;
                boxMail.Text = cliente.mail;
                boxFecha.Text = cliente.fecha_nac;
                boxDocumento.Text = Convert.ToString(cliente.documento);
                boxCalle.Text = domicilio.calle;
                boxAltura.Text = Convert.ToString(domicilio.numero);
                boxPiso.Text = Convert.ToString(domicilio.piso);
                boxDepto.Text = domicilio.depto;
                comboBoxPais.Text = pais;
                comboBoxTipoDoc.Text = tipo_doc;
        }

    }
}