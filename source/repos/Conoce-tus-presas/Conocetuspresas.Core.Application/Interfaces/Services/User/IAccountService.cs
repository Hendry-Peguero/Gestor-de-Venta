using Conocetuspresas.Core.Application.Dtos.Account;

namespace Conocetuspresas.Core.Application.Interfaces.Services.User
{
    public interface IAccountService
    {
        Task<AuthenticationResponse> AuthenticationAsync(AuthenticationReguest reguest);
    }
}