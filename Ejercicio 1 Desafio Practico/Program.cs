using System;

namespace Ejercicio_1_Desafio_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Precio total de artículos";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Varianles
            Double precio, total;
            int cantidad;

            //Ingreso de datos
            Console.Write("Ingrese el precio del artículo: $");
            precio = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de artículos: ");
            cantidad = int.Parse(Console.ReadLine());
            total = precio * cantidad;
            Console.WriteLine();

            //Resultado
            Console.WriteLine("El valor total que el comprador debe pagar es: $" + total);
            Console.WriteLine();
            Console.WriteLine("Fin del programa...");

            Console.ReadKey();
        }
    }
}
