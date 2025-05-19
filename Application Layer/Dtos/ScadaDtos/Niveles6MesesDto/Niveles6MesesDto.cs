using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos
{
    public class Niveles6MesesDto
    {
        public int IDCentral { get; set; }
        public string Central { get; set; }
        public string Parametro { get; set; }
        public string Mes { get; set; }
        public int Año { get; set; }
        public double NivelPromedio { get; set; }
    }
}
