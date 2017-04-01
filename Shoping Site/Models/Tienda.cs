using Shoping_Site.Models.Secundarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Models
{
    public class Tienda
    {
        public void insertarEnTienda(Articulo obj){
            // inserta objetos a la tienda
            // se conecta en la base para crear un objeto en la tienda
        }

        public List<Articulo> articulosTienda(){
            // Retorna todos los objetos disponibles en la tienda

            // debe retornar todos los articulos de la tienda
            // debe pedir esos objetos a las bases

            // para probar
            List<Articulo> objetosTienda = new List<Articulo>();
            objetosTienda.Add(new Articulo("id1", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id2", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id3", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id4", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id5", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id6", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id7", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id8", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id9", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id10", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id11", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id12", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new Articulo("id13", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            return objetosTienda;
        }

    }
}