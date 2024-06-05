using System;

namespace Tp2AAT
{
    class Program {
       static void Main (string[] args){
                Producto product = new Producto();
                Console.WriteLine(product.getNombre());
                Console.WriteLine(product.getCosto());
                Console.WriteLine(product.getPrecio());
                Console.WriteLine(product.getStock());
        }
    }
}