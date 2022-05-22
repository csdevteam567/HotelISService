#region Copyright SoftComputer Consultants 2006
// 
// This module is part of the HotelIS (Hotel Information System)
// Copyright (c) Soft Computer Consultants, Inc.  2006 
//    All Rights Reserved 
// This document contains unpublished, confidential and proprietary  
// information of Soft Computer Consultants, Inc. No disclosure or use of  
// any portion of the contents of these materials may be made without the  
// express written consent of Soft Computer Consultants, Inc. 
//  
// Author:       Dmytro Mykhalskyi
// Description:  This file contains calass presenter for login window
//
// Caution: -      
#endregion 
using System;
using System.Collections.Generic;
using HotelClientModel;
using System.Text.RegularExpressions;

namespace HotelClientPresentation
{
    /// <summary> 
    /// This class is presenter for the login window. 
    /// </summary> 
    /// <remarks> 
    /// This class implements <see cref="ILoginWindow"/> interface. 
    /// </remarks> 
    /// <seealso cref="ILoginView"/> 
    public class LoginPresenter : BasePresener<ILoginView>
    {
        private readonly ILoginService _service;
        private readonly IUserDataService _userService;
        private List<User> usersList;
        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService service, IUserDataService userService)
            : base(controller, view)
        {
            _service = service;
            _userService = userService;
            View.LogIn += () => LogIn(View.Login, View.Password);
            View.Cancel += Cancel;
            View.LoadUsers += LoadUsers;
        }

        private void Cancel()
        {
            View.Close();
        }

        private void LoadUsers()
        {
            if (View.Login.Length > 2)
            {
                string lastName = Regex.Match(View.Login, "[A-Za-z]").Value;
                User user = new User()
                {
                    LastName = lastName
                };
                usersList = _userService.GetUsers(user);
                View.UsersDataSource = usersList;
            }
        }

        /// <summary> 
        /// Sends request to check user authorization to the server 
        /// </summary> 
        /// <param name="username">User login from login window.</param> 
        /// <param name="password">User password from login window.</param> 
        private void LogIn(string username, string password)
        {
            if (!string.IsNullOrEmpty(username))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    var login = new LoginData
                    {
                        Login = username,
                        Password = password
                    };
                    LoginResult result = _service.LogIn(login);
                    if (!result.IsLoginSuccessful)
                    {
                        //_view.ShowError( result.Message );
                        View.ShowError(result.Message);
                    }
                    else
                    {
                        Controller.Run<MainPresener, LoginResult>(result);
                        View.Close();
                    }
                }
                else
                {
                    View.ShowError("Password field is empty");
                }
            }
            else
            {
                View.ShowError("Error: Login field is empty");
            }
        }

    }
}
