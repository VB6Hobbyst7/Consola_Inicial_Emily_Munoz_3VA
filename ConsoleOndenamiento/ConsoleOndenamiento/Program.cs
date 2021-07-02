using System;

namespace ConsoleOrdenamiento
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int cantidadElementos = 6;
            var edificio = new int[cantidadElementos];
            edificio[0] = 42987;
            edificio[1] = 324;
            edificio[2] = 654;
            edificio[3] = 8;
            edificio[4] = 45;
            edificio[5] = -23;

            Console.WriteLine(edificio[0]);

            var administrador = new Administrador();
            int[] ordenado = administrador.Ordenar(edificio);

            Console.WriteLine("Hecho con FOR");
            for (int i = 0; i < edificio.Length; i++)
                Console.WriteLine(edificio[i]);

            Console.WriteLine("\nHecho con FOREACH");
            foreach (var actual in edificio)
                Console.WriteLine(actual);
        }
    }
}
