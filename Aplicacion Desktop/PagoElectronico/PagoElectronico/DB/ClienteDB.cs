using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class ClienteDB
    {
        public static void insertar(PagoElectronico.Dominio.Cliente cliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Cliente (Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, " +
                "Cli_Pais_Codigo, Id_Domicilio, Cli_Fecha_Nac, Cli_Mail) values ('{0}', '{1}', {2}, '{3}', '{4}', {5}, '{6}', '{7}')",
                cliente.nombre, cliente.apellido, cliente.tipo_doc, cliente.documento, cliente.pais, cliente.domicilio,
                cliente.fecha_nac, cliente.mail);
            conexion.ejecutarNoQuery();
        }

        public static void modificar(Dominio.Cliente cliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "UPDATE LOS_METATECLA.Cliente SET Cli_Nombre = '{0}', Cli_Apellido = '{1}', " +
                "Cli_Pais_Codigo = '{2}', Id_Domicilio = '{3}', Cli_Fecha_Nac = '{4}', Cli_Mail = '{5}' " +
                "WHERE Cli_Tipo_Doc_Cod = '{6}' AND Cli_Nro_Doc = '{7}'",
                cliente.nombre, cliente.apellido, cliente.pais, cliente.domicilio, cliente.fecha_nac, cliente.mail, 
                cliente.tipo_doc, cliente.documento);
            conexion.ejecutarNoQuery();
        }

        public static bool mailRepetido(String mail)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 * FROM LOS_METATECLA.Cliente WHERE Cli_mail = '{0}'", mail);
            conexion.ejecutarQuery();
            bool repetido = (conexion.leerReader());
            conexion.cerrarConexion();
            return repetido;
        }

        public static bool documentoRepetido(int documento)
        {
            //int doc = Convert.ToInt32(documento);
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 * FROM LOS_METATECLA.Cliente WHERE Cli_Nro_Doc = '{0}'", documento);
            conexion.ejecutarQuery();
            bool repetido = (conexion.leerReader());
            conexion.cerrarConexion();
            return repetido;
        }

        public static List<ABM_Cliente.ClienteEdit> buscarClientes(string nom, string ape, string tipoDoc, string doc, string mail)
        {
            List<ABM_Cliente.ClienteEdit> clientes = new List<ABM_Cliente.ClienteEdit>();
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Cli_Nombre, Cli_Apellido, Doc_Tipo_Desc, Cli_Nro_Doc, Cli_Mail " +
                "FROM LOS_METATECLA.Cliente, LOS_METATECLA.Documento " +
                "WHERE Cli_Tipo_Doc_Cod = Doc_Tipo_Cod AND Cli_Nombre LIKE '%{0}%' AND Cli_Apellido LIKE '%{1}%' " +
                "AND Doc_Tipo_Desc LIKE '%{2}%' AND Cli_Nro_Doc LIKE '%{3}%' AND Cli_Mail LIKE '%{4}%'",
                nom, ape, tipoDoc, doc, mail);
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                ABM_Cliente.ClienteEdit cliente = new ABM_Cliente.ClienteEdit();
                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.tipo_doc = conexion.lector.GetString(2);
                cliente.documento = Convert.ToInt32(conexion.lector[3]);
                cliente.mail = conexion.lector.GetString(4);
                clientes.Add(cliente);
            }
            conexion.cerrarConexion();
            return clientes;
        }

        public static Dominio.Cliente getCliente(int documento)
        {
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * " +
                "FROM LOS_METATECLA.Cliente " +
                "WHERE Cli_Nro_Doc = '{0}'", documento);
            conexion.ejecutarQuery();
            conexion.leerReader();
            Dominio.Cliente cliente = new PagoElectronico.Dominio.Cliente();
            cliente.nombre = conexion.lector.GetString(0);
            cliente.apellido = conexion.lector.GetString(1);
            cliente.tipo_doc = Convert.ToDouble(conexion.lector[2]);
            cliente.documento = documento;
            cliente.pais = Convert.ToDouble(conexion.lector[4]);
            cliente.domicilio = Convert.ToInt32(conexion.lector[5]);
            cliente.fecha_nac = Convert.ToString(conexion.lector[6]);
            cliente.mail = conexion.lector.GetString(7);
            conexion.cerrarConexion();
            return cliente;
        }

        public static bool existeCliente(string nombre, string apellido, string documento)
        {
            double docu = Convert.ToDouble(documento);

            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Cliente WHERE Cli_Nombre = '{0}' AND Cli_Apellido = '{1}' AND Cli_Nro_Doc = {2}", nombre, apellido, docu);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        public static PagoElectronico.Dominio.Cliente crearCliente(string nombre, string apellido, string documento)
        {
            double docu = Convert.ToDouble(documento);

            PagoElectronico.Dominio.Cliente cliente = new PagoElectronico.Dominio.Cliente();
            cliente.numeros_cuentas = new List<double>();
            cliente.numeros_tarjetas = new List<double>();

            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Cli_Nombre, Cli_Apellido, Cli_Nro_Doc, Cuenta_Numero, Tarjeta_Numero " +
                "FROM LOS_METATECLA.Cliente, LOS_METATECLA.Documento, LOS_METATECLA.Tarjeta, LOS_METATECLA.Cuenta " +
                "WHERE Cli_Tipo_Doc_Cod = Doc_Tipo_Cod AND Cli_Nombre LIKE '%{0}%' AND Cli_Apellido LIKE '%{1}%' " +
                "AND Cli_Nro_Doc = '{2}' AND Cuenta_Cliente = Cli_Nro_Doc AND Id_Cliente_Propietario = Cli_Nro_Doc",
                nombre, apellido, docu);
            conexion.ejecutarQuery();

            while (conexion.leerReader())
            {

                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.documento = Convert.ToInt32(conexion.lector[2]);

                double numero_cuenta = Convert.ToDouble(conexion.lector[3]);
                double numero_tarjeta = Convert.ToDouble(conexion.lector[4]);

                if (cliente.numeros_cuentas.Contains(numero_cuenta))
                {
                    cliente.numeros_cuentas.Add(numero_cuenta);
                }

                if (cliente.numeros_tarjetas.Contains(numero_tarjeta))
                {
                    cliente.numeros_cuentas.Add(numero_tarjeta);
                }

            }
            conexion.cerrarConexion();

            return cliente;
        }
    }
}

