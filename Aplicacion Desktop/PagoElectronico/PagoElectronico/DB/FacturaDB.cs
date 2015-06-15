using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using PagoElectronico.DB;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class FacturaDB
    {

        public static void insertarItemPendiente(string descripcion,double importe, long numero)
        {
            
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@desc", descripcion));
            ListParam.Add(new SqlParameter("@numero", numero));
            ListParam.Add(new SqlParameter("@importe", importe));
            conexion.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Item_Factura(Item_Desc,Item_Importe,Pendiente_Factura, Numero_Cuenta) VALUES (@desc,@importe,1,@numero)", ListParam);
            conexion.cerrarConexion();
        }

    }
}
