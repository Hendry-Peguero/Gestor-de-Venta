using ApiPresidenciaDR.Models.Context.ScadaContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.UltimosNiveles;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos
{
    public class NivelesScadaDLL
    {
        private readonly IScadaRepository _repositoryt;
        private readonly IMapper _mapper;

        public NivelesScadaDLL(IScadaRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryt = repository;
        }

        public async Task<IEnumerable<NivelesDto>> NivelCentrales5minutosAsync()
        {
            var dto = await _repositoryt.NivelCentrales5minutosAsync();
            return _mapper.Map<IEnumerable<NivelesDto>>(dto);
        }

    }
}
