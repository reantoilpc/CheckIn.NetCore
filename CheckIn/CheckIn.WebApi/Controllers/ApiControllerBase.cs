using CheckIn.Service.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CheckIn.WebApi.Controllers
{
    /// <summary>
    /// API 基底類別
    /// </summary>
    public class ApiControllerBase : ControllerBase
    {
        /// <summary>
        /// 使用者資料
        /// </summary>
        public ProfileDto Profile { get; set; }
    }
}