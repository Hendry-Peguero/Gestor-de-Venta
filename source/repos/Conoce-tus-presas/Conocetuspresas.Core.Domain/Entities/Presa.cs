namespace Conocetuspresas.Core.Domain.Entities
{
    public class Presa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Coordenada { get; set; }
        public string DescripcionLarga { get; set; }
        public string DescripcionCorta { get; set; }
        public string Destinada { get; set; }
        public int Año { get; set; }
        public decimal Generacion { get; set; }
        public decimal Capacidad { get; set; }
        public string FotoPortada { get; set; }
        public string Video { get; set; }

        // Relación 1:N con FotosPresa
        public ICollection<FotosPresa> Fotos { get; set; }
    }
}
