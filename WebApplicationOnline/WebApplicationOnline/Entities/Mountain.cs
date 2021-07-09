using System.ComponentModel;

namespace WebApplicationOnline.Entities
{
    public class Mountain
    {
        public int MountainId { get; set; }

        [DisplayName("Nombre de la Montaña: ")]
        public string Nombre { get; set; }

        [DisplayName("Altitud en metros de la montaña: ")]
        public int Altitud { get; set; }

        [DisplayName("Provincia en la que se encuentra la montaña: ")]
        public string Provincia { get; set; }

        [DisplayName("Que tipo de montaña es (Estratovolcán / caldera): ")]
        public string Clasificacion { get; set; }

        [DisplayName("Cordillera de la montaña (Occidental / Oriental): ")]
        public string Cordillera { get; set; }
    }
}
