using System.Collections.Generic;

namespace MiProyecto
{
    class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Edad { get; set; }
        public List<Persona> Modistas { get; set; }
    }
}
