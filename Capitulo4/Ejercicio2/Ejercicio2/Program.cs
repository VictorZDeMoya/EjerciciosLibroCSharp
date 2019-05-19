using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado, n;
            int p;
            Console.WriteLine("Digite el numero que desea elevar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a que deseas elevarlo: ");
            p = int.Parse(Console.ReadLine());
            resultado = Math.Pow(n, p);
            Console.WriteLine("El numero " + n + " elevada a " + p + " es igual a " + resultado);
            Console.ReadLine();
        }
    }
}
