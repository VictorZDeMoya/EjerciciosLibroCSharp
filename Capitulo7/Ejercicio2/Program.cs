using System;
using System.Collections.Generic;

namespace Diccionario
{
    class Program
    {
        public static void Main()
        {
            Dictionary<string, string> apertura = new Dictionary<string, string>();

            // Asociación archivos:
            apertura.Add("png", "SnagIt Editor");
            apertura.Add("txt", "Notepad++");
            apertura.Add("html", "Google Chrome");
            apertura.Add("docx", "Microsoft Word");

            foreach (KeyValuePair<string, string> kvp in apertura)
            {
                Console.WriteLine("La extensión `{0}` está asociada con `{1}`.",
                    kvp.Key, kvp.Value);
            }
        }
    }
}
