//using Microsoft.AspNetCore.Identity;
//using Conocetuspresas.Infrastructure.Identity.Entities;
//using Conocetuspresas.Core.Application.Dtos.Account;
//using AutoMapper;
//using Microsoft.Extensions.Options;
//using Conocetuspresas.Core.Application.Interfaces.Services.User;

//namespace Conocetuspresas.Infrastructure.Identity.Services
//{
//    public class AccountService : IAccountService
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;

//        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        public async Task<AuthenticationResponse> AuthenticationAsync(AuthenticationReguest reguest)
//        {
//            AuthenticationResponse response = new();

//            var user = await _userManager.FindByNameAsync(reguest.Username);
//            if (user == null)
//            {
//                response.HasError = true;
//                response.ErrorDescription = "Usuario no encontrado.";
//                return response;
//            }

//            var result = await _signInManager.PasswordSignInAsync(user.UserName, reguest.Password, false, lockoutOnFailure: false);
//            if (result.Succeeded)
//            {
//                response.HasError = true;
//                response.ErrorDescription = "Error";
//                return response;
//            }

//            response.Id = user.Id;
//            response.UserName = user.UserName;
//            response.Name = user.Name;
//            var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
//            response.Roles = rolesList.ToList();

//            return response;
//        }
//    }
//}
using Microsoft.AspNetCore.Identity;
using Conocetuspresas.Infrastructure.Identity.Entities;
using Conocetuspresas.Core.Application.Dtos.Account;
using AutoMapper;
using Microsoft.Extensions.Options;
using Conocetuspresas.Core.Application.Interfaces.Services.User;

namespace Conocetuspresas.Infrastructure.Identity.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<AuthenticationResponse> AuthenticationAsync(AuthenticationReguest reguest)
        {
            AuthenticationResponse response = new();

            var result = await _signInManager.PasswordSignInAsync(reguest.UserName, reguest.Password, false, lockoutOnFailure: false);

            if (!result.Succeeded) 
            {
                response.HasError = true;
                response.ErrorDescription = "Credenciales incorrectas.";
                return response;
            }


            var user = await _userManager.FindByNameAsync(reguest.UserName);

            if (user == null) 
            {
                response.HasError = true;
                response.ErrorDescription = "Usuario no encontrado.";
                return response;
            }

            response.Id = user.Id;
            response.UserName = user.UserName;
            response.Name = user.Name;
            response.Roles = (await _userManager.GetRolesAsync(user)).ToList();
            response.HasError = false;

            return response;
        }
    }
}
