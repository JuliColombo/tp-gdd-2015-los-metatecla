using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;


namespace PagoElectronico.DB
{
    class BancoDB
    {
        public static List<Banco> obtenerBancos()
        {
            List<Banco> bancos = new List<Banco>();
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT * FROM LOS_METATECLA.Banco");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                while (conexion.lector.Read())
                {
                    Banco banco = new Banco((double)(decimal)conexion.lector["Banco_Codigo"], (string)conexion.lector["Banco_Nombre"], (string)conexion.lector["Banco_Direccion"]);
                    bancos.Add(banco);
                }
            }
            conexion.cerrarConexion();
            return bancos;
        }
    }
}
