﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class ChequeDB
    {
        public static void insertarCheque(Banco banco, int idCliente, double importe, string moneda, double codigoCheque, double codigoRetiro)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            string fecha = PagoElectronico.Dominio.Config.fechaSystem();
            int idMoneda = MonedaDB.getID(moneda);
            ListParam.Add(new SqlParameter("@banco", banco.codigo));
            ListParam.Add(new SqlParameter("@cliente",idCliente));
            ListParam.Add(new SqlParameter("@moneda", idMoneda));
            ListParam.Add(new SqlParameter("@importe", importe));
            ListParam.Add(new SqlParameter("@codigoCheque", codigoCheque));
            ListParam.Add(new SqlParameter("@codigoRetiro", codigoRetiro));
            ListParam.Add(new SqlParameter("@fecha", Convert.ToDateTime(fecha)));
            conexion.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Cheque(Cheque_Importe,Cheque_Moneda,Cheque_Fecha,Cheque_Numero,Banco_Codigo,Retiro_Codigo,Cliente_Id) VALUES(@importe,@moneda,@fecha,@codigoCheque,@banco,@codigoRetiro,@cliente)", ListParam);
            conexion.cerrarConexion();
        }

        public static double obtenerUlltimoCodigo()
        {
            double maximo = -1;
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT MAX(Retiro_Codigo) AS Maximo FROM LOS_METATECLA.Retiro");
            conexion.ejecutarQuery();
             if (conexion.lector.HasRows){
                 conexion.lector.Read();
                 maximo = (double)(decimal)conexion.lector["Maximo"];
        }
            return maximo;
        }
    }
}
