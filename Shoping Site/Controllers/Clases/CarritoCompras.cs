using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Site.Controllers.Clases
{
    public static class CarritoCompras
    {
        // esta clase almacena los articulos que se van agregando al carrito de compras

        // atributos generales
        static List<ObjetoVenta> carrito = new List<ObjetoVenta>();




        public static List<ObjetoVenta> todosObjetosCarrito(){
            // retorna todo el carrito 
            return carrito;
        }

        public static void eliminarDelCarrito(string id){
            // debo agregar al carrito el objeto con ese id de la tienda
            ObjetoVenta obj = null;
            foreach (var item in carrito)
            {
                if (item.ID == id){
                    obj = item;
                    break;
                }
            }
            // Cuando encuentra el articulo lo agrega al carrito
            carrito.Remove(obj);
        }

 
        public static void agregarAlCarrito(string id){
            // debo agregar al carrito el objeto con ese id de la tienda
            ObjetoVenta obj = null;
            foreach (var item in AlmacenArticulos.todosObjetosTienda())
            {
                if (item.ID == id){
                    obj = item;
                    break;
                }
            }
            // Cuando encuentra el articulo lo agrega al carrito
            carrito.Add(obj);
        }
    }
}