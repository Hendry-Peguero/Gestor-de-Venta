using ApiPresidenciaDR.Models.Context.ScadaContext;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos;

namespace ApiPresidenciaDR.Application_Layer.Dlls.ScadaDlls
{
    public class Niveles6MesesScadaDLL
    {
        private readonly IScadaRepository _repository;

        public Niveles6MesesScadaDLL(IScadaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Niveles6MesesDto>> Niveles6MesesAsync()
        {
            return await _repository.Niveles6MesesAsync();
        }
    }
}
