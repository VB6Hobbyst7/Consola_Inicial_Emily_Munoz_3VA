using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleAppDependecyInjection
{
    internal class Libreria
    {
        public Libreria()
        {
        }

        public Libreria(Impresora impresora)
        {
            Impresora = impresora;
        }
        
        public string Ruta { get; set; } = "C:\\Users\\user\\Desktop\\Programación_Visual\\ConsoleAppDependecyInjection\\Libro";
        public Collection<Libro> Libros { get; set; } = new Collection<Libro>();
        public Impresora Impresora { get; set; }
        internal string Imprimir(int libroId)
        {
            var libro = Libros.SingleOrDefault(actual => actual.LibroId == libroId);
            if (libro != null)
                return Impresora.Imprimir(libro, Ruta);
            return "No existe el libro.";
        }
    }
}
