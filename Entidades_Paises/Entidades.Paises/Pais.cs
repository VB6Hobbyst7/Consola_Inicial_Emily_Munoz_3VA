using System.Collections.Generic;

namespace Entidades.Paises
{
    class Pais
    {
        public int PaisId { get; set; }

        public string Nombre { get; set; }

        public List<string> Provincia { get; set; }

        public List<Provincia> Provincias { get; set; }

        public List<string> Canton { get; set; }

        public List<Canton> Cantones { get; set; }

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Provincia actual in Provincias)
            {
                acumulador += actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}
