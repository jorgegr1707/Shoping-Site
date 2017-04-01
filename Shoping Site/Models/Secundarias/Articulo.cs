using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Models.Secundarias
{
    public class Articulo
    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public string ima { get; set; }
        public string ID { get; set; }

        public Articulo(string id, string nombre, int precio, string ima)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.ima = ima;
            this.ID = id;
        }

    }
}