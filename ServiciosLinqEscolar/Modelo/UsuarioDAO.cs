using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosLinqEscolar.Modelo
{
    public static class UsuarioDAO
    {
        public static List<Usuario> obtenerUsuarios()
        {
            DataClassesEscolarUVDataContext conexionBD = getConnection();

            IQueryable < Usuario > usuario = from usuarioQuery in conexionBD.Usuario select usuarioQuery;

            return usuario.ToList();
        }


        public static Usuario iniciarSesion(string username, string password)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuario = (from userlogin in conexionBD.Usuario
                               where userlogin.username == username &&
                               userlogin.password == password
                               select userlogin).FirstOrDefault();
                return usuario;

            } catch
            {
                return null;
            }
        }

        public static Boolean guardarUsuario(Usuario usuarioNuevo)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuario = new Usuario()
                {
                    nombre = usuarioNuevo.nombre,
                    apellidoPaterno = usuarioNuevo.apellidoPaterno,
                    apellidoMaterno = usuarioNuevo.apellidoMaterno,
                    username = usuarioNuevo.username,
                    password = usuarioNuevo.password
                };

                conexionBD.Usuario.InsertOnSubmit(usuario);
                conexionBD.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static Boolean editarUsuario(Usuario usuarioEdicion)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuario = (from UsuarioEdicion in conexionBD.Usuario
                               where usuarioEdicion.idUsuario == usuarioEdicion.idUsuario
                               select usuarioEdicion).FirstOrDefault();

                if (usuario != null)
                {
                    usuario.nombre = usuarioEdicion.nombre;
                    usuario.apellidoPaterno = usuarioEdicion.apellidoPaterno;
                    usuario.apellidoPaterno = usuarioEdicion.apellidoMaterno;
                    usuario.password = usuarioEdicion.password;
                    conexionBD.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public static Boolean eliminarUsuario(int idUsuario)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();
                Usuario UsuarioEliminar = (from usuario in conexionBD.Usuario
                                           where usuario.idUsuario == idUsuario
                                           select usuario).FirstOrDefault();

                if(UsuarioEliminar != null)
                {
                    conexionBD.Usuario.DeleteOnSubmit(UsuarioEliminar);
                    conexionBD.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataClassesEscolarUVDataContext getConnection()
        {
            return new DataClassesEscolarUVDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["escolarUVConnectionString"].ConnectionString);

        }
    }
    
}