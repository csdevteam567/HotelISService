using System;
using System.Collections.Generic;

namespace HotelClientModel
{
    public class LoginResult
    {
        public int UserId { get; private set; }
        public string UserLogin { get; private set; }
        public int UserRole { get; private set; }
        public bool IsLoginSuccessful { get; private set; }
        public string Message { get; private set; }

        public LoginResult(int userId, string userLogin, int userRole, string message)
        {
            UserId = userId;
            UserLogin = userLogin;
            UserRole = userRole;
            Message = message;
            IsLoginSuccessful = userId > 0;
        }
    }
}
