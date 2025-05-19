namespace Conocetuspresas.Core.Domain.Entities
{
    public class FotosPresa
    {
        public int Id { get; set; }
        public int PresaId { get; set; }
        public string Foto { get; set; }

        // Relación con Presa
        public Presa Presa { get; set; }
    }
}
