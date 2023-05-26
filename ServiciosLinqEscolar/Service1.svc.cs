using ServiciosLinqEscolar.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosLinqEscolar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
       public List<Usuario> ObtenerUsuarios()
        {
            return UsuarioDAO.obtenerUsuarios();
        }

        public Boolean GuardarUsuario(Usuario usuarioNuevo)
        {
            if(UsuarioDAO.guardarUsuario(usuarioNuevo) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario IniciarSesion(string username, string password) 
        {
            return UsuarioDAO.iniciarSesion(username, password);
        }

        public Boolean EditarUsuario(Usuario usuario)
        {
            return UsuarioDAO.editarUsuario(usuario);
        }

        public Boolean EliminarUsuario(int idUsuario)
        {
            return UsuarioDAO.eliminarUsuario(idUsuario);
        }
    }
}
