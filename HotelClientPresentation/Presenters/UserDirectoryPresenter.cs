using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class UserDirectoryPresenter : BasePresener<IUserDirectoryView, LoginResult>
    {
        private readonly IUserDataService _service;
        private LoginResult currentUser;
        private UserModel userModel;

        public UserDirectoryPresenter(IApplicationController controller, IUserDirectoryView view, IUserDataService service)
            : base(controller, view)
        {
            userModel = new UserModel();
            _service = service;
            View.AddUser += () => AddUser();
            View.DeleteUser += () => DeleteUser();
            View.UpdateUser += () => UpdateUser();
            View.LoadUsers += () => LoadUsers();
            View.UpdatePassword += () => UpdatePassword();
        }

        public override void Run(LoginResult argument)
        {
            currentUser = argument;
            View.Show();
            View.CurrentUserLogin = currentUser.UserLogin;
            View.AdminControls = currentUser.UserRole == 1 ? true : false;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddUser()
        {
            if (!string.IsNullOrEmpty(View.FirstName) && !string.IsNullOrEmpty(View.LastName))
            {
                User user = new User()
                {
                    FirstName = View.FirstName,
                    LastName = View.LastName,
                    Password = View.Password,
                    Role = View.UserRole ? 1 : 2,
                };

                var result = _service.InsertUser(user);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadUsers();
                }
            }
            else
            {
                View.ShowError("Data fields are missing!");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteUser()
        {
            if (View.SelectedUser != null)
            {
                ServiceResponce result = _service.DeleteUser(View.SelectedUser);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadUsers();
                }
            }
            else
            {
                View.ShowError("First you need to select record");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void UpdateUser()
        {
            if (View.SelectedUser != null)
            {
                View.SelectedUser.Role = View.SelectedUser.IsAdmin ? 1 : 2;
                ServiceResponce result = _service.UpdateUser(View.SelectedUser);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadUsers();
                }
            }
            else
            {
                View.ShowError("First you need to select record");
            }
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadUsers()
        {
            userModel.UsersList = _service.GetUsers(null);
            View.UsersDataSource = userModel.UsersList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void UpdatePassword()
        {
            if (!string.IsNullOrEmpty(View.Password))
            {
                if (View.Password == View.RepeatedPassword)
                {
                    User selectedUser = View.SelectedUser;
                    User user = new User()
                    {
                        Id = selectedUser.Id,
                        FirstName = selectedUser.FirstName,
                        LastName = selectedUser.LastName,
                        Password = View.Password,
                        Role = selectedUser.Role,
                    };
                    ServiceResponce result = _service.UpdateUser(user);
                    if (!result.IsOperationSuccessful)
                    {
                        View.ShowError(result.Message);
                    }
                    else
                    {
                        LoadUsers();
                    }
                }
                else
                {
                    View.ShowError("Password doesn`t match repeated password!");
                }
            }
            else
            {
                View.ShowError("Password required!");
            }
        }
    }
}
