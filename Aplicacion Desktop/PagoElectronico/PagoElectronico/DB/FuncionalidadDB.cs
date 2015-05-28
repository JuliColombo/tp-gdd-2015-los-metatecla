using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class FuncionalidadDB
    {
        public static List<Funcionalidad> obtenerFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT * FROM LOS_METATECLA.Funcionalidad");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                while (conexion.lector.Read())
                {
                    Funcionalidad func = new Funcionalidad((int)(decimal)conexion.lector["Id_Funcionalidad"], (string)conexion.lector["Nombre"]);
                    funcionalidades.Add(func);
                }
            }
            conexion.cerrarConexion();
            return funcionalidades;
        }


        public void AgregarFuncionalidadDelRol(string nombre, Funcionalidad funcionalidad)
        {
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@nombrerol", nombre));
            ListParam.Add(new SqlParameter("@funcionalidad", funcionalidad.nombre));
            Conexion cnx = new Conexion();
            cnx.ejecutarStoredProcedureSinRet("LOS_METATECLA.AgregarFuncionalidadARol", ListParam);

        }

        public void AgregarFuncionalidad(string nombre)
        {
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@nombre", nombre));
            Conexion cnx = new Conexion();
            cnx.ejecutarStoredProcedureSinRet("LOS_METATECLA.AgregarFuncionalidadNueva", ListParam);
        }

        public List<Funcionalidad> obtenerFuncRol(Rol rol) {
            List<Funcionalidad> funcionalidadesDelRol = new List<Funcionalidad>();
            Conexion cnx = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id_rol", rol.id));
            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = cnx.cadenaconexion;
            conex.Open();  // Lo tuve que hacer asi por que no me reconocia cnx.abrirConexion ni cnx.cnx
            SqlDataReader lector = cnx.ejecutarQueryConParam("SELECT F.Nombre,F.Id_Funcionalidad FROM LOS_METATECLA.Funcionalidad F, LOS_METATECLA.Funcionalidad_Rol FR WHERE FR.Id_Rol = @id_rol  AND F.Id_Funcionalidad = FR.Id_Funcionalidad",conex, ListParam);
            if (lector.HasRows)
            { while (lector.Read()) {
           Funcionalidad func = new Funcionalidad((int)(decimal)lector["Id_Funcionalidad"], (string)lector["Nombre"]);
           funcionalidadesDelRol.Add(func);
                }
            }
            conex.Close();
            return funcionalidadesDelRol;
        }

    
    
    
    
    
    }
}
