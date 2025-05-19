using ApiPresidenciaDR.Models.Context.ScadaContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using ApiPresidenciaDR.Infrastructure_Layer.Data_Access.Models.CommonModels;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos
{
    public class PotenciaUltimas24HorasScadaDLL : ControllerBase
    {
        private readonly IScadaRepository _repositoryt;
        private readonly IMapper _mapper;

        public PotenciaUltimas24HorasScadaDLL(IScadaRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryt = repository;
        }

        public async Task<IEnumerable<PotenciaDto>> PotenciaActiva5MinutoAsync()
        {
            var dto = await _repositoryt.PotenciaActiva5MinutoAsync();
            return _mapper.Map<IEnumerable<PotenciaDto>>(dto);


        }



    }
}
