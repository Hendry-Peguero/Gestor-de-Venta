using Conocetuspresas.Core.Application.Interfaces.Services.Commons;
using Conocetuspresas.Core.Application.Interfaces.Services.User;
using Conocetuspresas.Core.Application.Services.Commons;
using Conocetuspresas.Core.Application.Services.User;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Conocetuspresas.Core.Application.DependencyInjection
{
    public static class DependencyInjectionApplicationLayer
    {
        public static void AddApplicationDependency(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //for meditr
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IUserService, UserService>();

        }
    }
}
