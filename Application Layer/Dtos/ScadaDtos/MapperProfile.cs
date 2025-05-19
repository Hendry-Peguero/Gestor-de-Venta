using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.UltimosNiveles;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
                CreateMap<Potencia, PotenciaDto>();
                CreateMap<Niveles, NivelesDto>();
            //CreateMap<Generacion, GeneracionUltimas24HorasDto>();

        }

    }
}
