using System;

namespace Ejercicio_4_Desafio_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mayor de 3 números";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            //Estableciendo variables
            Double num1, num2, num3;

            //Introduciendo datos
            Console.Write("Ingrese el primer número: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Double.Parse(Console.ReadLine());
            Console.Write("Imgrese el tercer número: ");
            num3 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            //IF and ELSE
            if (num1 > num2 && num1 > num3)
            {
                Console.Write("El número mayor es: " + num1 + ", que es el primer número ingresado.");
            }
            else if ( num2 > num3 )
            {
                Console.Write("El número mayor es: "+ num2 + ", que es el segundo número ingresado.");
            }
            else
            {
                Console.Write("El número mayor es: " + num3 + ", que es el tercer número ingresado.");
            }
            Console.WriteLine();
            Console.WriteLine("Fin del programa...");
            Console.ReadKey();
        }
    }
}
