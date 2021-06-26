using System;
using System.Collections.Generic;

namespace Entidades.Paises
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais pais = new()
            {
                PaisId = 1,
                Nombre = "Ecuador"
            };

            pais.Provincias = new List<Provincia>();

            var provincia1 = new Provincia
            { Nombre = "Pichincha" };
            var provincia2 = new Provincia
            { Nombre = "Galápagos" };
            var provincia3 = new Provincia
            { Nombre = "Loja" };
            var provincia4 = new Provincia
            { Nombre = "Carchi" };
            var provincia5 = new Provincia
            { Nombre = "Zamora Chinchipe" };
            var provincia6 = new Provincia
            { Nombre = "Esmeraldas" };

            pais.Provincias.Add(provincia1);
            pais.Provincias.Add(provincia2);
            pais.Provincias.Add(provincia3);
            pais.Provincias.Add(provincia4);
            pais.Provincias.Add(provincia5);
            pais.Provincias.Add(provincia6);

            pais.Cantones = new List<Canton>();

            var canton1 = new Canton
            { Nombre = "Quito" };
            var canton2 = new Canton
            { Nombre = "San Cristobal" };
            var canton3 = new Canton
            { Nombre = "Loja" };
            var canton4 = new Canton
            { Nombre = "Monfutar" };
            var canton5 = new Canton
            { Nombre = "El Pangui" };
            var canton6 = new Canton
            { Nombre = "Esmeraldas" };

            pais.Cantones.Add(canton1);
            pais.Cantones.Add(canton2);
            pais.Cantones.Add(canton3);
            pais.Cantones.Add(canton4);
            pais.Cantones.Add(canton5);
            pais.Cantones.Add(canton6);

            pais.Parroquias = new List<Parroquia>();

            var parroquia1 = new Parroquia
            { Nombre = "Pifo" };
            var parroquia2 = new Parroquia
            { Nombre = "Puerto Baquerizo Moreno" };
            var parroquia3 = new Parroquia
            { Nombre = "San Sebastian" };
            var parroquia4 = new Parroquia
            { Nombre = "San Gabriel" };
            var parroquia5 = new Parroquia
            { Nombre = "El Pangui" };
            var parroquia6 = new Parroquia
            { Nombre = "5 de Agosto" };

            pais.Parroquias.Add(parroquia1);
            pais.Parroquias.Add(parroquia2);
            pais.Parroquias.Add(parroquia3);
            pais.Parroquias.Add(parroquia4);
            pais.Parroquias.Add(parroquia5);
            pais.Parroquias.Add(parroquia6);

            pais.Habitantes = new List<Habitante>();

            var habitante1 = new Habitante
            { NumeroHabitantes = "16645" };
            var habitante2 = new Habitante
            { NumeroHabitantes = "6675" };
            var habitante3 = new Habitante
            { NumeroHabitantes = "17028" };
            var habitante4 = new Habitante
            { NumeroHabitantes = "7586" };
            var habitante5 = new Habitante
            { NumeroHabitantes = "4988" };
            var habitante6 = new Habitante
            { NumeroHabitantes = "15403" };

            pais.Habitantes.Add(habitante1);
            pais.Habitantes.Add(habitante2);
            pais.Habitantes.Add(habitante3);
            pais.Habitantes.Add(habitante4);
            pais.Habitantes.Add(habitante5);
            pais.Habitantes.Add(habitante6);

            Console.WriteLine($" El resultado de los habitantes es de: {pais.ObtenerNumeroDeHabitantes()} habitantes");
        }
    }
}

