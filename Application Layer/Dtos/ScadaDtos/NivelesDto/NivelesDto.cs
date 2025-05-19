using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos
{
    public class NivelesDto
    {
        public int IDCentral { get; set; }
        public string Central { get; set; }
        public string Parametro { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public Double Nivel { get; set; }
        public long ReadTime { get; set; }
    }
}
