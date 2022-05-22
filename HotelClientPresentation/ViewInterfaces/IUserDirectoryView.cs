using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IUserDirectoryView: IView
    {
        List<User> UsersDataSource { get; set; }
        User SelectedUser { get; }

        int TableRowCount { get; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string RepeatedPassword { get; set; }
        string CurrentUserLogin { get; set; }
        bool UserRole { get; set; }
        bool AdminControls { set; }

        event Action AddUser;
        event Action DeleteUser;
        event Action UpdateUser;
        event Action LoadUsers;
        event Action UpdatePassword;

        void ShowError(string errorMessage);
    }
}
