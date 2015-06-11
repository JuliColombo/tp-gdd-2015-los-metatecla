using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class RetiroDB
    {
        public static void insertarRetiro(double codigo, float importe, string moneda, Cuenta cuenta)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            string fecha = PagoElectronico.Dominio.Config.fechaSystem();
            int idMoneda = MonedaDB.getID(moneda);
            ListParam.Add(new SqlParameter("@codigo",codigo));
            ListParam.Add(new SqlParameter("@moneda", idMoneda));
            ListParam.Add(new SqlParameter("@importe", importe));
            ListParam.Add(new SqlParameter("@cuenta",cuenta.numero));
            ListParam.Add(new SqlParameter("@fecha", fecha));
            conexion.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Retiro (Retiro_Importe,Retiro_Moneda,Retiro_Fecha,Retiro_Codigo,Numero_cuenta) VALUES (@importe,@moneda,@fecha,@codigo,@cuenta)", ListParam);
            conexion.cerrarConexion();
        }

          public static double obtenerUlltimoCodigo()
        {
            double maximo = -1;
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT MAX(Retiro_Codigo) AS Maximo FROM LOS_METATECLA.Cheque");
            conexion.ejecutarQuery();
             if (conexion.lector.HasRows){
                 conexion.lector.Read();
                 maximo = (double)(decimal)conexion.lector["Maximo"];
        }
            return maximo;
        }
    }
}
