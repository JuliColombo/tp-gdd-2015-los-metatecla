using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class ListadoDB
    {
        public static List<Listados.CliListado> CliCuentasInhabilitadas(string año, List<int> trimestre)
        {
            List<Listados.CliListado> listado = new List<PagoElectronico.Listados.CliListado>();
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 5 Cli_Nombre, Cli_Apellido, Cli_Nro_Doc, COUNT(*) AS Cuentas_Inhabilitadas " +
                "FROM LOS_METATECLA.Cliente cl, LOS_METATECLA.Cuenta cu, LOS_METATECLA.Estado_Cuenta ec " +
                "WHERE cl.Cli_Id = cu.Cuenta_Cliente_id AND " +
		                          "cu.Cuenta_Estado = ec.Id_Estado AND " +
		                          "ec.Estado_Desc = 'Inhabilitada' " +
                "GROUP BY Cli_Nombre, Cli_Apellido, Cli_Nro_Doc " +
                "ORDER BY COUNT(*) DESC");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                Listados.CliListado cliente = new PagoElectronico.Listados.CliListado();
                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.documento = Convert.ToString(conexion.lector[2]);
                cliente.cantidad = Convert.ToInt32(conexion.lector[3]);
                listado.Add(cliente);
            }
            conexion.cerrarConexion();
            return listado;
        }

        public static List<Listados.CliListado> cliComisiones(string año, List<int> trimestre){
            List<Listados.CliListado> listado = new List<PagoElectronico.Listados.CliListado>();
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Cli_Nombre, Cli_Apellido, Cli_Nro_Doc, COUNT(*) " +
                "FROM LOS_METATECLA.Cliente c, LOS_METATECLA.Factura f, LOS_METATECLA.Item_Factura i " +
                "WHERE c.Cli_Id = f.Cli_id AND " +
		                "f.Factura_Numero = i.Factura_Numero AND " +
		                "YEAR(f.Factura_Fecha) = '{0}' AND " +
		                "MONTH(f.Factura_Fecha) >= {1} AND MONTH(f.Factura_Fecha) <= {2} " +
                "GROUP BY Cli_Nombre, Cli_Apellido, Cli_Nro_Doc " +
                "ORDER BY COUNT(*) DESC", año, trimestre[0], trimestre[2]);
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                Listados.CliListado cliente = new PagoElectronico.Listados.CliListado();
                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.documento = Convert.ToString(conexion.lector[2]);
                cliente.cantidad = Convert.ToInt32(conexion.lector[3]);
                listado.Add(cliente);
            }
            conexion.cerrarConexion();
            return listado;
        }

        public static List<Listados.CliListado> cliTransacciones(string año, List<int> trimestre){
            List<Listados.CliListado> listado = new List<PagoElectronico.Listados.CliListado>();
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 5 Cli_Nombre, Cli_Apellido, Cli_Nro_Doc, COUNT(*) " +
                "FROM LOS_METATECLA.Cliente cl, LOS_METATECLA.Cuenta cu, LOS_METATECLA.Transferencia t " +
                "WHERE cl.Cli_Id = cu.Cuenta_Cliente_id AND " +
                		"t.Cuenta_Origen IN (SELECT cuenta.Cuenta_Numero " +
							                    "FROM LOS_METATECLA.Cuenta cuenta " +
							                    "WHERE cl.Cli_Id = cuenta.Cuenta_Cliente_id) AND " +
		                "t.Cuenta_Destino IN (SELECT cue.Cuenta_Numero " +
							                    "FROM LOS_METATECLA.Cuenta cue " +
							                    "WHERE cl.Cli_Id = cue.Cuenta_Cliente_id) AND " +
		                "YEAR(t.Transferencia_Fecha) = '{0}' AND " +
		                "(MONTH(t.Transferencia_Fecha) >= {1} AND MONTH(t.Transferencia_Fecha) <= {2}) " +
                        "GROUP BY Cli_Nombre, Cli_Apellido, Cli_Nro_Doc " +
                        "ORDER BY COUNT(*) DESC", año, trimestre[0], trimestre[2]);
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                Listados.CliListado cliente = new PagoElectronico.Listados.CliListado();
                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.documento = Convert.ToString(conexion.lector[2]);
                cliente.cantidad = Convert.ToInt32(conexion.lector[3]);
                listado.Add(cliente);
            }
            conexion.cerrarConexion();
            return listado;
        }

        public static List<Listados.TipoCuentaFacturaciones> tipoCuentaFact(string año, List<int> trimestre){
            List<Listados.TipoCuentaFacturaciones> listado = new List<PagoElectronico.Listados.TipoCuentaFacturaciones>();
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT t.Tipo_Desc, SUM(i.Item_Importe) " +
                "FROM LOS_METATECLA.Tipo_Cuenta t, LOS_METATECLA.Cuenta cu, LOS_METATECLA.Cliente cl, LOS_METATECLA.Factura f, LOS_METATECLA.Item_Factura i " +
                "WHERE t.Id_Tipo = cu.Cuenta_Tipo AND " +
		                "cl.Cli_Id = cu.Cuenta_Cliente_id AND " +
		                "cl.Cli_Id = f.Cli_id AND " +
		                "f.Factura_Numero = i.Factura_Numero AND " +
		                "YEAR(f.Factura_Fecha) = '{0}' AND " +
		                "(MONTH(f.Factura_Fecha) >= {1} AND MONTH(f.Factura_Fecha) <= {2}) " +
                "GROUP BY t.Tipo_Desc " +
                "ORDER BY SUM(i.Item_Importe) DESC", año, trimestre[0], trimestre[2]);
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                Listados.TipoCuentaFacturaciones tipoCuenta = new PagoElectronico.Listados.TipoCuentaFacturaciones();
                tipoCuenta.tipo_de_cuenta = conexion.lector.GetString(0);
                tipoCuenta.importe_total = Convert.ToDouble(conexion.lector[1]);
                listado.Add(tipoCuenta);
            }
            conexion.cerrarConexion();
            return listado;
        }
    }
}
