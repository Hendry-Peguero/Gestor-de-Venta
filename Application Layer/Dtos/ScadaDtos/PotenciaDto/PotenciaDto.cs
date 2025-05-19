using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos
{
    public class PotenciaDto
    {
        public int IDLlave { get; set; }
        public Byte IDCentral { get; set; }
        public string NombreCentral { get; set; }
        public string Generadores { get; set; }
        public Double Valor { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime Fecha { get; set; }
    }
}
