using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using PagoElectronico.DB;
using System.Data.SqlClient;


namespace PagoElectronico.DB
{
    class TransferenciaDB
    {

        public static void insertarTransferencia(Cuenta origen, Cuenta destino, double importe, int moneda, double costo)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            string fecha = PagoElectronico.Dominio.Config.fechaSystem();
            ListParam.Add(new SqlParameter("@origen", origen.numero));
            ListParam.Add(new SqlParameter("@destino", destino.numero));
            ListParam.Add(new SqlParameter("@importe", importe));
            ListParam.Add(new SqlParameter("@moneda", moneda));
            ListParam.Add(new SqlParameter("@costo", costo));
            ListParam.Add(new SqlParameter("@fecha",Convert.ToDateTime(fecha)));
            conexion.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Transferencia (Transferencia_Fecha,Transferencia_Importe,Transferencia_Moneda,Transferencia_Costo,Cuenta_Origen,Cuenta_Destino) VALUES(@fecha,@importe,@moneda,@costo,@origen,@destino)", ListParam);
            conexion.cerrarConexion();
            if (!(origen.idPropietario == destino.idPropietario))
            {
                FacturaDB.insertarItemTransferencia(fecha, importe, origen.numero, destino.numero, 0);
            }
            origen.saldo = origen.saldo - importe;
            destino.saldo = destino.saldo + importe;
        }

    }
}
