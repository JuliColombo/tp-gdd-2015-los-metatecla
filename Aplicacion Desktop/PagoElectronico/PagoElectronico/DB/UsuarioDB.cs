using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class UsuarioDB
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static string SHA256(String password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            System.Security.Cryptography.SHA256Managed sha256string = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256string.ComputeHash(bytes);

            return ByteArrayToString(hash);
        }

        public static bool autentificar(string username, string password)
        {

            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Usuario WHERE User_Username = '{0}' AND User_Password = '{1}'", username, UsuarioDB.SHA256(password));
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        internal static void agregarIntentoFallido(string usuario)
        {
            int numeroDeIntento = numeroDeIntentos(usuario);

            modificarNumeroDeIntentos(usuario, numeroDeIntento + 1);
        }


        public static void modificarNumeroDeIntentos(string usuario, int numeroDeIntento)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "UPDATE LOS_METATECLA.Usuario SET User_Intentos_Fallidos = {0} WHERE User_Username = '{1}'", numeroDeIntento, usuario);
            conexion.ejecutarNoQuery();
        }

        internal static bool existe(string usuario)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Usuario WHERE User_Username = '{0}'", usuario);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        internal static int numeroDeIntentos(string usuario)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();

            int numeroDeIntento;

            conexion.query = string.Format(
                "SELECT TOP 1 User_Intentos_Fallidos FROM LOS_METATECLA.Usuario WHERE User_Username = '{0}'", usuario);
            conexion.ejecutarQuery();
            conexion.leerReader();
            numeroDeIntento = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();

            return numeroDeIntento;
        }

        internal static void inhabilitarUsuario(string usuario)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "UPDATE LOS_METATECLA.Usuario SET User_Habilitado = {0} WHERE User_Username = '{1}'", 0, usuario);
            conexion.ejecutarNoQuery();
        }

        internal static void insertarLog(string log)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Log_Intentos (Desc_Log) VALUES('{0}')", log);
            conexion.ejecutarNoQuery();
        }

        internal static int getId(string usuario)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Id_User FROM LOS_METATECLA.Usuario WHERE User_Username = '{0}'", usuario);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }
        //Lo devuelve solo con el nombre y roles (agregar si se necesitan mas
        public static PagoElectronico.Dominio.Usuario getUsuario(int id)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            List<int> roles = new List<int>();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id", id));
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT * FROM LOS_METATECLA.Usuario WHERE Id_User = @id", ListParam);
            lector.Read();
            PagoElectronico.Dominio.Usuario usuario = new PagoElectronico.Dominio.Usuario();
            usuario.username = (string)lector["User_Username"];
            roles = RolDB.getRolesUsuario(id);
            foreach (int rol in roles)
            {
                usuario.roles.Add(rol);
            }
            conexion.cerrarConexion();
            return usuario;
        }
    }
}

