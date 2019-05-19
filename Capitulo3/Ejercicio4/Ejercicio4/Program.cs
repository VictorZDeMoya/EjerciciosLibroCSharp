using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entre 1 y 7: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("Lunes");
                    break;
                case 2:
                    Console.Write("Martes");
                    break;
                case 3:
                    Console.Write("Miercoles");
                    break;
                case 4:
                    Console.Write("Jueves");
                    break;
                case 5:
                    Console.Write("Viernes");
                    break;
                case 6:
                    Console.Write("Sabado");
                    break;
                case 7:
                    Console.Write("Domingo");
                    break;
                default:
                    Console.Write("Se ingreso un valor fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
