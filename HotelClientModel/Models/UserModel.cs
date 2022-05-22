using System;
using System.Collections.Generic;

namespace HotelClientModel
{
    public class UserModel
    {
        User SelectedUser { get; set; }

        int TableRowCount { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string RepeatedPassword { get; set; }
        string CurrentUserLogin { get; set; }
        bool UserRole { get; set; }

        public List<User> UsersList { get; set; }
    }
}
