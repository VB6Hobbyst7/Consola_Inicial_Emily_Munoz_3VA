using System.Collections.Generic;

namespace Entidades.Paises
{
    class Habitante
    {
        public int Id { get; set; }

        public string Poblacion { get; set; }

        public List<Habitante> Habitantes { get; set; }
        
        

        public int ObtenerNumeroHabitantes()
        {
            int acumulador = 0;
            foreach (Habitante actual in Habitantes)
            {
                acumulador += actual.ObtenerNumeroHabitantes();
            }
            return acumulador;
        }
    }
}
