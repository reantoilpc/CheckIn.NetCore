using System;
using AutoMapper;
using CheckIn.Service.Dtos;
using CheckIn.Service.Interfaces;

namespace CheckIn.Service.Implements
{
    public class AuthenticationService : IAuthenticationService
    {
        private IMapper _mapper;

        public AuthenticationService(IMapper mapper)
        {
            _mapper = mapper;

        }
        public AccessTokenDto GetAccessToken(LoginDto dto)
        {
            return new AccessTokenDto()
            {
                AccessToken = Guid.NewGuid().ToString()
            };
        }
    }
}