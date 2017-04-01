using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Models
{
    public class Logins
    {
        private Usuario usuario = new Usuario();

        public Boolean verificarUsuario(string user, string contrasena) {
            // conecta con base y retorna true si es un usuario o false si no es un usuario
            return usuario.verificarUsuario(user, contrasena);
            
        }


        public Boolean crearCuenta(string nombre, string user, string contrasena){
            // conecta con base y retorna true si un usuario se crea o false si no
            return usuario.agregarUsuario(nombre, user, contrasena);
        }

        public Boolean verificarAdmin(string user, string contrasena){
            // conecta con base y retorna true si es un admin o false si no es un admin
            return usuario.verificarAdmin(user, contrasena);
        }

    }
}