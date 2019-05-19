using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa Grados Celsius: ");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + (32);

            Console.WriteLine(c + "ºC equivale a " + f + "ºF");

            Console.ReadLine();
        }
    }
}
