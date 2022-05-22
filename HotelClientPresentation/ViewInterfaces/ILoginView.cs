using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface ILoginView : IView
    {
        string Login { get; }
        string Password { get; }
        event Action LogIn;
        event Action Cancel;
        event Action LoadUsers;
        void ShowError(string errorMessage);
        List<User> UsersDataSource { set; }
    }
}
