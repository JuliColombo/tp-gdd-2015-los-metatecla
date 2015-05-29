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

        internal static void crearCuenta(string nro_cuenta, string usuario, string pais, string tipo, string fecha)
        {
            double cuenta = Convert.ToDouble(nro_cuenta);
            double pais_id = PagoElectronico.DB.PaisDB.getID(pais);
            int tipo_id = PagoElectronico.DB.TipoCuentaDB.getId(tipo);
            double user_id = PagoElectronico.DB.UsuarioDB.getId(usuario);

            //TODO: FALTA MONEDA Y FECHA
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Cuenta (Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Estado, Cuenta_Pais_Codigo, Cuenta_Fecha_Cierre, Cuenta_Cliente, Cuenta_Tipo) VALUES({0}, '{1}', NULL, {2}, NULL, {3}, {4})", cuenta, fecha,pais_id, user_id, tipo_id);
            conexion.ejecutarNoQuery();

        }
    }
}
