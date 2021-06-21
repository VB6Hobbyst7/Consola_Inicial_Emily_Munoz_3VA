using System;

namespace MiPrimerApp.Consola
{
    class Persona
    {
        public static string libro1;
        public static string estatura1;
        public static string pesokg1;
        public static bool genero1;
        public static string edad1;

        static void SaludoInicial(String[] args)
        {
            void metodo(String[] args)
            {
                if (args.Length > 0)
                    Console.WriteLine("Hola {0} {1} {2} {3} {4} {5}" + args[0], args[1], args[2], args[3], args[4], args[5]);
                else
                {
                    Console.WriteLine("Hola Desconocido ");
                }

                Console.WriteLine("\n¿Cómo estás?\n");
                var estado = Console.ReadLine();
                Console.WriteLine("\nMmm, que bueno\n");
                var date = new DateTime();
                Console.ReadKey();
                Console.WriteLine("tal " + date);
            }
        }

        static void Main(string[] args)
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

    class Empleado
    {
        private static string numeroPersonasCargo1;
        private static string cargasFamiliares1;
        private static string tiempoLabor1;
        private static string sueldo1;

        static void Main(string[] args)
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

    class Nuevo
    {
        static void Main(string[] args)
        {



            var veterinario = new Nuevo
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

    class Nuevo
    {
        static void Main(string[] args)
        {



            var veterinario = new Nuevo
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
