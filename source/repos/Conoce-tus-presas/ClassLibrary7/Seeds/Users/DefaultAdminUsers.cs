using Conocetuspresas.Core.Application.Enums;
using Conocetuspresas.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace Conocetuspresas.Infrastructure.Identity.Seeds.Users
{
    public class DefaultAdminUsers
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new()
            {
                UserName = "admin2",
                Name = "admin2",
                Email = "admin2@email.com",
                EmailConfirmed = true,
            };

            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                // Si el usuario no existe, créalo
                await userManager.CreateAsync(defaultUser, "123Pa$$Word!");
                await userManager.AddToRoleAsync(defaultUser, ERoles.ADMIN.ToString());
            }
        }
    }
}
