using System;
using System.Collections.Generic;

namespace MiProyecto
{
    partial class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Persona persona = new()
            {
                PersonaId = 1,
                Nombre = "Nombre"
            };

            persona.Modistas = new List<Persona>();

            var nombre1 = new Persona
            { Nombre = "Marina" };
            var apellido1 = new Persona
            { Apellido = "Asipuela" };
            var cedula1 = new Persona
            { Cedula = "1713289914" };
            var edad1 = new Persona
            { Edad = "46" };

            persona.Modistas.Add(nombre1);
            persona.Modistas.Add(apellido1);
            persona.Modistas.Add(cedula1);
            persona.Modistas.Add(edad1);
        }
    }
}