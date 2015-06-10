using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;


namespace PagoElectronico.Dominio
{
    class Conexion
    {
        public string cadenaconexion;
        public string query = "";
        public SqlCommand command;
        public static SqlConnection cnx;
        public SqlDataReader lector;

        public Conexion()
        {
            //"Data Source=localhost\\SQLSERVER2008;Initial Catalog=LOS_METATECLA;User ID=gd;Password=gd2015";
            this.cadenaconexion = PagoElectronico.Dominio.Config.cadenaConexion();
            cnx = new SqlConnection(this.cadenaconexion);
        }

        public void comandear()
        {
            command = new SqlCommand(query, cnx);
        }

        public static void abrirConexion()
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
            abrirConexion();
            comandear();
            command.ExecuteNonQuery();
            this.cerrarConexion();
        }

        /*Ejecuta un query que devuelva datos(SELECT)*/
        /*Despues de ejecutar este metodo y terminar de usar el Reader*/
        /*SIEMPRE utilizar cerrarConexion */
        public void ejecutarQuery()
        {
            abrirConexion();
            comandear();
            lector = command.ExecuteReader();
        }

        public bool leerReader()
        {
            return lector.Read();
        }

        //Ejecuta Stored Procedure sin Retorno
        public void ejecutarStoredProcedureSinRet(string commandtext, List<SqlParameter> ListaParametro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = nuevaConexion();
            comando.CommandText = commandtext;
            comando.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter elemento in ListaParametro)
            {
                comando.Parameters.Add(elemento);
            }

            comando.ExecuteNonQuery();
            this.cerrarConexion();

        }
        //Para ejecutar los store procedures
        public static SqlConnection nuevaConexion(){
         cnx.Open();
         return cnx;
        }
        //Ejecutar una query con parametros de la app (Acordarse de cerrar la conexcion despues de leer el reader)
        public SqlDataReader ejecutarQueryConParam(string query, List<SqlParameter> listParam)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = nuevaConexion();
            comando.CommandText = query;
            foreach (SqlParameter parametro in listParam)
            {
                comando.Parameters.Add(parametro);
            }
            return comando.ExecuteReader();
        }

    }
}
