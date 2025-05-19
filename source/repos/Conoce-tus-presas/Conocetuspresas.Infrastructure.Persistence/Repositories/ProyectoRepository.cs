using Conocetuspresas.Core.Domain.Entities;
using Conocetuspresas.Core.Application.Interfaces.Repositories;

namespace Conocetuspresas.Infrastructure.Persistence.Repositories
{
    public class ProyectoRepository : GenericRepository<Proyecto>, IProyectoRepository
    {
        private readonly ApplicationContext context;

        public ProyectoRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
    }
}
