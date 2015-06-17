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
            foreach (Rol rol in roles)
            {
                List<Funcionalidad> listFunRol = FuncionalidadDB.obtenerFuncRol(rol);
                rol.funcionalidades = listFunRol;
            }
            conexion.cerrarConexion();
            return roles;
        }


        public void AgregarRol(Rol nuevoRol)
        { //No se si esta bien hecho el tema de ejecutarStoredProcedure
            List<SqlParameter> ListParam = new List<SqlParameter>();
            //1. Primero agrego a la tabla de roles
            ListParam.Add(new SqlParameter("@nombre", nuevoRol.nombre));
            ListParam.Add(new SqlParameter("@estado", nuevoRol.habilitado));
            Conexion cnx = new Conexion();
            cnx.ejecutarQueryConParam("INSERT INTO LOS_METATECLA.Rol (Nombre,Habilitado) VALUES (@nombre,@estado)", ListParam);
            cnx.cerrarConexion();
            //2. Agrego a Funcionalidades_Rol todas las funcionalidades de este rol
            FuncionalidadDB DBFuncionalidad = new FuncionalidadDB();
            foreach (Funcionalidad funcionalidad in nuevoRol.funcionalidades)
            {
                DBFuncionalidad.AgregarFuncionalidadDelRol(nuevoRol.nombre, funcionalidad);
            }
        }

        public void actualizarRol(Rol rol)
        {
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@nombre", rol.nombre));
            ListParam.Add(new SqlParameter("@estado", rol.habilitado));
            ListParam.Add(new SqlParameter("@id_rol", rol.id));
            Conexion conexion = new Conexion();
            conexion.ejecutarQueryConParam("UPDATE LOS_METATECLA.Rol SET Habilitado = @estado, Nombre = @nombre WHERE Id_Rol = @id_rol", ListParam);
            FuncionalidadDB DBFunc = new FuncionalidadDB();
            DBFunc.actualizarFuncionalidadesRol(rol);
        }

        public void deshabilitarRol(Rol rol)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id_rol", rol.id));
            conexion.ejecutarQueryConParam("UPDATE LOS_METATECLA.Rol SET Habilitado = 0 WHERE Id_Rol = @id_rol", ListParam);


        }
        
        //Devuelve lista con los id de los roles
        public static List<int> getRolesUsuario(int idUsuario)
        {
            List<int> rolesUsuario = new List<int>();
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id", idUsuario));
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT Id_Rol FROM LOS_METATECLA.Usuario_Rol WHERE Id_Usuario = @id", ListParam);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    rolesUsuario.Add((int)(decimal)lector["Id_Rol"]);
                }
            }
            conexion.cerrarConexion();
            return rolesUsuario;
        }

        public static Rol getRol(int id)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id", id));
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT * FROM LOS_METATECLA.Rol WHERE Id_Rol = @id", ListParam);
            lector.Read();
            Rol rol = new Rol((int)(decimal)lector["Id_Rol"],(string)lector["Nombre"],(bool)lector["Habilitado"]);
            rol.funcionalidades = FuncionalidadDB.obtenerFuncRol(rol);
            conexion.cerrarConexion();
            return rol;
        }

        public static int getId(string nombre)
        {
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@nombre", nombre));
            SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT Id_Rol FROM LOS_METATECLA.Rol WHERE Nombre = @nombre", ListParam);
            lector.Read();
            int id = (int)(decimal)lector["Id_Rol"];
            conexion.cerrarConexion();
            return id;
        }
    }
}
