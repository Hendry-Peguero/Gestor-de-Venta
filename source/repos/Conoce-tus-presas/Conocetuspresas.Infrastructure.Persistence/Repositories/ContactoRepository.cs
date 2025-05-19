using Conocetuspresas.Core.Domain.Entities;
using Conocetuspresas.Core.Application.Interfaces.Repositories;

namespace Conocetuspresas.Infrastructure.Persistence.Repositories
{
    public class ContactoRepository : GenericRepository<Contacto>, IContactoRepository
    {
        private readonly ApplicationContext context;

        public ContactoRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }
    }
}
