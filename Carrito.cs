using System;
using System.Collections.Generic;

namespace Tp2AAT{
        public class Carrito{

            public List<(Producto, int)> carro = new List<(Producto, int)>();
            private float subtotal = 0;
            

            public void agregarCarrito(Producto p, int cantidad, List<Producto> productos){
                if (productos.IndexOf(p) != -1) {
                    if (cantidad <= p.getStock()){
                        for (int i = 0; i < carro.Count; i++) {
                            if (carro[i].Item1 == p) {
                                this.carro[i] = (carro[i].Item1, carro[i].Item2 + cantidad);
                                this.subtotal += p.getPrecio() * cantidad;
                                p.quitarStock(cantidad);
                                return;
                            }
                        }
                        this.carro.Add((p, cantidad));
                        this.subtotal += p.getPrecio() * cantidad;
                        p.quitarStock(cantidad);
                    } else {
                        Console.WriteLine("No hay suficiente stock");
                    } 
                } else {
                    Console.WriteLine("El producto no existe");
                }

                if (productos[productos.IndexOf(p)].getStock() == 0) {
                    productos.Remove(productos[productos.IndexOf(p)]);
                }
            }

            public void quitarCarrito(Producto p, int cantidad, List<Producto> productos) {
                for (int i = 0; i < carro.Count; i++) {
                    if (carro[i].Item1 == p) {
                        if (carro[i].Item2 >= cantidad) {
                            this.subtotal -= p.getPrecio() * cantidad;
                            carro[i] = (carro[i].Item1, carro[i].Item2 - cantidad);
                            productos[productos.IndexOf(p)].agregarStock(cantidad);
                        } else {
                            Console.WriteLine("No hay suficiente cantidad en el carro");
                        }
                        if (carro[i].Item2 <= 0) {
                            this.carro.RemoveAt(i);
                        }
                        break; 
                    }
                }
            }
            public void getCarrito(){
                int i = 0;
                foreach(var prod in this.carro){
                    Console.WriteLine($"{i}" + ": " + prod.Item1.getNombre() + " | Cantidad: " + prod.Item2);
                    i++;
                }
            }
            public float getSubtotal(){
                return this.subtotal;
            }

            public void vaciarCarrito(){
                this.carro.Clear();
                this.subtotal = 0;
            }
        }
    }