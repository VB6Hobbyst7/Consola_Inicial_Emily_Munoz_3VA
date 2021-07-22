using System;
using System.IO;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string cabecera = "<?xml version=\" 1.0\" encoding=\" UTF - 8\" standalone= \" yes\"?>";
            FileStream file;
            try
            {
                file = File.Create("c:\\Users\\user\\Desktop\\Programación_Visual\\Interfaces\\Caballeros Del Zodiaco\\CaballerosDelZodiaco.xml");
                Console.WriteLine("El programa se ha creado.");
            }
            catch (UnauthorizedAccessException e)
            {
                System.Diagnostics.Trace.TraceError(e.Message);
                Console.WriteLine("El programa no puede escribir en la ruta.");
                //#if debug
                Console.WriteLine(e);
                //#endif
                return;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.TraceError(e.Message);
                Console.WriteLine("Se produjo un problema.");
                return;
            }

            //file.Write(Byte[]);

            Heroe heroe = new Heroe();
            heroe.Name = "Saint Seiya de Pegaso";
            heroe.Poder = 100000;
            Villano villano = new Villano();
            villano.Name = "Shaina de Ofiuco";
            villano.Poder = 100000;
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
        public Villano Enemigo { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public string ToXml()
        {
            return $"<heroe><name>{Name}</name><poder>{Poder}</poder><caracter>{Caracter}</caracter><fase>{Fase}</fase>" +
                $"<enemigo>{Enemigo.ToXml()}</enemigo></heroe>";
        }
    }

    public class Fase : IToXml
    {
        public string Name { get; set; }
        public string ToXml()
        {
            return $"<fase><name>{Name}</name></fase>";
        }
    }

    public class Caracter : IToXml
    {
        public string Name { get; set; }
        public string ToXml()
        {
            return $"<caracter><name>{Name}</name></caracter>";
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

    public class Villano : IToXml
    {
        public string Name { get; set; }
        public int Poder { get; set; }

        public string ToXml()
        {
            return $"<villano><name>{Name}</name><poder>{Poder}</poder></villano>";
        }
    }
}
