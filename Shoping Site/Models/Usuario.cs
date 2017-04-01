using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Models
{
    public class Usuario
    {
        private string name;
        private string username;
        private string contrasena;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }

        }

        private Parametros[] datos;

        public bool agregarUsuario(string pNombre, string pUsername, string pContrasena)
        {

            conexionMySQL conexionmysql = new conexionMySQL();
            conexionNeo4j conexionNeo = new conexionNeo4j();
            //conexionNeo.crearUsuario(pNombre, pUsername, pContrasena);
            if (conexionmysql.abrirConexion())
            {
                datos = new Parametros[2];
                datos[0] = new Parametros("pUsername", pUsername);
                datos[1] = new Parametros("pPassword", pContrasena);
                if (conexionmysql.consultaNombreUsuarios(datos) == 0)
                {
                    conexionmysql.insertarUsuario(datos);
                    conexionNeo.crearUsuario(pNombre, pUsername, pContrasena);
                    return true;
                }
                else { return false; }


            }
            else
            {
                //retornar para saber que fallo
                return false;
            }




            //Conexiones conexion = new Conexiones();
            //GraphClient conexionNeo = conexion.abrirConexionNeo();      //Abre conexion con Neo4j
            //MySqlCommand conexionMySQL = conexion.abrirConexionMysql(); //Abre conexion con MySQL


            //Console.Write("INSERT INTO usuario(cedula, nombre) VALUES('" + pNombre + "', '" + pContrasena + "');");
            /*var newUsuario = new Usuario { Name = pNombre, username = pUsername, contrasena = pContrasena };
            conexionNeo.Cypher
                .Create("(user:User {nodo})")
                .WithParam("nodo", newUsuario)
                .ExecuteWithoutResults();*/

        }

        public bool verificarUsuario(string pUsername, string pPassword)
        {
            conexionMySQL conexionmysql = new conexionMySQL();
            conexionNeo4j conexionNeo = new conexionNeo4j();

            if (conexionmysql.abrirConexion())
            {
                datos = new Parametros[2];
                datos[0] = new Parametros("pUsername", pUsername);
                datos[1] = new Parametros("pPassword", pPassword);

                if(conexionmysql.verificarUsuario(datos) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool verificarAdmin(string pUsername, string pPassword)
        {
            conexionMySQL conexionmysql = new conexionMySQL();
            
            if (conexionmysql.abrirConexion())
            {
                datos = new Parametros[2];
                datos[0] = new Parametros("pUsername", pUsername);
                datos[1] = new Parametros("pPassword", pPassword);

                if (conexionmysql.verificarAdmin(datos) != 0)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}