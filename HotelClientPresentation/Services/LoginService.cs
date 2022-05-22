using System;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class LoginService : ILoginService
    {
        public LoginResult LogIn(LoginData login)
        {
            //HotelServiceClient client = new HotelServiceClient("BasicHttpBinding_IHotelService");
            LoginResultDto result;
            try
            {
                //result = client.AuthorizeUzer(new LoginDto()
                result = HotelService.Client.AuthorizeUzer(new LoginDto
                {
                    Login = login.Login,
                    Password = login.Password
                });
            }
            catch(Exception ex)
            {
                result = new LoginResultDto()
                {
                    UserId = 0,
                    Message = "Service connection problem" + ex.Message
                };
            }
            return new LoginResult(result.UserId, result.UserLogin, result.UserRole, result.Message);
        }
    }
}
