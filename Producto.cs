using System;
using System.Collections.Generic;

namespace Tp2AAT{

    public class Producto{

        private string nombre;
        private float precio;
        private float costo;       
        private int stock;

    
        public Producto(){
            this.nombre = crearNombre();
            this.costo = crearCosto();
            this.precio = calcularPrecio();
            this.stock = definirStock();
        }

        public Producto(string nombre, float costo, int stock){
            this.nombre = nombre;
            this.costo = costo;
            this.precio = calcularPrecio();
            this.stock = stock;
        }

        private string crearNombre(){
            Console.WriteLine("Ingrese el nombre del producto");
            while (true) {
                string nombre = Console.ReadLine();
                if (nombre.Length != 0) {
                    return nombre;
                } else {
                    Console.WriteLine("El nombre no puede estar vacio");
                }
            } 
        }

        private float crearCosto(){
            Console.WriteLine("Ingrese el costo del producto");
            while (true) {
                float costo = float.Parse(Console.ReadLine());
                if (costo != 0) {
                    return costo;
                } else {
                    Console.WriteLine("El costo no puede estar vacio");
                }
            } 
        }

        private float calcularPrecio(){
            return this.costo + (float)(this.costo * 0.3);
        }

        private int definirStock(){
            Console.WriteLine("Ingrese el stock del producto");
            while (true) {
                int stock = int.Parse(Console.ReadLine());
                if (stock >= 0) {
                    return stock;
                } else {
                    Console.WriteLine("El stock no puede ser negativo");
                }
            } 
        }

        public void quitarStock(int cantidad){
            this.stock = this.stock - cantidad;
        }

        public void agregarStock(int cantidad){
            this.stock += cantidad;
        }

        public string getNombre(){
            return this.nombre;
        }

        public float getCosto(){
            return this.costo;
        }

        public float getPrecio(){
            return this.precio;
        }

        public int getStock(){
            return this.stock;
        }

        public string getInfo(){
            return "Nombre: " + this.getNombre() + " | Precio: " + this.getPrecio() + " | Stock: " + this.getStock();
        }
    }
}