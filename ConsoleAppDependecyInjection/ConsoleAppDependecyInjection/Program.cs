using System;

namespace ConsoleAppDependecyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Libreria libreria = new Libreria();

            var libro = new Libro { LibroId = 1, Titulo = "El varón domado", Autor = "Esther Vilar" };
            libreria.Libros.Add(libro);

            libreria.Impresora = new ImpresoraTxt(); //inyectando por propiedad
            Console.WriteLine(libreria.Imprimir(libro.LibroId));

            libreria.Impresora = new ImpresoraXml(); //inyectando por propiedad
            Console.WriteLine(libreria.Imprimir(libro.LibroId)); 
        }
    }
}
