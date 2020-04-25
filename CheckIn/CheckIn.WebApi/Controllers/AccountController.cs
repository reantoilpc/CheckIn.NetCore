using System.Threading.Tasks;
using AutoMapper;
using CheckIn.Service.Dtos;
using CheckIn.Service.Interfaces;
using CheckIn.WebApi.Controllers.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace CheckIn.WebApi.Controllers
{
    /// <summary>
    /// 使用者類別
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private IMapper _mapper;

        public AccountController(
            IAuthenticationService authenticationService,
            IMapper mapper)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;

        }
        
        /// <summary>
        /// 使用者登入
        /// </summary>
        /// <param name="parameter">登入參數</param>
        /// <returns></returns>
        [HttpPost]
        public AccessTokenViewModel Login([FromBody] LoginParameter parameter)
        {
            var loginDto = this._mapper.Map<LoginDto>(parameter);
            
            // var accessTokenDto = _authenticationService.GetAccessToken(loginDto);
            //
            // var accessTokenViewModel = _mapper.Map<AccessTokenViewModel>(accessTokenDto);
            //
            // return accessTokenViewModel;
            return new AccessTokenViewModel();
        }
    }
}