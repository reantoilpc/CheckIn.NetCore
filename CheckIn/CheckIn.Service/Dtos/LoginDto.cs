namespace CheckIn.Service.Dtos
{
    public class LoginDto
    {
        /// <summary>
        /// 使用者帳號
        /// </summary>
        public string UserAccount { get; set; }

        /// <summary>
        /// 使用者密碼
        /// </summary>
        public string Password { get; set; }
    }
}