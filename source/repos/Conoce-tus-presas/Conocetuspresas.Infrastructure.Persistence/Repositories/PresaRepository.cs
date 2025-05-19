using Conocetuspresas.Core.Domain.Entities;
using Conocetuspresas.Core.Application.Interfaces.Repositories;

namespace Conocetuspresas.Infrastructure.Persistence.Repositories
{
    public class PresaRepository : GenericRepository<Presa>, IPresaRepository
    {
        private readonly ApplicationContext context;

        public PresaRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
    }
}
