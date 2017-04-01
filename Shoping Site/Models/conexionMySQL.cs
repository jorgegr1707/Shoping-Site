using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Shoping_Site.Models
{
    public class conexionMySQL
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost; userId=root; password=admin; database=proyecto;");
        private MySqlCommand cmd;

        public conexionMySQL() { }

        public bool abrirConexion()
        {
            try
            {
                cmd = new MySqlCommand();
                conn.Open();
                return true;
            }
            catch
            {
                
            }
            return false;
        }

        public int consultaNombreUsuarios(Parametros [] datos)
        {
            abrirConexion();
            cmd.CommandText = "spConsultaNombreUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue(datos[0].Nombre, datos[0].Valor);
            
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla.Rows.Count;
            

        }

        public int verificarUsuario(Parametros [] datos)
        {
            abrirConexion();
            cmd.CommandText = "spVerificaUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            

            for(int i = 0; i < datos.Length; i++)
            {
                cmd.Parameters.AddWithValue(datos[i].Nombre, datos[i].Valor);
            }

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            cerrarConexion();
            return tabla.Rows.Count;

        }

        public int verificarAdmin(Parametros[] datos)
        {
            abrirConexion();
            cmd.CommandText = "spVerificaAdmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            for(int i = 0; i < datos.Length; i++)
            {
                cmd.Parameters.AddWithValue(datos[i].Nombre, datos[i].Valor);
            }

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            cerrarConexion();
            return tabla.Rows.Count;
        }

        public void insertarUsuario(Parametros [] datos)
        {
            //string comando = "INSERT INTO usuario(username, password) VALUES('" + pUsername + "', '" + pPassword + "');";
            MySqlCommand cmd = new MySqlCommand("spInsertarUsuario", conn);
            //cmd.CommandText = "spInsertarUsuario";
            //cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < datos.Length; i++)
            {
                cmd.Parameters.AddWithValue(datos[i].Nombre, datos[i].Valor);
            }
            cmd.ExecuteNonQuery();
            cerrarConexion();
            /*MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla.Rows.Count;*/

        }

        public void cerrarConexion()
        {
            conn.Close();
        }

    }
}