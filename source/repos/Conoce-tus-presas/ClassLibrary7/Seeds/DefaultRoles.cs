using Conocetuspresas.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Conocetuspresas.Core.Application.Enums;

namespace Conocetuspresas.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(ERoles.SUPERADMIN.ToString()));
            await roleManager.CreateAsync(new IdentityRole(ERoles.ADMIN.ToString()));
            await roleManager.CreateAsync(new IdentityRole(ERoles.DEVELOPER.ToString()));
        }
    }
}
