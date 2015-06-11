using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class ChequeDB
    {
        public static void insertarCheque(Banco banco, Cliente cliente, float importe,string moneda, double codigoCheque,double codigoRetiro) 
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            string fecha = PagoElectronico.Dominio.Config.fechaSystem();
            int idMoneda = MonedaDB.getID(moneda);
            ListParam.Add(new SqlParameter("@banco", banco.codigo));
            ListParam.Add(new SqlParameter("@cliente", cliente.id));
            ListParam.Add(new SqlParameter("@moneda", idMoneda));
            ListParam.Add(new SqlParameter("@importe", importe));
            ListParam.Add(new SqlParameter("@codigoCheque", codigoCheque));
            ListParam.Add(new SqlParameter("@codigoRetiro", codigoRetiro));
            ListParam.Add(new SqlParameter("@fecha", Convert.ToDateTime(fecha)));
            conexion.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Cheque(Cheque_Importe,Cheque_Moneda,Cheque_Fecha,Cheque_Numero,Banco_Codigo,Retiro_Codigo,Cliente_Id) VALUES(@importe,@moneda,@fecha,@codigoCheque,@banco,@codigoRetiro,@cliente)", ListParam);
            conexion.cerrarConexion();
        }
    }
}
