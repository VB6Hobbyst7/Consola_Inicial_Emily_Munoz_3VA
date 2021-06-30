using System.Collections.Generic;

namespace MiProyecto
{
    class CitaProgramada
    {
        public int CitaProgramadaId { get; set; }
        public List<CitaAgendada> CitaAgendadas { get; set; }
        public List<CitaDomicilio> CitaDomicilio { get; set; }
    }
}