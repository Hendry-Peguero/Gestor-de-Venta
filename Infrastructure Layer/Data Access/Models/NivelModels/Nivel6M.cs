using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPresidenciaDR.Models.Context.ScadaContext
{
    public class Nivel6M
    {
        public int IDCentral { get; set; }
        public string Central { get; set; }
        public string Parametro { get; set; }
        public string Mes { get; set; }
        public int Año { get; set; }
        public double NivelPromedio { get; set; }
    }
}

