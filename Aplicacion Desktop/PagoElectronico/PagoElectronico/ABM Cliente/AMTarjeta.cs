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
    public partial class AMTarjeta : Form
    {
        public int idCliente {get; set;}

        public AMTarjeta()
        {
            InitializeComponent();
        }

        public AMTarjeta(int idCli)
        {
            InitializeComponent();
            DB.EmisorDB.cargarEmisores(comboBoxEmisores.Items);
            this.idCliente = idCli;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            boxNumero.Text = "";
            boxCodSeguridad.Text = "";
            comboBoxEmisores.Text = "";
            boxFechaEmision.Text = "";
            boxFechaVencimiento.Text = "";

            labelErrorFVenc.Visible = false;
            labelErrorNro.Visible = false;
            labelErrorFEmision.Visible = false;
            labelErrorEmisor.Visible = false;
            labelErrorCod.Visible = false;
        }

        private void boxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void boxCodSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private bool validarCamposVacios()
        {
            bool valido = true;
            if (boxNumero.Text == "")
            {
                valido = false;
                labelErrorNro.Visible = true;
            }
            if (boxCodSeguridad.Text == "")
            {
                valido = false;
                labelErrorCod.Visible = true;
            }
            if (comboBoxEmisores.Text == "")
            {
                valido = false;
                labelErrorEmisor.Visible = true;
            }
            if (boxFechaEmision.Text == "  /  /")
            {
                valido = false;
                labelErrorFEmision.Visible = true;
            }
            if (boxFechaVencimiento.Text == "  /  /")
            {
                valido = false;
                labelErrorFVenc.Visible = true;
            }
            return valido;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.validarCamposVacios())
            {
                if (DB.EmisorDB.validar(comboBoxEmisores.Text))
                {
                    Dominio.Tarjeta tarjeta = this.cargarTarjeta();
                    DB.TarjetaDB.insertar(tarjeta);
                    MessageBox.Show("¡Tarjeta asociada correctamente!");
                    this.Close();
                }
            }
        }

        private Dominio.Tarjeta cargarTarjeta()
        {
            Dominio.Tarjeta tarjeta = new PagoElectronico.Dominio.Tarjeta();
            tarjeta.numero = boxNumero.Text;
            tarjeta.codigo_seguridad = boxCodSeguridad.Text;
            tarjeta.emisor = DB.EmisorDB.getID(comboBoxEmisores.Text);
            tarjeta.cliente = idCliente;
            tarjeta.fecha_emision = boxFechaEmision.Text;
            tarjeta.fecha_vencimiento = boxFechaVencimiento.Text;
            return tarjeta;
        }

    }
}
