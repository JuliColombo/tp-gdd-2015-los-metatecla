using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PagoElectronico.Dominio
{
    class Conexion
    {
        public string cadenaconexion;
        public string query = "";
        public SqlCommand command;
        public SqlConnection cnx;
        public SqlDataReader lector;

        public Conexion()
        {
            //"Data Source=localhost\\SQLSERVER2008;Initial Catalog=LOS_METATECLA;User ID=gd;Password=gd2015";
            this.cadenaconexion = PagoElectronico.Dominio.Config.cadenaConexion();
            this.cnx = new SqlConnection(this.cadenaconexion);
        }

        public void comandear()
        {
            command = new SqlCommand(query, cnx);
        }

        public void abrirConexion()
        {
            cnx.Open();
        }
        public void cerrarConexion()
        {
            cnx.Close();
        }
        /*Ejecuta un query que no devuleve datos(UPDATE, INSERT, DELETE, etc)*/
        public void ejecutarNoQuery()
        {
            this.abrirConexion();
            comandear();
            command.ExecuteNonQuery();
            this.cerrarConexion();
        }

        /*Ejecuta un query que devuelva datos(SELECT)*/
        /*Despues de ejecutar este metodo y terminar de usar el Reader*/
        /*SIEMPRE utilizar cerrarConexion */
        public void ejecutarQuery()
        {
            this.abrirConexion();
            comandear();
            lector = command.ExecuteReader();
        }

        public bool leerReader()
        {
            return lector.Read();
        }

    }
}
