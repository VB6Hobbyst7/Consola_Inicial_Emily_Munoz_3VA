﻿using System.Collections.Generic;

namespace Entidades.Paises
{
    class Canton
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Canton> Cantones { get; set; }
    }
}
