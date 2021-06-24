using System.Collections.Generic;

namespace Entidades.Paises
{
    class Canton
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Parroquia> Parroquias { get; set; }

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Parroquia actual in Parroquias)
            {
                acumulador += actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}
