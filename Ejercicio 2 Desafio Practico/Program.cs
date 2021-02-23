using System;

namespace Ejercicio_2_Desafio_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Suma y Producto";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Declarar variables
            Double num1, num2, num3, num4, suma, producto;

            //Ingreso de datos
            Console.Write("Ingrese el valor del número 1: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del número 2: ");
            num2 = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del número 3: ");
            num3 = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del número 4: ");
            num4 = Double.Parse(Console.ReadLine());
            suma = num1 + num2;
            producto = num3 * num4;
            Console.WriteLine();

            //Resultado
            Console.Write("La suma del primer número con el segundo número es: " + suma);
            Console.WriteLine();
            Console.Write("El producto del tercer número con el cuarto número es: " + producto);
            Console.WriteLine();
            Console.WriteLine("Fin del programa...");

            Console.ReadKey();
        }
    }
}
