using System;

namespace Tp2AAT{

    public class Producto{

        private string nombre;
        private int precio;
        private int costo;       
        private int stock;

        public Producto(){
            this.nombre = crearNombre();
            this.costo = crearCosto();
            this.precio = calcularPrecio();
            this.stock = stock;
        }

        private string crearNombre(){
            Console.WriteLine("Ingrese el nombre del producto");
            while (true) {
                string nombre = Console.ReadLine();
                if (nombre.Length != null) {
                    return nombre;
                } else {
                    Console.WriteLine("El nombre no puede estar vacio");
                }
            } 
        }

        private double crearCosto(){
            Console.WriteLine("Ingrese el costo del producto");
            while (true) {
                int costo = int.Parse(Console.ReadLine());
                if (costo != null) {
                    return costo;
                } else {
                    Console.WriteLine("El costo no puede estar vacio");
                }
            } 
        }

        private int calcularPrecio(){
            return this.costo + (this.costo * 0.3);
        }
    }
}

class Program {
    static void Main (string[] args){
        Producto product = new Producto();
        Console.WriteLine(product.nombre);
        Console.WriteLine(product.costo);
        Console.WriteLine(product.precio);
        Console.WriteLine(product.stock);
    }

}