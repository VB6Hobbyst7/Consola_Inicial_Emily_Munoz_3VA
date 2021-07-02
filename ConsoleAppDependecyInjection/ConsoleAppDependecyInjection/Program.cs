using System;

namespace ConsoleAppDependecyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var impresora = new Impresora();

            Libreria libreria = new Libreria(); //inyectando por propiedad
            libreria.Impresora = impresora; //inyectando por constructor

            var libro = new Libro { LibroId = 1, Titulo = "El varón domado", Autor = "Esther Vilar" };

            libreria.Libros.Add(libro);

            libreria.Imprimir(libro.LibroId);

            Console.WriteLine(libreria.Imprimir(libro.LibroId));
        }
    }
}
