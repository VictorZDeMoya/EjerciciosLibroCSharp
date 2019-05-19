using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, resultado;
            Console.WriteLine("Digite el numero que desea ver multiplicado: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = n * i;
                Console.WriteLine(n + " * " + i + " = " + resultado);
            }
           
        }
    }
}
