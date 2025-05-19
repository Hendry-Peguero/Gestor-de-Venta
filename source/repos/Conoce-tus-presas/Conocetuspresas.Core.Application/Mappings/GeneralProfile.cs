using AutoMapper;
using Conocetuspresas.Core.Application.Dtos.Account;
using Conocetuspresas.Core.Application.ViewModels.Auth;

namespace Conocetuspresas.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile() {

            CreateMap<LoginViewModel, AuthenticationReguest>()
                           .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));

            CreateMap<AuthenticationResponse, LoginViewModel>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.HasError, opt => opt.MapFrom(src => src.HasError))
                .ForMember(dest => dest.ErrorDescription, opt => opt.MapFrom(src => src.ErrorDescription));
        }
    }
}
