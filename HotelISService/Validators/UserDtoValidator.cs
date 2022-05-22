using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HotelISDTO;

namespace HotelISService
{
    public class UserDtoValidator
    {
        private ServiceResponceDto validationResult;

        public ServiceResponceDto ValidationResult 
        {
            get
            {
                return validationResult;
            }
            private set
            {
                validationResult = value;
            }
        }

        public UserDtoValidator()
        {
            validationResult = new ServiceResponceDto()
            {
                IsOperationSuccessful = true
            };
        }

        public User Validate(UserDto user)
        {
            User result = null;

            try
            {
                if (!Regex.IsMatch(user.FirstName, "^[A-Z]{1}[a-z]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Wrong first name! First name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(user.LastName, "^[A-Z]{1}[a-z]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong last name! Last name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(user.Password, "[0-9A-Za-z]{5,}"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong password! Password must be at least 5 characters long.";
                }

                if (!(user.Role == 1 || user.Role == 2))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong user role! Must be 1 or 2";
                }
            }
            catch (Exception ex)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Some data fields are missing: " + ex.Message;
            }

            
            if(ValidationResult.IsOperationSuccessful)
            {
                result = new User()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Role = user.Role,
                    Password = user.Password
                };
            }

            return result;
        }
    }
}