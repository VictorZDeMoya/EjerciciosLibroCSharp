using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0, menor = 0, e = 0;
            Console.WriteLine("Cuantas edades desea ingresar");
            int edades = int.Parse(Console.ReadLine());
            for (int i = 1; i <= edades; i++)
            {
                Console.WriteLine("Digite la edad: ");
                e = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = e;
                    menor = e;
                }
                if (e > mayor) { mayor = e; }
                if (e < menor) { menor = e; }



                e = 0;
            }

            Console.WriteLine(" La edad mayor es: " + mayor);
            Console.WriteLine(" La edad más joven es: " + menor);
        }
    }
}
