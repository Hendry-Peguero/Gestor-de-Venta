using Conocetuspresas.Core.Application.Enums;
using Conocetuspresas.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conocetuspresas.Infrastructure.Identity.Seeds.Users
{
    public class DefaultSuperAdminUsers
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser defaultUser = new()
            {
                UserName = "admin",
                Email = "admin@email.com",
                EmailConfirmed = true,
            };

            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                // Si el usuario no existe, créalo
                await userManager.CreateAsync(defaultUser, "123Pa$$Word!");
                await userManager.AddToRoleAsync(defaultUser, ERoles.SUPERADMIN.ToString());
            }
        }
    }
}

