using System;
using System.IO;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string cabecera= "<?xml version=\" 1.0\" encoding=\" UTF - 8\" standalone= \" yes\"?>
            FileStream file = File.Create("c:\\CaballerosDelZodiaco.xml"); 
        } 
    }

    interface IToXml
    {
        string ToXml();
    }

    public class Heroe : IToXml

    {
        public string Name { get; set; }
        public int Poder { get; set; }
        public Caracter Caracter { get; set; }
        public Fase Fase { get; set; }
        public Heroe Amigo { get; set; }
        public Villano Enemigo { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public string ToXml() 
        {
            return $"<heroe><name>{Name}</name><poder>{Poder}</poder><caracter>{Caracter}</caracter>" +
                $"{Enemigo.ToXml()}</heroe>";
        }
    }

    public class Ubicacion : IToXml
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int PosicionZ { get; set; }
        public DateTime PosicionTiempo { get; set; }

        public string ToXml()
        {
            return $"<ubicacion><posicionx>{PosicionX}</posicionx></ubicacion>";
        }
    }

    public enum Caracter
    {
        Jovial,
        Enojado,
        Violento,
        Tranquilo
    }

    public class Villano : IToXml
    {
        public string Name { get; set; }
        public int Poder { get; set; }

        internal string ToXml()
        {
            throw new NotImplementedException();
        }

        string IToXml.ToXml()
        {
            return $"<villano><name>{Name}</name><poder>{Poder}</poder></villano>";
        }
    }

    public class Fase
    {
        public string Name { get; set; }
    }


    //Heroe heroe = new Heroe();
    //heroe.Name = "";
    //heroe.Poder = "";

    //Villano villano = new Villano();
    //villano.Name = "";
    //villano.Poder = "";
}
