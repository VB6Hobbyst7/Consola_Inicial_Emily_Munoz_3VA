using System.Collections.Generic;

namespace Entidades.Paises
{
    class Parroquia
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Parroquia> Parroquias { get; set; }
    }
}
