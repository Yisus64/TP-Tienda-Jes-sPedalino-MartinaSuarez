using System;

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
            this.stock = 0;
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
    }
}