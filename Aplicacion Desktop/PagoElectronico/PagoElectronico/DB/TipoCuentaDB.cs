using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class TipoCuentaDB
    {
        public static void cargarTipos(System.Windows.Forms.ComboBox.ObjectCollection tipos)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format("SELECT Tipo_Desc FROM LOS_METATECLA.Tipo_Cuenta");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                tipos.Add(conexion.lector.GetString(0));
            }
        }

        internal static int getId(string tipo)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            
            conexion.query = string.Format(
                "SELECT TOP 1 Id_Tipo FROM LOS_METATECLA.Tipo_Cuenta WHERE Tipo_Desc like '%{0}%'", tipo);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static Costos obtenerCosto(int id)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            conexion.query = string.Format("SELECT TOP 1 Costo_Transferencia,Costo_Apertura,Costo_Modificacion FROM LOS_METATECLA.Tipo_Cuenta WHERE (Id_Tipo = '{0}')",Convert.ToInt32(id));
            conexion.ejecutarQuery();
            conexion.leerReader();
            Costos costos = new Costos((double)(decimal)conexion.lector["Costo_Transferencia"], (double)(decimal)conexion.lector["Costo_Apertura"], (double)(decimal)conexion.lector["Costo_Modificacion"]);
            conexion.cerrarConexion();
            return costos;

        }

        public static string getTipo(int id)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id", id));
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT TOP 1 Tipo_Desc FROM LOS_METATECLA.Tipo_Cuenta WHERE Id_Tipo = @id", ListParam);
            lector.Read();
            string tipo = (string)lector["Tipo_Desc"];
            conexion.cerrarConexion();
            return tipo;
        }
    }
}
