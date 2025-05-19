using Conocetuspresas.Infrastructure.Identity.Context;
using Conocetuspresas.Infrastructure.Identity.Entities;
using Conocetuspresas.Infrastructure.Identity.Seeds.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Conocetuspresas.Infrastructure.Identity.Seeds;

namespace Conocetuspresas.Infrastructure.Identity.DependencyInjection
{
    public static class DependencyInjectionPersistenceLayer
    {
        public static void AddIdentityDependency(this IServiceCollection services, IConfiguration configuration)
        {
            #region Database
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(
                    options => options.UseInMemoryDatabase("IdentityDb")
                );
            }
            else
            {
                var connectionString = configuration.GetConnectionString("IdentityConnection");

                services.AddDbContext<ApplicationContext>(
                    options => options.UseSqlServer(
                        connectionString,
                        m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)
                    )
                );
            }
            #endregion

            #region Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

            services.AddAuthentication();
            #endregion

        }
        public static async Task AddIdentitySeeds(this IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

                    await DefaultRoles.SeedAsync(userManager, roleManager); 
                    await DefaultAdminUsers.SeedAsync(userManager, roleManager);
                    await DefaultDeveloperUsers.SeedAsync(userManager, roleManager);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
