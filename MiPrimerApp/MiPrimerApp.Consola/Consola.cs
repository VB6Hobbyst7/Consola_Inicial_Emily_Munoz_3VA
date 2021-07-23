using System;

namespace MiPrimerApp.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            static void SaludoInicial(String[] args)
            {
                void metodo(String[] args)
                {
                    if (args.Length > 0)
                        Console.WriteLine("Hola {0} {1} {2} {3} {4} {5}" + args[0], args[1], args[2], args[3], args[4], args[5]);
                    else
                    {
                        Console.WriteLine("Hola Desconocido ");
                    }

                    Console.WriteLine("\n¿Cómo estás?\n");
                    var estado = Console.ReadLine();
                    Console.WriteLine("\nMmm, que bueno\n");
                    var date = new DateTime();
                    Console.ReadKey();
                    Console.WriteLine("tal " + date);
                }
            }
        }
    }
}
