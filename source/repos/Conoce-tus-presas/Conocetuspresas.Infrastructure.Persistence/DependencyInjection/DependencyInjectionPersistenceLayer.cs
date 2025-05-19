using Conocetuspresas.Core.Application.Interfaces.Repositories;
using Conocetuspresas.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conocetuspresas.Infrastructure.Persistence.DependencyInjection
{
    public static class DependencyInjectionPersistenceLayer
    {
        public static void AddPersistenceDependency(this IServiceCollection services, IConfiguration configuration)
        {
            #region Database
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(
                    options => options.UseInMemoryDatabase("DbInMemory")
                );
            }
            else
            {
                var connectionString = configuration.GetConnectionString("SqlServerConnection");

                services.AddDbContext<ApplicationContext>(
                    options => options.UseSqlServer(
                        connectionString,
                        m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)
                    )
                );
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IContactoRepository, ContactoRepository>();
            services.AddTransient<IFotosPresaRepository, FotosPresaRepository>();
            services.AddTransient<IFotosProyectoRepository, FotosProyectoRepository>();
            services.AddTransient<IPresaRepository, PresaRepository>();
            services.AddTransient<IProyectoRepository, ProyectoRepository>();

            #endregion
        }
    }
}
