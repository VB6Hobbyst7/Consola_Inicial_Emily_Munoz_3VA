using Abstraccion;
using System.IO;
using System.Text;

namespace ConsoleAppDependecyInjection
{
    class ImpresoraTxt : Impresora 
    {
        public override string Imprimir(Libro libro, string ruta)
        {
            var archivo = $"{ruta}\\{libro.Titulo.Replace(" ", string.Empty)}.txt";
            FileStream fileStream = File.Create(archivo);
            var contenido = $"Id: {libro.LibroId}\nTítulo: {libro.Titulo}\nAutor: {libro.Autor}\n ";
            byte[] buffer = Encoding.UTF8.GetBytes(contenido);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();
            return archivo;
        }
    }
}
