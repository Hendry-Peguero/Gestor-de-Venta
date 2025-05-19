using Conocetuspresas.Core.Domain.Entities;
using Conocetuspresas.Core.Application.Interfaces.Repositories;

namespace Conocetuspresas.Infrastructure.Persistence.Repositories
{
    public class FotosPresaRepository : GenericRepository<FotosPresa>, IFotosPresaRepository
    {
        private readonly ApplicationContext context;

        public FotosPresaRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
    }
}
