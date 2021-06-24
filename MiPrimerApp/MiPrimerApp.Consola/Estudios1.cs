using System;

namespace MiPrimerApp.Consola
{
    class Estudios
    {
        private static object numeroSemestre1;
        private static string semestre1;
        private static string materia1;
        private static string periodo1;
        private static string matricula1;

        static void Main(string[] args)
        {
            Console.WriteLine("\n¿En dónde estudia?\n");
            string lugar = Console.ReadLine();

            Console.WriteLine("\n¿Qué estudias?\n");
            string carrera = Console.ReadLine();

            Console.WriteLine("\n¿Cuántos semestre son?\n");
            while (true)
            {
                string numeroSemestre = Console.ReadLine();
                if (!int.TryParse(numeroSemestre, out int numeroSemestre1))
                {
                    Console.Write("\n Ingrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿En qué semestre?\n");
            while (true)
            {
                string semestre = Console.ReadLine();
                if (!int.TryParse(semestre, out int semestre1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Cuántas materias recibe normalmente en su carrera?\n");
            while (true)
            {
                string materia = Console.ReadLine();
                if (!int.TryParse(materia, out int materia1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Estudias la metria de ingles (si = true)(no = false)?\n");
            string ingles = Console.ReadLine();
            bool ingles1 = Convert.ToBoolean(ingles);
            if (ingles1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\n¿En qué jornada estás?\n");
            string jornada = Console.ReadLine();

            Console.WriteLine("\n¿En qué periodo estás?\n");
            while (true)
            {
                string periodo = Console.ReadLine();
                if (!int.TryParse(periodo, out int periodo1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿En qué numero de matrícula estás?\n");
            while (true)
            {
                string matricula = Console.ReadLine();
                if (!int.TryParse(matricula, out int matricula1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Tiene pagos pendientes (si = true)(no = false)?\n");
            string pagos = Console.ReadLine();
            bool pagos1 = Convert.ToBoolean(pagos);
            if (pagos1 == true)
            {
                Console.WriteLine("\n(True) Si los tengo.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No los tengo.\n");
            }

            var estudio = new Estudios
            {
                lugar = lugar,
                carrera = carrera,
                numeroSemestre = (string)numeroSemestre1,
                semestre = semestre1,
                materia = materia1,
                ingles = Convert.ToString(ingles1),
                jornada = jornada,
                periodo = periodo1,
                matricula = matricula1,
                pagos = Convert.ToString(pagos1)

            };

            Console.WriteLine("\n Su información ha sido registrada de la siguiente manera:\n");
            Console.WriteLine("Lugar: " + estudio.lugar);
            Console.WriteLine("Carrera: " + estudio.carrera);
            Console.WriteLine("Número de Semestres: " + estudio.numeroSemestre);
            Console.WriteLine("Semestre: " + estudio.semestre);
            Console.WriteLine("Materias: " + estudio.materia);
            Console.WriteLine("Ingles: " + estudio.ingles);
            Console.WriteLine("Jornada: " + estudio.jornada);
            Console.WriteLine("Periodo: " + estudio.periodo);
            Console.WriteLine("Matrícula: " + estudio.matricula);
            Console.WriteLine("Pagos pendientes: " + estudio.pagos);
            Console.WriteLine("\nMuchas gracias. \nPresione Enter para continuar.");
            Console.ReadLine();
        }
    }
}