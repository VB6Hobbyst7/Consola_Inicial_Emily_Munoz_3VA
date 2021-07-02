using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppDependecyInjection
{
    class Libreria
    {
        public string Ruta { get; set; } = "";
        public Collection<Libro> Libros { get; set; } = new Collection<Libro>();

        internal string Imprimir (int libroId)
        {
            if (Libros.Any(actual => actual.LibroId == libroId ))
            {
                var libro = Libros.Single(actual => actual.LibroId == libroId);
                var archivo = $"{Ruta}\\{libro.Titulo.Replace(" ", string.Empty)}.txt";
                FileStream fileStream = File.Create(archivo);
                var contenido = $"Id: {libro.LibroId}\n Título: {libro.Titulo}\n Autor: {libro.Autor}\n ";
                byte[] buffer = Encoding.UTF8.GetBytes(contenido);
                fileStream.Write(buffer);
                fileStream.Flush();
                fileStream.Close();
                return archivo;
            }
            return "No existe el libro.";
        }
    }
}
