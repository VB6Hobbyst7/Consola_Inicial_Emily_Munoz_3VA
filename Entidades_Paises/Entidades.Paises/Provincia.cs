using System.Collections.Generic;

namespace Entidades.Paises
{
    class Provincia
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Provincia> Provincias { get; set; }
    }
}
