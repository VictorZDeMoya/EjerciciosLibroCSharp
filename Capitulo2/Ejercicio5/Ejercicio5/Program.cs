using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pesos;
            Console.Write("1. Conversión Dolar | 2. Conversión Euro:\n");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Seleccionaste: DOLAR.\n");
                    Console.WriteLine("Digite la cantidad a convertir: ");
                    pesos = int.Parse(Console.ReadLine());
                    Console.Write("Su conversión es de: " + pesos * 50.68);
                    break;
                case 2:
                    Console.Write("Seleccionaste: EURO.\n");
                    Console.WriteLine("Digite la cantidad a convertir: ");
                    pesos = int.Parse(Console.ReadLine());
                    Console.Write("Su conversión es de: " + pesos * 56.93);
                    break;
                default:
                    Console.Write("Digite una opción del 1 al 2.");
                    break;
            }
        }
    }
}
