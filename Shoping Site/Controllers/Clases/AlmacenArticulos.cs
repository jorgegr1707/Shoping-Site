using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Controllers.Clases
{
    public static class AlmacenArticulos
    {
                                        // atributos generales
        static List<ObjetoVenta> objetosTienda = new List<ObjetoVenta>();
        
        // metodos generales
        public static List<ObjetoVenta> todosObjetosTienda(){
            // retorna todos los objetos de la tineda, objetos tienda es el almacen donde se encuantran
            // todos los objetos que existen en la tienda. 
            return objetosTienda;
        }

        public static void insertarEnTienda(ObjetoVenta obj){
            // inserta objetos a la tienda
            objetosTienda.Add(obj);
        }

        public static void llenar(){
            // la limpia para que no se haga enorme
            objetosTienda.Clear();

            // este metodo se debe cambiar para que tome los objetos de la BD
            objetosTienda.Add(new ObjetoVenta("id1", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id2", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id3", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id4", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id5", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id6", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id7", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id8", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id9", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id10", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id11", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id12", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id13", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
            objetosTienda.Add(new ObjetoVenta("id14", "Cocina", 25000, "https://ayudawp.com/wp-content/uploads/2013/10/miniatura-wordpress.jpg"));
        }


        }
}