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

            // ------ PROVINCIA ------
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

            pais.Provincias = new List<Provincia>() {
                provincia1,
                provincia2,
                provincia3,
                provincia4,
                provincia5,
                provincia6
            };

            // ------ CANTONES ------
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

            provincia1.Cantones = new List<Canton>() 
            { 
                canton1 
            };
            provincia2.Cantones = new List<Canton>() 
            {
                canton2
            };
            provincia3.Cantones = new List<Canton>() 
            {
                canton3
            };
            provincia4.Cantones = new List<Canton>() 
            {
                canton4
            };
            provincia5.Cantones = new List<Canton>() 
            {
                canton5
            };
            provincia6.Cantones = new List<Canton>() 
            {
                canton6
            };

            // ------ PARROQUIAS ------
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

            parroquia1.Habitantes = 18580;
            parroquia2.Habitantes = 6672;
            parroquia3.Habitantes = 12281;
            parroquia4.Habitantes = 14687;
            parroquia5.Habitantes = 4988;
            parroquia6.Habitantes = 154035;

            canton1.Parroquias = new List<Parroquia>()
            {
                parroquia1
            };
            canton2.Parroquias = new List<Parroquia>()
            {
                parroquia2
            };
            canton3.Parroquias = new List<Parroquia>()
            {
                parroquia3
            };
            canton4.Parroquias = new List<Parroquia>()
            {
                parroquia4
            };
            canton5.Parroquias = new List<Parroquia>()
            {
                parroquia5
            };
            canton6.Parroquias = new List<Parroquia>()
            {
                parroquia6
            };

            Console.WriteLine($"El resultado de los habitantes que hay en las 6 parroquias son: {pais.ObtenerNumeroDeHabitantes()} habitantes");
        }
    }
}
