using System;

namespace MiPrimerApp.Consola
{
    class Modista
    {
        public string maquina;
        public string citaAgendadas;
        public string citaDomicilio;
        public string confeccion;
        public string altaCostura;
        public string direccion;
        public string operarios;
        public string marca;
        public string tiempoTrabajo;
        public string bordados;

        private static string maquina1;
        private static object confeccion1;
        private static string tiempoTrabajo1;

        static void SaludoInicial(String[] args)
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
