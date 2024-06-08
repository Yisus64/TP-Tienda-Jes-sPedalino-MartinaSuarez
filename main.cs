using System;
using System.Collections.Generic;

namespace Tp2AAT{
    class Program { 
        private static Tienda tienda = Tienda.crearTienda(new Tienda());
        private static Carrito carrito = new Carrito();
        private static Cliente cliente = new Cliente();
        private static Vendedor vendedor = new Vendedor();
        private static int opcion = 0;   
        public static void Main(string[] args) {
            Console.WriteLine("Bienvenido a nuestra tienda, es usted\n 1: Cliente \n 2: Empleado \n 3: Salir");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1){
                cliente.Seleccionar(tienda, carrito, cliente, vendedor);
            } else if (opcion == 2){
                vendedor.Seleccionar(tienda, carrito, cliente, vendedor);
            } else if (opcion == 3){
                Console.WriteLine("Gracias por su visita");
            } else {
                Console.WriteLine("Ingrese una opcion valida");
            }
        }
    }
}
