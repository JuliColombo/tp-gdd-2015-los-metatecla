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
        static string stringConexion;

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

        //Ejecuta stored procedure con parametros y devuelve ret 
        public static decimal ejecutarStoredProcedure(string commandtext, List<SqlParameter> ListaParametro)
        {
        try
              { SqlCommand comando = new SqlCommand();
              comando.Connection = abrirConexion(); //FIXME Realmente no se como solucionarlo, estoy buscando como se hace
                comando.CommandText = commandtext;
                comando.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter elemento in ListaParametro)
                {
                    comando.Parameters.Add(elemento);
                }

                comando.ExecuteNonQuery();
                return (decimal)comando.Parameters["@ret"].Value;
            }
            catch (SqlException e)
            {
                MessageBox.Show("" + e.Message, "Error");
                return 0;
            }
        }
        //Ejecuta Stored Procedure sin Retorno
        public static void ejecutarStoredProcedureSinRet(string commandtext, List<SqlParameter> ListaParametro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = abrirConexion(); //FIXME los mismo que antes
            comando.CommandText = commandtext;
            comando.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter elemento in ListaParametro)
            {
                comando.Parameters.Add(elemento);
            }

            comando.ExecuteNonQuery();

        }

    }
}
