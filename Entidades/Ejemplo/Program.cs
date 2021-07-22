using System;
using Entidades;

namespace Vista
{
    class Program
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Hola Mundo!");

            Profesor persona = new Profesor
            {
                Nombre = "Alanis",
                Apellido = "Morison",
                Especialidad = "Inteligencia Artificial"
            };

            Console.WriteLine(persona.Saludar());

            Asignatura asignaturas = new Asignatura
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
