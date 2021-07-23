using System;

namespace MiPrimerApp.Consola
{
    class Empleado
    {
        public string cargo;
        public string numeroPersonasCargo;
        public string horario;
        public string tiempoLabor;
        public string capacitaciones;
        public string sueldo;
        public string cargasFamiliares;
        public string vacaciones;
        public string preparacionAcademica;
        public string titulo;

        private static string numeroPersonasCargo1;
        private static string cargasFamiliares1;
        private static string tiempoLabor1;
        private static string sueldo1;

        static void SaludoInicial(String[] args)
        {
            Console.WriteLine("\n¿En qué cargo estás?\n");
            string cargo = Console.ReadLine();

            Console.WriteLine("\n¿Cuántas personas estan a tu cargo?\n");
            while (true)
            {
                string numeroPersonasCargo = Console.ReadLine();
                if (!int.TryParse(numeroPersonasCargo, out int numeroPersonasCargo1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿En qué horario estás?\n");
            string horario = Console.ReadLine();

            Console.WriteLine("\n¿Cuántas horas de labor al día tiene?\n");
            while (true)
            {
                string tiempoLabor = Console.ReadLine();
                if (!int.TryParse(tiempoLabor, out int tiempoLabor1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Tiene capacitaciones (si = true)(no = false)?\n");
            string capacitaciones = Console.ReadLine();
            bool capacitaciones1 = Convert.ToBoolean(capacitaciones);
            if (capacitaciones1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\nSueldo aproximado: \n");
            while (true)
            {
                string sueldo = Console.ReadLine();
                if (!int.TryParse(sueldo, out int sueldo1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Cuántas personas estan a tu cargo?\n");
            while (true)
            {
                string cargasFamiliares = Console.ReadLine();
                if (!int.TryParse(cargasFamiliares, out int cargasFamiliares1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Tiene vacaciones (si = true)(no = false)?\n");
            string vacaciones = Console.ReadLine();
            bool vacaciones1 = Convert.ToBoolean(vacaciones);
            if (vacaciones1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\nNivel Académico\n");
            string preparacionAcademica = Console.ReadLine();

            Console.WriteLine("\n¿Estudias (si = true)(no = false)?\n");
            string titulo = Console.ReadLine();
            bool titulo1 = Convert.ToBoolean(titulo);
            if (titulo1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            var empleado = new Empleado
            {
                cargo = cargo,
                numeroPersonasCargo = numeroPersonasCargo1,
                horario = horario,
                tiempoLabor = tiempoLabor1,
                capacitaciones = Convert.ToString(capacitaciones1),
                sueldo = sueldo1,
                cargasFamiliares = cargasFamiliares1,
                vacaciones = Convert.ToString(vacaciones1),
                preparacionAcademica = preparacionAcademica,
                titulo = Convert.ToString(titulo1)
            };

            Console.WriteLine("\n Su información ha sido registrada de la siguiente manera:\n");
            Console.WriteLine("Cargo dentro de la Empresa: " + empleado.cargo);
            Console.WriteLine("Número de personas a cargo: " + empleado.numeroPersonasCargo);
            Console.WriteLine("Horario: " + empleado.horario + "horas al día");
            Console.WriteLine("Tiempo de Labor: " + empleado.tiempoLabor);
            Console.WriteLine("Capacitaciones: " + empleado.capacitaciones);
            Console.WriteLine("Sueldo: " + empleado.sueldo);
            Console.WriteLine("Cargas Familiares: " + empleado.cargasFamiliares);
            Console.WriteLine("Vacaciones: " + empleado.vacaciones);
            Console.WriteLine("Preparación Academica: " + empleado.preparacionAcademica);
            Console.WriteLine("Título Universitario: " + empleado.titulo);
            Console.WriteLine("\nMuchas gracias. \nPresione Enter para continuar.");
            Console.ReadLine();
        }
    }
}
