using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IUserDataService
    {
        List<User> UsersList { get; set; }
        List<User> GetUsers(User user);
        ServiceResponce InsertUser(User user);
        ServiceResponce DeleteUser(User user);
        ServiceResponce UpdateUser(User user);
    }
}
