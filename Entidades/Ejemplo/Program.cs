using System;
using Entidades;

namespace Vista
{
    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Hola Mundo!");

            var persona = new Profesor("Alanis", "Morison")
            {
                Nombre = "Alanis",
                Apellido = "Morison",
                Especialidad = "Inteligencia Artificial"
            };

            Console.WriteLine(persona.Saludar());

            Asignatura asignatura = new Asignatura
            {
                Nombre = "Programación Visual"
            };

            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Diseño de Interfaces"
            };
        }
    }
}
