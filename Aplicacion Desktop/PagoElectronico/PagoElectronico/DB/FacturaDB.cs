using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using PagoElectronico.DB;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static void obtenerItemsFactura(Cuenta cuenta,DataTable tabla)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@numero", cuenta.numero));
            SqlDataReader sqlreader = conexion.ejecutarQueryConParam("SELECT * FROM LOS_METATECLA.Item_Factura WHERE Numero_Cuenta = @numero AND Pendiente_Factura = 1", ListParam);
            tabla.Load(sqlreader);
            conexion.cerrarConexion();

        }

        public static void insertarFactura(int idCliente,DataGridViewRowCollection rows)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@idCliente", idCliente));
            string fecha = PagoElectronico.Dominio.Config.fechaSystem();
            ListParam.Add(new SqlParameter("@fecha", fecha));
            double codigo = obtenerUlltimoCodigo();
            if (codigo == -1)
            { codigo = 123123123123; }
            else { codigo++; }
            ListParam.Add(new SqlParameter("@numero", codigo));
            conexion.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Factura (Factura_Numero,Factura_Fecha,Factura_Moneda,Cli_Id) VALUES (@numero,@fecha,0,@idCliente)", ListParam);
            conexion.cerrarConexion();
            asignarFacturaAItems(rows,codigo);
        }

        private static void asignarFacturaAItems(DataGridViewRowCollection rows, double factura)
        {
            int cant = rows.Count;
           for (int i = 0;i < cant-1;i++) 
            {
                double costo = -1;
                double idItem = Convert.ToDouble(rows[i].Cells["Id_Item"].Value);
                int tipo = CuentaDB.getTipo(Convert.ToInt64(rows[i].Cells["Numero_Cuenta"].Value));
                costo = verificarCosto(rows[i], tipo);
                Conexion conexion = new Conexion();
                List<SqlParameter> ListParam = new List<SqlParameter>();
                ListParam.Add(new SqlParameter("@id", idItem));
                ListParam.Add(new SqlParameter("@costo", costo));
                ListParam.Add(new SqlParameter("@factura", factura));
                conexion.ejecutarQueryConParam("UPDATE LOS_METATECLA.Item_Factura SET Pendiente_Factura = 0, Factura_Numero = @factura WHERE Id_Item = @id", ListParam);
                conexion.cerrarConexion();
                
            }
        }

        private static double verificarCosto(DataGridViewRow row, int tipoCuenta)
        {
            Costos costo = TipoCuentaDB.obtenerCosto(tipoCuenta);
            double costoActual;
            string descrip = Convert.ToString(row.Cells["Item_Desc"]);
            if (descrip.Contains("Costo por Apertura de cuenta"))
            {
                costoActual = costo.costoApertura;
            }
            else
            {
                if (descrip.Contains("Costo por transferencia"))
                {
                    costoActual = costo.costoTrans;
                }
                else
                {
                    if (descrip.Contains("Costo por Suscripcion"))
                    {
                        return Convert.ToDouble(row.Cells["Item_Importe"]);
                    }
                    else { costoActual = costo.costoModificacion; }
                }
            }
            double costoEnTabla = Convert.ToDouble(row.Cells["Item_Importe"].Value);
            if (costoActual == costoEnTabla)
            { return costoEnTabla; }
            else { return costoActual; }
        }

        public static double obtenerUlltimoCodigo()
        {
            double maximo = -1;
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT MAX(Factura_Numero) AS Maximo FROM LOS_METATECLA.Factura");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                conexion.lector.Read();
                maximo = (double)(decimal)conexion.lector["Maximo"];
            }
            conexion.cerrarConexion();
            return maximo;
        }

    }
}
