namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.UltimosNiveles
{
    public class UltimosNivelesDto
    {
        public string central { get; set; }
        public decimal? nivel { get; set; }
        public decimal? batt { get; set; }
        public decimal? itemp { get; set; }
        public decimal? distance { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }

    }
}
