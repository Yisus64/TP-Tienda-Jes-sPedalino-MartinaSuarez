using System;
using System.Collections.Generic;

namespace Tp2AAT{
    public class Cliente{
        private static int variante;
        private static bool flag;
        private static int objeto;
        private static int cant_objeto;

        public Cliente(){
            variante = 0;
            flag = true;
            objeto = 0;
            cant_objeto = 0;
        }

        public void Seleccionar(Tienda tienda, Carrito carrito, Cliente cliente, Vendedor vendedor){
            while (flag){
                Console.WriteLine("Que desea hacer?: \n 1: Ver productos \n 2: Ingresar productos al carrito \n 3: Quitar productos del carrito  \n 4: Consultar carrito \n 5: Pagar \n 6: Cambiar a Vendedor \n 7: Salir");
                variante = int.Parse(Console.ReadLine());
                switch (variante){
                    case 1:
                        tienda.getProductos();
                        break;
                    case 2:
                        while (flag){
                            Console.WriteLine("Que desea ingresar?");
                            tienda.getProductos();
                            objeto = int.Parse(Console.ReadLine());
                            if (objeto > -1 && objeto < tienda.productos.Count){
                                Console.WriteLine("Cuantos desea?");
                                cant_objeto = int.Parse(Console.ReadLine());
                                if (cant_objeto > 0 && cant_objeto <= tienda.productos[objeto].getStock()){
                                    carrito.agregarCarrito(tienda.productos[objeto], cant_objeto, tienda.productos);
                                    flag = false;
                                } else {
                                    Console.WriteLine("No hay suficiente stock, solo hay " + tienda.productos[objeto].getStock());
                                }  
                            } else {
                                Console.WriteLine("Ingrese una opcion valida");
                            }
                        }
                        flag = true;
                        break;
                    case 3:
                        while (flag){
                            Console.WriteLine("Que desea quitar?");
                            carrito.getCarrito();
                            objeto = int.Parse(Console.ReadLine());
                            if (objeto > -1 && objeto <= carrito.carro.Count){
                                Console.WriteLine("Cuantos desea sacar?");
                                cant_objeto = int.Parse(Console.ReadLine());
                                if (cant_objeto > 0 && cant_objeto < carrito.carro[objeto].Item2){
                                    carrito.quitarCarrito(carrito.carro[objeto].Item1, cant_objeto, tienda.productos);
                                    flag = false;
                                } else {
                                    Console.WriteLine("No hay suficiente stock, solo hay " + carrito.carro[objeto].Item2);
                                }  
                            } else {
                                Console.WriteLine("Ingrese una opcion valida");
                            }
                        }
                        flag = true;
                        break;
                    case 4:
                        carrito.getCarrito();
                        Console.WriteLine("Subtotal: " + carrito.getSubtotal());
                        break;
                    case 5:
                        while (flag){
                            Console.WriteLine("Ingrese con cuanto va a pagar: ");
                            Console.WriteLine("Importe: " + carrito.getSubtotal());
                            float pago = float.Parse(Console.ReadLine());
                            if (tienda.cobrar(carrito, pago) == -1){
                                continue;
                            } else {
                                flag = false;
                            }
                        }
                        flag = true;
                        break;
                    case 6:
                        vendedor.Seleccionar(tienda, carrito, cliente, vendedor);
                        break;
                    case 7:
                        Console.WriteLine("Gracias por su visita");
                        flag = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            }
        }
    }
}