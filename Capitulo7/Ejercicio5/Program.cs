using System;
using System.IO;
namespace AgendaTLF
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String Dijo = "Si";
            System.String Apellido;
            System.String Nombre;
            System.String Celular;

            string fileName = "AgendaTelf.txt";
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            while (Dijo == "Si")
            {
                Console.Write("Ingrese el Nombre: ");
                Nombre = Console.ReadLine();
                Console.Write("Ingrese el Apellido: ");
                Apellido = Console.ReadLine();
                Console.Write("Ingrese el Celular: ");
                Celular = Console.ReadLine();

                writer.WriteLine("{0} {1} {2}", Nombre, Apellido, Celular);
                Console.Write("¿Desea Ingresar otro? (Si/No): ");
                Dijo = Console.ReadLine();
            }
            writer.Close();
        }
    }
}
