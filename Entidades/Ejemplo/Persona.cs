namespace Entidades
{
    public abstract class Persona
    {
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get {return $"{Nombre} {Apellido}"; } }
        
        public string Saludar () 
        {
            return $"Hola me llamo {Nombre}, espero te encuentres bien";
        }

        public static string Saludar(string nombreAmigo) 
        {
            return $"Que más ve {nombreAmigo}, que te cuentas";
        }
    }
}
