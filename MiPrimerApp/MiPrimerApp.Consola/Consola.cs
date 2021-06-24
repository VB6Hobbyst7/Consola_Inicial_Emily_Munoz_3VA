using System;

namespace MiPrimerApp.Consola
{
    class Persona
    {
        private static string libro1;
        private static string estatura1;
        private static string pesokg1;
        private static bool genero1;
        private static string edad1;

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

    class Veterinario
    {
        private static string numeroAnimales1;
        private static string emergencias1;
        private static string cirugias1;
        private static string jornadaGratuitas1;

        static void Main(string[] args)
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

    class Modista
    {
        private static string maquina1;
        private static object confeccion1;
        private static string tiempoTrabajo1;

        static void Main(string[] args)
        {
            Console.WriteLine("\n¿Cuantas máquinas de coser tiene en su taller?\n");
            while (true)
            {
                string maquina = Console.ReadLine();
                if (!int.TryParse(maquina, out int maquina1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Tiene citas agendadas (si = true)(no = false)?\n");
            string citaAgendadas = Console.ReadLine();
            bool citaAgendadas1 = Convert.ToBoolean(citaAgendadas);
            if (citaAgendadas1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\n¿Hace visitas a domicilio (si = true)(no = false)?\n");
            string citaDomicilio = Console.ReadLine();
            bool citaDomicilio1 = Convert.ToBoolean(citaDomicilio);
            if (citaDomicilio1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\n¿Cuántas prendas de vestir puede confeccionar en un día?\n");
            while (true)
            {
                string confeccion = Console.ReadLine();
                if (!int.TryParse(confeccion, out int confeccion1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Realiza alta costura (si = true)(no = false)?\n");
            string altaCostura = Console.ReadLine();
            bool altaCostura1 = Convert.ToBoolean(altaCostura);
            if (altaCostura1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\n¿Cuál es su dirección?\n");
            string direccion = Console.ReadLine();

            Console.WriteLine("\n¿Tiene operarios (si = true)(no = false)?\n");
            string operarios = Console.ReadLine();
            bool operarios1 = Convert.ToBoolean(operarios);
            if (operarios1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }
            
            Console.WriteLine("\n¿Tiene marca registrada (si = true)(no = false)?\n");
            string marca = Console.ReadLine();
            bool marca1 = Convert.ToBoolean(marca);
            if (marca1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            Console.WriteLine("\n¿Cuánto tiempo esta trabanjo (años)?\n");
            while (true)
            {
                string tiempoTrabajo = Console.ReadLine();
                if (!int.TryParse(tiempoTrabajo, out int tiempoTrabajo1))
                {
                    Console.Write("\nIngrese un valor númerico.\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n¿Ofrece bordados (si = true)(no = false)?\n");
            string bordados = Console.ReadLine();
            bool bordados1 = Convert.ToBoolean(bordados);
            if (bordados1 == true)
            {
                Console.WriteLine("\n(True) Si estudio.\n");
            }
            else
            {
                Console.WriteLine("\n(False) No estudio.\n");
            }

            var modista = new Modista
            {
                maquina = maquina1,
                citaAgendadas = Convert.ToString(citaAgendadas1),
                citaDomicilio = Convert.ToString(citaDomicilio1),
                confeccion = (string)confeccion1,
                altaCostura = Convert.ToString(altaCostura1),
                direccion = direccion,
                operarios = Convert.ToString(operarios),
                marca = Convert.ToString(marca1),
                tiempoTrabajo = tiempoTrabajo1,
                bordados = Convert.ToString(bordados1)
            };

            Console.WriteLine("\n Su información ha sido registrada de la siguiente manera:\n");
            Console.WriteLine("Máquinas de coser a su dispoción: " + modista.maquina);
            Console.WriteLine("Citas agendadas: " + modista.citaAgendadas);
            Console.WriteLine("Trabajo a domicilio: " + modista.citaDomicilio);
            Console.WriteLine("Confeccion de prendas en un día: " + modista.confeccion);
            Console.WriteLine("Trabajo de alta costura: " + modista.altaCostura);
            Console.WriteLine("Dirección: " + modista.direccion);
            Console.WriteLine("Operarios: " + modista.operarios);
            Console.WriteLine("Marca: " + modista.marca);
            Console.WriteLine("Tiempo trabajando en confección: " + modista.tiempoTrabajo + "años.");
            Console.WriteLine("Bordados: " + modista.bordados);
            Console.WriteLine("\nMuchas gracias. \nPresione Enter para continuar.");
            Console.ReadLine();
        }
    }
}