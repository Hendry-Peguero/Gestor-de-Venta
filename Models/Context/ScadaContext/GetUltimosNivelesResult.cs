using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.UltimosNiveles
{
    public partial class GetUltimosNivelesResult
    {
        public string Central { get; set; }
        public double? Nivel { get; set; }

        [Column("BATT")]
        public double? BATT { get; set; }

        [Column("ITEMP")]
        public double? ITEMP { get; set; }

        [Column("DISTANCE")]
        public double? DISTANCE { get; set; }

        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
    }
}
