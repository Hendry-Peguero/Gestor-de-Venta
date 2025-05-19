namespace Conocetuspresas.Core.Domain.Entities
{
    public class FotosProyecto
    {
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public string Foto { get; set; }

        // Relación con Proyecto
        public Proyecto Proyecto { get; set; }
    }
}
