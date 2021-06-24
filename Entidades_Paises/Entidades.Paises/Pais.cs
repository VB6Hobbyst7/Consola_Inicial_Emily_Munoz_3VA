﻿using System;
using System.Collections.Generic;

namespace Entidades.Paises
{
    class Pais
    {
        public int PaisId { get; set; }

        public string Nombre { get; set; }

        public List<Provincia> Provincias { get; set; }

        public List<Canton> Cantones { get; set; }

        public List<Parroquia> Parroquias { get; set; }

        public List<Habitante> Habitantes { get; set; }

        public int[] Enteros { get; set; }

        internal bool ObtenerNumeroHabitantes()
        {
            throw new NotImplementedException();
        }
    }
}