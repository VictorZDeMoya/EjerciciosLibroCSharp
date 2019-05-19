using System;
using System.Linq;

namespace CadenasALF
{
    class Program
    {
        static string[] Ordernar(string[] cadenas)
        {
            return (from c in cadenas orderby c select c).ToArray<string>();
        }

        static void Main()
        {
            string[] cadenas = { "No me funciona. ", "Qué hago."};
            cadenas = Ordernar(cadenas);
            Console.WriteLine("Ordenadas:");
            foreach (string s in cadenas)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
