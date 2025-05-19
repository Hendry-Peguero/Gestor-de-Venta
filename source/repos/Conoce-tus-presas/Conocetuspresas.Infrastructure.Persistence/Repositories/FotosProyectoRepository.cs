using Conocetuspresas.Core.Domain.Entities;
using Conocetuspresas.Core.Application.Interfaces.Repositories;

namespace Conocetuspresas.Infrastructure.Persistence.Repositories
{
    public class FotosProyectoRepository : GenericRepository<FotosProyecto>, IFotosProyectoRepository
    {
        private readonly ApplicationContext context;

        public FotosProyectoRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
    }
}
