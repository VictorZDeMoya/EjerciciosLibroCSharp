using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;

            Console.WriteLine("Ingrese el lado: ");
            lado = int.Parse(Console.ReadLine());

            Console.Write("El perimetro del poligono es: " + lado * 5);

            Console.ReadKey();
        }
    }
}
