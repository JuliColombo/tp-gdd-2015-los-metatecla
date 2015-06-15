using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PagoElectronico.Dominio;

namespace PagoElectronico.DB
{
    class CuentaDB
    {
        internal static bool noExisteCuenta(string nro_cuenta)
        {
            long cuenta = Convert.ToInt64(nro_cuenta);

            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Cuenta WHERE Cuenta_Numero = {0}", cuenta);
            conexion.ejecutarQuery();
            bool valida = !(conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        internal static void crearCuenta(string nro_cuenta, string usuario, string pais, string tipo, string fecha, string moneda)
        {
            long cuenta = Convert.ToInt64(nro_cuenta);
            double pais_id = PagoElectronico.DB.PaisDB.getID(pais);
            int tipo_id = PagoElectronico.DB.TipoCuentaDB.getId(tipo);
            int user_id = PagoElectronico.DB.UsuarioDB.getId(usuario);
            int estado_id = PagoElectronico.DB.EstadoCuentaDB.getID("Pendiente de activación");
            int moneda_id = PagoElectronico.DB.MonedaDB.getID(moneda);


            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Cuenta (Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Estado, Cuenta_Pais_Codigo, Cuenta_Fecha_Cierre, Cuenta_Cliente_id, Cuenta_Tipo, Cuenta_Moneda,Cuenta_Saldo) VALUES({0}, '{1}', {2}, {3}, NULL, {4}, {5}, {6},0)", cuenta, fecha, estado_id, pais_id, user_id, tipo_id, moneda_id);
            conexion.ejecutarNoQuery();

        }


        public static List<Cuenta> obtenerCuentasCliente(Cliente cliente)
        {
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id", cliente.id));
            Conexion conexion = new Conexion();
            List<Cuenta> cuentasCliente = new List<Cuenta>();
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT * FROM LOS_METATECLA.Cuenta WHERE Cuenta_Cliente_id = @id", ListParam);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Cuenta nuevaCuenta = new Cuenta(/*(int)lector["Cuenta_Numero"], (DateTime)lector["Cuenta_Fecha_Creacion"], (int)lector["Cuenta_Estado"], (int)lector["Cuenta_Pais_Codigo"], (DateTime)lector["Cuenta_Fecha_Cierre"], (int)lector["Cuenta_Tipo"]*/);
                    nuevaCuenta.numero = (long)(decimal)lector["Cuenta_Numero"];
                    nuevaCuenta.fecha_creacion = (DateTime)lector["Cuenta_Fecha_Creacion"];
                    nuevaCuenta.fecha_cierre = (DateTime)lector["Cuenta_Fecha_Cierre"];
                    nuevaCuenta.pais = (int)(decimal)lector["Cuenta_Pais_Codigo"];
                    nuevaCuenta.estado = (int)lector["Cuenta_Estado"];
                    nuevaCuenta.tipo = (int)lector["Cuenta_Tipo"];
                    nuevaCuenta.saldo = (double)(decimal)lector["Cuenta_Saldo"];
                    nuevaCuenta.idPropietario= cliente.id;
                    cuentasCliente.Add(nuevaCuenta);
                }
            }
            conexion.cerrarConexion();
            return cuentasCliente;
        }
        //Devuelve solo cuentas habilitadas y inhabilitadas
        public static List<Cuenta> obtenerCuentasTransferibles()
        {
            List<Cuenta> cuentasTransferibles = new List<Cuenta>();
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT * FROM LOS_METATECLA.Cuenta WHERE (Cuenta_Estado=2 OR Cuenta_Estado=3)");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                while (conexion.lector.Read())
                {
                    Cuenta nuevaCuenta = new Cuenta(/*(int)lector["Cuenta_Numero"], (DateTime)lector["Cuenta_Fecha_Creacion"], (int)lector["Cuenta_Estado"], (int)lector["Cuenta_Pais_Codigo"], (DateTime)lector["Cuenta_Fecha_Cierre"], (int)lector["Cuenta_Tipo"]*/);
                    nuevaCuenta.numero = (long)(decimal)conexion.lector["Cuenta_Numero"];
                    nuevaCuenta.fecha_creacion = (DateTime)conexion.lector["Cuenta_Fecha_Creacion"];
                    nuevaCuenta.fecha_cierre = (DateTime)conexion.lector["Cuenta_Fecha_Cierre"];
                    nuevaCuenta.pais = (int)(decimal)conexion.lector["Cuenta_Pais_Codigo"];
                    nuevaCuenta.estado = (int)conexion.lector["Cuenta_Estado"];
                    nuevaCuenta.tipo = (int)conexion.lector["Cuenta_Tipo"];
                    nuevaCuenta.saldo = (double)(decimal)conexion.lector["Cuenta_Saldo"];
                    nuevaCuenta.idPropietario = (int)conexion.lector["Cuenta_Cliente_Id"];
                    cuentasTransferibles.Add(nuevaCuenta);
                }
            }
            conexion.cerrarConexion();
            return cuentasTransferibles;
        }

        public static bool estaHabilitada(long numero_cuenta)
        {
            
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Cuenta " +
                "WHERE Cuenta_Numero = {0} AND Cuenta_Estado = 2", numero_cuenta);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

    }
}

