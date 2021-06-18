using System;

namespace MiPrimerApp.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            SaludoInicial(args);
        }

        static void SaludoInicial(String[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("¿Cuál es su nombre?");
            var nombre = Console.ReadLine();

            Console.WriteLine("¿Cuál es su apellido?");
            var apellido = Console.ReadLine();

            Console.WriteLine("¿Cuál es su edad?");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);

            Console.WriteLine("¿Cuál es su color favorito?");
            var color = Console.ReadLine();

            Console.WriteLine("¿Cuál es su animal favorito?");
            var animal = Console.ReadLine();

            Console.WriteLine("¿Estudias o Trabajas?");
            var ocupacion = Console.ReadLine();

            Console.WriteLine("¿Cuál es libro favorito?");
            var libro = Console.ReadLine();

            Console.WriteLine("¿Cuál es su musica favorita?");
            var musica = Console.ReadLine();

            Console.WriteLine("¿Cuál es su altura?");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es su peso?");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Muchas gracias, /n Su informacion ha sido registrada");

            if (args.Length > 0)
                Console.WriteLine("Hola " + args[0]);
            else
            {
                Console.WriteLine("Hola Desconocido ");
            }
            Console.WriteLine("¿Como estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("Mmm, entiendo");
            var date = new DateTime();
            Console.ReadKey();
            Console.WriteLine("tal " + estado);

        }
    }
}
