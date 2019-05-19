using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int n1, n2;
            Console.Write("1. Perimetro | 2. Area ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Digite el lado: ");
                    lado = int.Parse(Console.ReadLine());
                    Console.Write("El perimetro del poligono es: " + lado * 5);
                    break;
                case 2:
                    Console.WriteLine("Digite la longitud: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite apotema: ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.Write("El area del poligono es: " + ((5 * n1 * n2) / 2));
                    break;
                default:
                    Console.Write("Por favor digite del 1 al 2.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
