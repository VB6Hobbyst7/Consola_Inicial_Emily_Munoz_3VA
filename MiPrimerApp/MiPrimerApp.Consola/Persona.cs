using System;

namespace MiPrimerApp.Consola
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public string edad;
        public string genero;
        public string colorFavorito;
        public string estudias;
        public string libro;
        public string musicaFavorita;
        public string estatura;
        public string peso;


        private static string libro1;
        private static string estatura1;
        private static string pesokg1;
        private static string edad1;

        static void SaludoInicial(String[] args)
        {
            SaludoInicial(args);
            Console.WriteLine("\nBienvenido");
            Console.WriteLine("\n¿Cuál es su nombre?\n");
            string nombre = Console.ReadLine();

            Console.WriteLine("\n¿Cuál es su apellido?\n");
            string apellido = Console.ReadLine();

            Console.WriteLine("\nEdad: \n");
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out int edad1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\nIndique su su género (masculino = true)(femenino = false).\n");
            string genero = Console.ReadLine();
            bool genero1 = Convert.ToBoolean(genero);
            if (genero1 == true)
            {
                Console.WriteLine("\n(True) Masculino\n");
            }
            else
            {
                Console.WriteLine("\n(False) Femenino\n");
            }

            Console.WriteLine("\n¿Cuál es su color favorito?\n");
            string color = Console.ReadLine();

            Console.WriteLine("\n¿Estudias (si = true)(no = false)?\n");
            string ocupacion = Console.ReadLine();
            bool ocupacion1 = Convert.ToBoolean(ocupacion);
            if (ocupacion1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }


            Console.WriteLine("\n¿Cuántos libros a leído en este mes?\n");
            while (true)
            {
                string libro = Console.ReadLine();
                if (!int.TryParse(libro, out int libro1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\nIndique su género musical favorito.\n");
            string musica = Console.ReadLine();

            Console.WriteLine("\n¿Cuál es su estatura (cm)?\n");
            while (true)
            {
                string estatura = Console.ReadLine();
                if (!int.TryParse(estatura, out int estatura1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Cuál es su peso (kg)?\n");
            while (true)
            {
                string pesokg = Console.ReadLine();
                if (!int.TryParse(pesokg, out int pesokg1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            var persona = new Persona
            {
                nombre = nombre,
                apellido = apellido,
                edad = edad1,
                genero = Convert.ToString(genero1),
                colorFavorito = color,
                estudias = Convert.ToString(ocupacion1),
                libro = libro1,
                musicaFavorita = musica,
                estatura = estatura1,
                peso = pesokg1
            };

            Console.WriteLine("\n Su información ha sido registrada de la siguiente manera:\n");
            Console.WriteLine("Nombre: " + persona.nombre);
            Console.WriteLine("Apellido: " + persona.apellido);
            Console.WriteLine("Edad: " + persona.edad);
            Console.WriteLine("Género: " + persona.genero);
            Console.WriteLine("Color Favorito: " + persona.colorFavorito);
            Console.WriteLine("Estudias: " + persona.estudias);
            Console.WriteLine("Libros leídos: " + persona.libro);
            Console.WriteLine("Música favorita: " + persona.musicaFavorita);
            Console.WriteLine("Estatura: " + persona.estatura + " cm.");
            Console.WriteLine("Peso: " + persona.peso + " kg.");
            Console.WriteLine("\nMuchas gracias. \nPresione Enter para continuar.");
            Console.ReadLine();
        }
    }
}
