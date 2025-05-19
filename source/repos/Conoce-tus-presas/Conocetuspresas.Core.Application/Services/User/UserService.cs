using AutoMapper;
using Conocetuspresas.Core.Application.Dtos.Account;
using Conocetuspresas.Core.Application.Interfaces.Services.User;
using Conocetuspresas.Core.Application.ViewModels.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conocetuspresas.Core.Application.Services.User
{
    public class UserService : IUserService
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public UserService(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<AuthenticationResponse> LoginAsync(LoginViewModel vm)
        {
            AuthenticationReguest loginReguest = _mapper.Map<AuthenticationReguest>(vm);

            AuthenticationResponse userRespone = await _accountService.AuthenticationAsync(loginReguest);

            return userRespone;
        }
    }
}
