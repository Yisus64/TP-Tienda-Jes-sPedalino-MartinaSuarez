using System;
using System.Collections.Generic;

namespace Tp2AAT
{
    class Program {

                private static Tienda tienda = Tienda.crearTienda(new Tienda());
                private static Carrito carrito = new Carrito();

                public static void Main(string[] args) {
                    foreach (Producto producto in tienda.getProductos()){
                    Console.WriteLine(producto.getInfo());
                }
                carrito.agregarCarrito(tienda.productos[1], 3, tienda.productos);
                carrito.agregarCarrito(tienda.productos[2], 1, tienda.productos);
                carrito.agregarCarrito(tienda.productos[3], 1, tienda.productos);
                carrito.agregarCarrito(tienda.productos[4], 1, tienda.productos);
                Console.WriteLine(carrito.getSubtotal());
                carrito.quitarCarrito(tienda.productos[1], 2, tienda.productos);
                carrito.quitarCarrito(tienda.productos[4], 1, tienda.productos);
                carrito.quitarCarrito(tienda.productos[5], 1, tienda.productos);
                Console.WriteLine(carrito.getSubtotal());
                Console.WriteLine(tienda.cobrar(carrito, 2000000));

                tienda.agregarProductoTienda();
                foreach (Producto producto in tienda.getProductos()){
                    Console.WriteLine(producto.getInfo());
                }
            }
                
        }
    }
