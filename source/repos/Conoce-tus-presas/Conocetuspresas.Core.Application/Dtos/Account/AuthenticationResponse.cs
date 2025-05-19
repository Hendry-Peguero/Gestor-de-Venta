using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conocetuspresas.Core.Application.Dtos.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public List<string>? Roles { get; set; }
        public bool HasError { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
