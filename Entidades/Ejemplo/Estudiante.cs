using System.Collections.Generic;

namespace Entidades
{
    public class Estudiante : Persona
    { 
        public Estudiante(): base("Jorge", "Lopez")
        {
        }

        public Estudiante(string nombre) : base(nombre, "Lopez")
        {
        }

        public int EstudianteId { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
