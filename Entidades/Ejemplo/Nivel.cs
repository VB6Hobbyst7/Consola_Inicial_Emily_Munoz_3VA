using System.Collections.Generic;

namespace Entidades
{
    public class Nivel
    {
        public int NivelId { get; set; }
        public string Nombre { get; set; }

        public List<Asignatura> Asignatura { get; set; }
    }

}   
