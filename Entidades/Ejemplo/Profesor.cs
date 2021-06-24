namespace Entidades
{
    public class Profesor : Persona
    {
        public Profesor(string nombre, string apellido): base(nombre, apellido)
        {
        }

        public int ProfesorId { get; set; }
        public string Especialidad { get; set; }
    }
}
