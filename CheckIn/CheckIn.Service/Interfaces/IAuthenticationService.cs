using CheckIn.Service.Dtos;

namespace CheckIn.Service.Interfaces
{
    public interface IAuthenticationService
    {
        AccessTokenDto GetAccessToken(LoginDto dto);
    }
}