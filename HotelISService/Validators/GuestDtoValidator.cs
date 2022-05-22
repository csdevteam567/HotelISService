using System;
using System.Collections.Generic;
using HotelISDTO;
using System.Text.RegularExpressions;
using System.Linq;

namespace HotelISService
{
    public class GuestDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Guest Validate(GuestDto guest)
        {
            Guest result = null;
            ValidationResult.IsOperationSuccessful = true;

            try
            {
                if (!Regex.IsMatch(guest.FirstName, "^[A-Z]{1}[a-z]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Wrong first name! First name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(guest.LastName, "^[A-Z]{1}[a-z]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong last name! Last name doesn`t match pattern.";
                }

                if (!string.IsNullOrEmpty(guest.MiddleName) && guest.MiddleName != "N/A" && !Regex.IsMatch(guest.MiddleName, "^[A-Z]{1}[a-z]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong middle name! Middle name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(guest.Email, @"^[a-z]+@+[a-z]+\.+[a-z]{2,4}$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong email! Email doesn`t match pattern.";
                }

                if (!Regex.IsMatch(guest.Phone, @"^\+?[0-9\-]+[0-9]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong phone number! Phone contains forbidden symbols.";
                }

                if (guest.DateOfBirth >= System.DateTime.Today)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Date of birth can`t be in the future.";
                }

                if (string.IsNullOrEmpty(guest.PassportNumber))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong passport number";
                }

                if (ValidationResult.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {
                            var query = db.Guests.Where(g => g.PassportNumber == guest.PassportNumber && g.Id != guest.GuestId);
                            if (query.Count() > 0)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = "Guest with this passport id is already exist.";
                            }
                        }
                        catch (Exception ex)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "DB error: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Some data fields are missing." + ex.Message;
            }

            if (string.IsNullOrEmpty(guest.MiddleName))
            {
                guest.MiddleName = "N/A";
            }

            
            if(ValidationResult.IsOperationSuccessful)
            {
                result = new Guest()
                {
                    Id = guest.GuestId,
                    FirstName = guest.FirstName,
                    LastName = guest.LastName,
                    MiddleName = guest.MiddleName,
                    PassportNumber = guest.PassportNumber,
                    Phone = guest.Phone,
                    Sex = guest.Sex,
                    StatusVip = guest.StatusVip,
                    DateOfBirth = guest.DateOfBirth,
                    Discount = guest.Discount,
                    Email = guest.Email,
                };
            }

            return result;
        }
    }
}