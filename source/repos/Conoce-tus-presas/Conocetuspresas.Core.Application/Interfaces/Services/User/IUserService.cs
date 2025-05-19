using Conocetuspresas.Core.Application.Dtos.Account;
using Conocetuspresas.Core.Application.ViewModels.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conocetuspresas.Core.Application.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<AuthenticationResponse> LoginAsync(LoginViewModel vm);
    }
}
