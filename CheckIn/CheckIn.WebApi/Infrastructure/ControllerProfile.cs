using System.Runtime.CompilerServices;
using AutoMapper;
using CheckIn.Service.Dtos;
using CheckIn.WebApi.Controllers;
using CheckIn.WebApi.Controllers.Parameters;

namespace CheckIn.WebApi.Infrastructure
{
    public class ControllerProfile : Profile
    {
        public ControllerProfile()
        {
            this.CreateMap<LoginParameter, LoginDto>();
            this.CreateMap<AccessTokenDto, AccessTokenViewModel>();
        }
        
    }
}