using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}

