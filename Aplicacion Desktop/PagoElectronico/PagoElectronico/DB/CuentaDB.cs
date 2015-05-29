using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class CuentaDB
    {
        internal static bool noExisteCuenta(string nro_cuenta)
        {
            double cuenta = Convert.ToDouble(nro_cuenta);

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
            double cuenta = Convert.ToDouble(nro_cuenta);
            double pais_id = PagoElectronico.DB.PaisDB.getID(pais);
            int tipo_id = PagoElectronico.DB.TipoCuentaDB.getId(tipo);
            double user_id = PagoElectronico.DB.UsuarioDB.getId(usuario);
            int estado_id = PagoElectronico.DB.EstadoCuentaDB.getID("Pendiente de activación");
            int moneda_id = PagoElectronico.DB.MonedaDB.getID(moneda);


            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Cuenta (Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Estado, Cuenta_Pais_Codigo, Cuenta_Fecha_Cierre, Cuenta_Cliente, Cuenta_Tipo, Cuenta_Moneda) VALUES({0}, '{1}', {2}, {3}, NULL, {4}, {5}, {6})", cuenta, fecha, estado_id, pais_id, user_id, tipo_id, moneda_id);
            conexion.ejecutarNoQuery();

        }
    }
}

