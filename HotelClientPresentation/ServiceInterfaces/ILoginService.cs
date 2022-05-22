using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface ILoginService
    {
        LoginResult LogIn(LoginData login);
    }
}
