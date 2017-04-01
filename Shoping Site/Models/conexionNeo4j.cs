using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Neo4jClient;

namespace Shoping_Site.Models
{
    public class conexionNeo4j
    {
        private GraphClient conexionNeo;

        public conexionNeo4j() {
            conexionNeo = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "admin"); ;
        }


        public void crearUsuario(string pNombre, string pUsername, string pPassword)
        {
            var newUser = new Usuario { Name = pNombre, Username = pUsername, Contrasena = pPassword };
            conexionNeo.Connect();
            conexionNeo.Cypher
                .Create("(user:User {newUser})")
                .WithParam("newUser", newUser)
                .ExecuteWithoutResults();
        }
    }
}