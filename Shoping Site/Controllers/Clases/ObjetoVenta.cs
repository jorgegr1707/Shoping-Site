using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Controllers.Clases
{
    public class ObjetoVenta
    {
        // esta clase crea instancias de los objetos que se van a vender en la tienda.
        public string nombre { get; set; }
        public int precio { get; set; }
        public string ima { get; set; }
        public string ID { get; set; }

        public ObjetoVenta(string id, string nombre, int precio, string ima) {
            this.nombre = nombre;
            this.precio = precio;
            this.ima = ima;
            this.ID = id;
        }
    }
}