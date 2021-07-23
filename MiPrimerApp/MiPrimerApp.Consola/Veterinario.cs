using System;

namespace MiPrimerApp.Consola
{
    class Veterinario
    {
        public string numeroAnimales;
        public string esterilizacion;
        public string vacunas;
        public string citaControl;
        public string emergencias;
        public string cirugias;
        public string tratamientos;
        public string jornadaGratuitas;
        public string peluqueria;
        public string publicidad;

        private static string numeroAnimales1;
        private static string emergencias1;
        private static string cirugias1;
        private static string jornadaGratuitas1;

        static void SaludoInicial(String[] args)
        {
            Console.WriteLine("\n¿Cuántos animales ha atendido en este mes?\n");
            while (true)
            {
                string numeroAnimales = Console.ReadLine();
                if (!int.TryParse(numeroAnimales, out int numeroAnimales1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Es recomendable hacer esterilizar a mi mascota?\n");
            string esterilizacion = Console.ReadLine();

            Console.WriteLine("\n¿Cómo puedo asegurar que mi mascota este al día con sus vacunas?\n");
            string vacunas = Console.ReadLine();

            Console.WriteLine("\n¿Cómo puedo obtener un cita para el control de salud de mi mascota?\n");
            string citaControl = Console.ReadLine();

            Console.WriteLine("\n¿Cuántas emergencias ha tedido en este mes?\n");
            while (true)
            {
                string emergencias = Console.ReadLine();
                if (!int.TryParse(emergencias, out int emergencias1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Cómo son los tratamientos que debe tener una mascota después de una cirugía?\n");
            string tratamientos = Console.ReadLine();

            Console.WriteLine("\n¿Cuántos Campañas o jornadas gratuitas ofrece al año?\n");
            while (true)
            {
                string jornadaGratuitas = Console.ReadLine();
                if (!int.TryParse(jornadaGratuitas, out int jornadaGratuitas1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Ofrece servicios de peluqueria su veterinaria (si = true)(no = false)?\n");
            string peluqueria = Console.ReadLine();
            bool peluqueria1 = Convert.ToBoolean(peluqueria);
            if (peluqueria1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\n¿Tiene publicidad de su veterinaria (si = true)(no = false)?\n");
            string publicidad = Console.ReadLine();
            bool publicidad1 = Convert.ToBoolean(publicidad);
            if (publicidad1 == true)
            {
                Console.WriteLine("\n(True) Si.\n");
            }
            else
            {
                Console.WriteLine("\n(False).\n");
            }

            var veterinario = new Veterinario
            {
                numeroAnimales = numeroAnimales1,
                esterilizacion = esterilizacion,
                vacunas = vacunas,
                citaControl = citaControl,
                emergencias = emergencias1,
                cirugias = cirugias1,
                tratamientos = tratamientos,
                jornadaGratuitas = jornadaGratuitas1,
                peluqueria = Convert.ToString(peluqueria1),
                publicidad = Convert.ToString(publicidad1)
            };

            Console.WriteLine("\n Su información ha sido registrada de la siguiente manera:\n");
            Console.WriteLine("Cargo dentro de la Empresa: " + veterinario.numeroAnimales);
            Console.WriteLine("Número de personas a cargo: " + veterinario.esterilizacion);
            Console.WriteLine("Horario: " + veterinario.vacunas + "horas al día");
            Console.WriteLine("Tiempo de Labor: " + veterinario.citaControl);
            Console.WriteLine("Capacitaciones: " + veterinario.emergencias);
            Console.WriteLine("Sueldo: " + veterinario.cirugias);
            Console.WriteLine("Cargas Familiares: " + veterinario.tratamientos);
            Console.WriteLine("Vacaciones: " + veterinario.jornadaGratuitas);
            Console.WriteLine("Preparación Academica: " + veterinario.peluqueria);
            Console.WriteLine("Título Universitario: " + veterinario.publicidad);
            Console.WriteLine("\nMuchas gracias. \nPresione Enter para continuar.");
            Console.ReadLine();
        }
    }
}
