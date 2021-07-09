using System.IO;
using System.Text;

namespace ConsoleAppDependecyInjection
{
    class ImpresoraXml : Impresora
    {
        public override string Imprimir(Libro libro, string ruta)
        {
            var archivo = $"{ruta}\\{libro.Titulo.Replace(" ", string.Empty)}.xml";
            FileStream fileStream = File.Create(archivo);
            var contenido = $"<?xml version=\"1.0\" enconding=\"utf-8\" xml>\n<id>{libro.LibroId}</id>\n<título>{libro.Titulo}<título>\n<autor>{libro.Autor}</autor>\n ";
            byte[] buffer = Encoding.UTF8.GetBytes(contenido);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();
            return archivo;
        }
    }
}
