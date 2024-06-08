using System;
using System.Collections.Generic;

namespace Tp2AAT{
    public class Vendedor{
        private const string contrasena = "contraseña";
        private static int intentos;
        private static string sesion;
        private static bool bandera = true;
        private static int indice;

        public Vendedor(){
            intentos = 0;
            sesion = "";
        }

        public void Seleccionar(Tienda tienda, Carrito carrito, Cliente cliente, Vendedor vendedor){
            while (intentos < 3){
                    Console.WriteLine("Ingrese la contraseña");
                    sesion = Console.ReadLine();
                    if (sesion == contrasena){
                        Console.WriteLine("Bienvenido");
                        while (bandera){
                            Console.WriteLine("Que desea hacer?: \n 1: Ver productos \n 2: Ingresar productos a la tienda \n 3: Quitar productos de la tienda \n 4: Consultar dinero en caja \n 5: Cambiar a Cliente \n 6: Salir");
                            int opcion = int.Parse(Console.ReadLine());
                            switch (opcion){
                                case 1:
                                    tienda.getProductos();
                                    break;
                                case 2:
                                    tienda.agregarProductoTienda();                                  
                                    break;
                                case 3:
                                    Console.WriteLine("Ingrese el producto que desea quitar");
                                    tienda.getProductos();
                                    indice = int.Parse(Console.ReadLine());
                                    tienda.quitarProductoTienda(tienda.productos[indice]);
                                    break;
                                case 4:
                                    Console.WriteLine("Dinero en caja: " + tienda.getCaja());
                                    break;
                                case 5:
                                    cliente.Seleccionar(tienda, carrito, cliente, vendedor);
                                    break;
                                case 6:
                                    Console.WriteLine("Hasta pronto");
                                    bandera = false;
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida");
                                    break;
                            }
                        }
                        break;
                    } else {
                        Console.WriteLine("Contraseña incorrecta");
                        intentos++;
                    }
                }
                if (sesion != contrasena && intentos == 3){
                    Console.WriteLine("Ha superado el limite de intentos");
                }
        }      
    }
}