using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class UserDataService: IUserDataService
    {
        public List<User> GetUsers(User user)
        {
            List<User> result = new List<User>();

            try
            {
                if (user == null)
                {
                    user = new User()
                    {
                        LastName = ""
                    };
                }

                

                var dtoResult = HotelService.Client.GetUsers(new UserDto()
                {
                    LastName = user.LastName
                });

                foreach(var us in dtoResult)
                {
                    result.Add(new User() 
                    {
                        Id = us.Id,
                        FirstName = us.FirstName,
                        LastName = us.LastName,
                        Password = us.Password,
                        Role = us.Role,
                        UserLogin = string.Format(us.LastName + us.Id),
                        IsAdmin = us.Role == 1
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertUser(User user)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertUser(new UserDto()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    Role = user.Role
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce DeleteUser(User user)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteUser(new UserDto()
                {
                    Id = user.Id
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce UpdateUser(User user)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateUser(new UserDto()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    Role = user.Role
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        List<User> IUserDataService.UsersList { get; set; }
    }
}
