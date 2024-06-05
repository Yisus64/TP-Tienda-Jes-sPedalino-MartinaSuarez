using System;
using System.Collections.Generic;

namespace Tp2AAT
{
    public class Tienda
    {
        public List<Producto> productos = new List<Producto>();
        private float caja = 0;

        public static Tienda crearTienda(Tienda tienda){ 
            tienda.agregarProductoTiendaDef(new Producto("Desodorante", 5000, 50));
            tienda.agregarProductoTiendaDef(new Producto("Vaso", 1000, 13));
            tienda.agregarProductoTiendaDef(new Producto("Lampara", 30000, 55));
            tienda.agregarProductoTiendaDef(new Producto("Vino", 10000, 38));
            tienda.agregarProductoTiendaDef(new Producto("Celular", 1000000, 74));
            tienda.agregarProductoTiendaDef(new Producto("Monitor", 500000, 3));
            tienda.agregarProductoTiendaDef(new Producto("Panel de Vidro", 60000, 94));
            tienda.agregarProductoTiendaDef(new Producto("Cinturon", 8000, 27));
            tienda.agregarProductoTiendaDef(new Producto("Block de Notas", 3000, 43));
            tienda.agregarProductoTiendaDef(new Producto("Tablon", 10000, 85));
            tienda.agregarProductoTiendaDef(new Producto("Pajita", 700, 34));
            tienda.agregarProductoTiendaDef(new Producto("Coca-Cola", 1500, 52));
            tienda.agregarProductoTiendaDef(new Producto("Lapicera", 900, 91));
            tienda.agregarProductoTiendaDef(new Producto("Cinta Adhesiva", 800, 16));
            tienda.agregarProductoTiendaDef(new Producto("Zapatilla", 7500, 1));
            tienda.agregarProductoTiendaDef(new Producto("Paraguas", 9200, 7));
            tienda.agregarProductoTiendaDef(new Producto("Polo", 35000, 12));
            tienda.agregarProductoTiendaDef(new Producto("Ventilador", 40000, 73));
            tienda.agregarProductoTiendaDef(new Producto("Almohada", 6800, 29));
            tienda.agregarProductoTiendaDef(new Producto("Sabana", 7200, 23));
            tienda.agregarProductoTiendaDef(new Producto("Mochila", 6000, 89));
            return tienda;
        }

        public void agregarProductoTiendaDef(Producto nuevo){
            this.productos.Add(nuevo);
        }

        public void agregarProductoTienda(){
            bool add = true;
            Producto nuevo = new Producto();
            foreach(Producto producto in this.productos){
                if (producto.getNombre().ToLower() == nuevo.getNombre().ToLower()){
                    add = false;
                    break;
                }
            }
            if (add){
                this.productos.Add(nuevo);
            } else {
                Console.WriteLine("El producto ya existe");
            }
        }

        public void quitarProductoTienda(Producto producto){
            this.productos.Remove(producto);
        }

        public float cobrar(Carrito carrito, float dinero){
            if (carrito.getSubtotal() > dinero){
                Console.WriteLine("No hay suficiente dinero");
                return -1;
            } else {
                dinero -= carrito.getSubtotal();
                this.caja += carrito.getSubtotal();
            }
            if (dinero == 0) {
            Console.WriteLine("Gracias por su compra");
            return dinero;
            } else {
                Console.WriteLine("Su vuelto es de: " + dinero);
                return dinero;
        }

        }

        public List<Producto> getProductos(){
            return this.productos;
        }

        public float getCaja(){
            return this.caja;
        }
    }
}