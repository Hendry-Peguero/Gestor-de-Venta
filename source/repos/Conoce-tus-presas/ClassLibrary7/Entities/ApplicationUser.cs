using Microsoft.AspNetCore.Identity;

namespace Conocetuspresas.Infrastructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
