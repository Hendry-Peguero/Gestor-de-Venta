namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.GeneracionUltimas24HorasDto
{
    public class GeneracionUltimas24HorasDto
    {
        public int IDCentral { get; set; }
        public string Central { get; set; }
        public string Parametro { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public decimal Generador1 { get; set; }
        public decimal Generador2 { get; set; }
        public string UnidadMedida { get; set; }
    }
}