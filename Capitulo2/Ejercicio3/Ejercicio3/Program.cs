using System;
using System.Data;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int grados;
            Console.WriteLine("Digite grados: ");
            grados = int.Parse(Console.ReadLine());

            Console.Write("La conversion es: " + (Math.PI / 180) * grados);

        }

    }
}
