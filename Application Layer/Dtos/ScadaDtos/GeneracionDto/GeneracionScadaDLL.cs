using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.GeneracionUltimas24HorasDto;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using AutoMapper;

namespace ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.GeneracionUltimas24HorasDto;

public class Generacion24hScadaDLL
{
    private readonly IScadaRepository _repository;
    private readonly IMapper _mapper;

    public Generacion24hScadaDLL(IScadaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    //public async Task<IEnumerable<GeneracionUltimas24HorasDto>> GetGeneracion24hAsync()
    //{
    //    var result = await _repository.GetGeneracionUltimas24Horas();
    //    return _mapper.Map<IEnumerable<GeneracionUltimas24HorasDto>>(result);
    //}
}