using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite el numero");
            n = int.Parse(Console.ReadLine());

            if ((n % 2) == 0)
                Console.WriteLine("Es Par");
            else
                Console.WriteLine("Es Impar");
        }
    }
}
