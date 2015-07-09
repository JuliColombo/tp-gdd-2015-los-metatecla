using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class ClienteDB
    {
        public static void insertar(PagoElectronico.Dominio.Cliente cliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Cliente (Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, " +
                "Cli_Pais_Codigo, Id_Domicilio, Cli_Fecha_Nac, Cli_Mail, Cli_Estado) values ('{0}', '{1}', {2}, '{3}', '{4}', {5}, '{6}', '{7}', 'habilitado')",
                cliente.nombre, cliente.apellido, cliente.tipo_doc, cliente.documento, cliente.pais, cliente.domicilio,
                cliente.fecha_nac, cliente.mail);
            conexion.ejecutarNoQuery();
        }

        public static void modificar(Dominio.Cliente cliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "UPDATE LOS_METATECLA.Cliente SET Cli_Nombre = '{0}', Cli_Apellido = '{1}', " +
                "Cli_Pais_Codigo = '{2}', Id_Domicilio = '{3}', Cli_Fecha_Nac = '{4}', Cli_Mail = '{5}', " +
                "Cli_Tipo_Doc_Cod = '{6}', Cli_Nro_Doc = '{7}' " +
                "WHERE Cli_Id = '{8}'",
                cliente.nombre, cliente.apellido, cliente.pais, cliente.domicilio, cliente.fecha_nac, cliente.mail, 
                cliente.tipo_doc, cliente.documento, cliente.id);
            conexion.ejecutarNoQuery();
        }

        public static void darDeBaja(int idCliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "UPDATE LOS_METATECLA.Cliente SET Cli_Estado = 'baja' " +
                "WHERE Cli_Id = '{0}'", idCliente);
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
                "SELECT Cli_Nombre, Cli_Apellido, Doc_Tipo_Desc, Cli_Nro_Doc, Cli_Mail, Cli_Id " +
                "FROM LOS_METATECLA.Cliente, LOS_METATECLA.Tipo_Documento " +
                "WHERE Cli_Tipo_Doc_Cod = Doc_Tipo_Cod AND Cli_Nombre LIKE '%{0}%' AND Cli_Apellido LIKE '%{1}%' " +
                "AND Doc_Tipo_Desc LIKE '%{2}%' AND Cli_Nro_Doc LIKE '%{3}%' AND Cli_Mail LIKE '%{4}%' " +
                "AND Cli_Estado != 'baja'",
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
                cliente.id = Convert.ToInt32(conexion.lector[5]);
                clientes.Add(cliente);
            }
            conexion.cerrarConexion();
            return clientes;
        }

        public static int getID(Dominio.Cliente cliente){
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Cli_Id " +
                "FROM LOS_METATECLA.Cliente " +
                "WHERE Cli_Tipo_Doc_Cod = '{0}' AND Cli_Nro_Doc = '{1}'", cliente.tipo_doc, cliente.documento);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static Dominio.Cliente getCliente(int id)
        {
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, " +
                "Cli_Pais_Codigo, Id_Domicilio, Cli_Fecha_Nac, Cli_Mail " +
                "FROM LOS_METATECLA.Cliente " +
                "WHERE Cli_Id = '{0}'", id);
            conexion.ejecutarQuery();
            conexion.leerReader();
            Dominio.Cliente cliente = new PagoElectronico.Dominio.Cliente();
            cliente.id = id;
            cliente.nombre = conexion.lector.GetString(0);
            cliente.apellido = conexion.lector.GetString(1);
            cliente.tipo_doc = Convert.ToDouble(conexion.lector[2]);
            cliente.documento = Convert.ToInt32(conexion.lector[3]);
            cliente.pais = Convert.ToDouble(conexion.lector[4]);
            cliente.domicilio = Convert.ToInt32(conexion.lector[5]);
            cliente.fecha_nac = Convert.ToString(conexion.lector[6]);
            cliente.mail = conexion.lector.GetString(7);
            conexion.cerrarConexion();
            return cliente;
        }

        public static bool existeCliente(string nombre, string apellido, string documento, string tipo_doc)
        {
            double docu = Convert.ToDouble(documento);

            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Cliente, LOS_METATECLA.Tipo_Documento " + 
                "WHERE Cli_Nombre = '{0}' AND Cli_Apellido = '{1}' AND Cli_Nro_Doc = {2} " +
                "AND Doc_Tipo_Desc like '%{3}%' AND Cli_Tipo_Doc_Cod = Doc_Tipo_Cod", nombre, apellido, docu, tipo_doc);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        public static PagoElectronico.Dominio.Cliente crearCliente(string nombre, string apellido, string documento)
        {
            double docu = Convert.ToDouble(documento);

            PagoElectronico.Dominio.Cliente cliente = new PagoElectronico.Dominio.Cliente();
            cliente.numeros_cuentas = new List<long>();
            /*cliente.numeros_tarjetas = new List<double>();*/
            cliente.tarjetas = new List<PagoElectronico.Dominio.Tarjeta>();

            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Cli_Nombre, Cli_Apellido, Cli_Nro_Doc, Cuenta_Numero, Cli_Id, Tarjeta_Id, Tarjeta_Fecha_Vencimiento, Tarjeta_Ultimos_4 " +
                "FROM LOS_METATECLA.Cliente, LOS_METATECLA.Tipo_Documento, LOS_METATECLA.Tarjeta, LOS_METATECLA.Cuenta " +
                "WHERE Cli_Tipo_Doc_Cod = Doc_Tipo_Cod AND Cli_Nombre LIKE '%{0}%' AND Cli_Apellido LIKE '%{1}%' " +
                "AND Cli_Nro_Doc = {2} AND Cuenta_Cliente_id = Cli_Id AND Id_Cliente_Propietario = Cli_Id",
                nombre, apellido, docu);
            conexion.ejecutarQuery();

            while (conexion.leerReader())
            {
                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.documento = Convert.ToInt32(conexion.lector[2]);
                cliente.id = Convert.ToInt32(conexion.lector[4]);

                long numero_cuenta = Convert.ToInt64(conexion.lector[3]);
                                               
                
                if (!cliente.numeros_cuentas.Contains(numero_cuenta))
                {
                    cliente.numeros_cuentas.Add(numero_cuenta);
                }

                int ult_numero_tarjeta = Convert.ToInt32(conexion.lector[7]);

                if (!cliente.ultimos_numeros_tarjetas().Contains(ult_numero_tarjeta))
                {
                    PagoElectronico.Dominio.Tarjeta tarjeta = new PagoElectronico.Dominio.Tarjeta();
                    tarjeta.id = Convert.ToInt32(conexion.lector[5]);
                    tarjeta.fecha_vencimiento = Convert.ToString(conexion.lector[6]);
                    tarjeta.ultimos_4_numeros = Convert.ToInt32(conexion.lector[7]);
                    cliente.tarjetas.Add(tarjeta);
                }

            }
            conexion.cerrarConexion();

            return cliente;
        }

        public static bool validarDocumento(int idCliente, double documento, string tipoDoc)
        {
            double idTipoDoc = DocumentoDB.getID(tipoDoc);
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@idCliente", idCliente));
            ListParam.Add(new SqlParameter("@documento", documento));
            ListParam.Add(new SqlParameter("@tipoDoc", idTipoDoc));
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT * FROM LOS_METATECLA.Cliente WHERE Cli_Id = @idCliente AND Cli_Nro_Doc = @documento AND Cli_Tipo_Doc_Cod = @tipoDoc", ListParam);
            if (lector.HasRows) { return true; }
            return false;

        }
    }
}

