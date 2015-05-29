using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class RolDB
    {
         public static List<Rol> obtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            Conexion conexion = new Conexion();
            FuncionalidadDB DBFunc = new FuncionalidadDB();
            conexion.query = string.Format("SELECT * FROM LOS_METATECLA.Rol");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                while (conexion.lector.Read())
                {
                    Rol rol = new Rol((int)(decimal)conexion.lector["Id_Rol"], (string)conexion.lector["Nombre"], (bool)conexion.lector["Habilitado"]);
                    roles.Add(rol);
                }
            }
            foreach (Rol rol in roles) {
               List<Funcionalidad> listFunRol = DBFunc.obtenerFuncRol(rol);
               rol.funcionalidades = listFunRol;
            }
            conexion.cerrarConexion();
            return roles;
        }


         public void AgregarRol(string nombre, bool estado, List<Funcionalidad> funcionalidadesRol)
         { //No se si esta bien hecho el tema de ejecutarStoredProcedure
             List<SqlParameter> ListParam = new List<SqlParameter>();
             //1. Primero agrego a la tabla de roles
             ListParam.Add(new SqlParameter("@nombre", nombre));
             ListParam.Add(new SqlParameter("@estado", estado));
             Conexion cnx = new Conexion();
             cnx.ejecutarStoredProcedureSinRet("LOS_METATECLA.AgregarNuevoRol", ListParam);
             //2. Agrego a Funcionalidades_Rol todas las funcionalidades de este rol
             FuncionalidadDB DBFuncionalidad = new FuncionalidadDB();
             foreach (Funcionalidad funcionalidad in funcionalidadesRol)
             {
                 DBFuncionalidad.AgregarFuncionalidadDelRol(nombre, funcionalidad);
             }
         }

         public void actualizarRol(Rol rol) {
             List<SqlParameter> ListParam = new List<SqlParameter>();
             ListParam.Add(new SqlParameter("@nombre", rol.nombre));
             ListParam.Add(new SqlParameter("@estado", rol.habilitado));
             ListParam.Add(new SqlParameter("@id_rol", rol.id));
             Conexion conexion = new Conexion();
             conexion.ejecutarQueryConParam("UPDATE LOS_METATECLA.Rol SET Habilitado = @estado, Nombre = @nombre WHERE Id_Rol = @id_rol", ListParam);
             FuncionalidadDB DBFunc = new FuncionalidadDB();
             DBFunc.actualizarFuncionalidadesRol(rol);
         }

         public void deshabilitarRol(Rol rol) {
             Conexion conexion = new Conexion();
             List<SqlParameter> ListParam = new List<SqlParameter>();
             ListParam.Add(new SqlParameter("@id_rol", rol.id));
             conexion.ejecutarQueryConParam("UPDATE LOS_METATECLA.Rol SET Habilitado = 0 WHERE Id_Rol = @id_rol", ListParam);

             
         }

    
    
    }
}
