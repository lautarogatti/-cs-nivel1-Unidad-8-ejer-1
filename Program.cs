﻿using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.*/
            int precio = 0, cant = 0, montoTotal = 0;
            Console.WriteLine("Ingrese el precio");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad");
            cant = int.Parse(Console.ReadLine());
            montoTotal = producto(precio, cant);
            Console.WriteLine("El monto total de su compra es: " + montoTotal);
        }
        static int producto (int precio, int cant){
            int resultado;
            resultado = precio * cant;
            return resultado;
        }
    }
}
