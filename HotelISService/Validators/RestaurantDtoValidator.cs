using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class RestaurantDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Restaurant Validate(RestaurantDto restaurant)
        {
            Restaurant result = null;
            ValidationResult.IsOperationSuccessful = true;

            if (!Regex.IsMatch(restaurant.Name, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Wrong restaurant name! Restaurant name doesn`t match pattern.";
            }

            if (restaurant.HotelId < 1)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "Restaurant must be bound to the hotel.";
            }

            if (ValidationResult.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var hotel = db.Hotels.Where(h => h.Id == restaurant.HotelId);
                        if (hotel.Count() < 1)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "No such hotel.";
                        }
                        else
                        {
                            var query = db.Restaurants.Where(r => r.Name == restaurant.Name && r.HotelId == restaurant.HotelId && r.Id != restaurant.RestaurantId);
                            if (query.Count() > 0)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = "Restaurant with given name is already exist!";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ValidationResult.IsOperationSuccessful = false;
                        ValidationResult.Message = "DB error: " + ex.Message;
                    }
                }
            }

            
            if(ValidationResult.IsOperationSuccessful)
            {
                result = new Restaurant()
                {
                    Id = restaurant.RestaurantId,
                    Name = restaurant.Name,
                    HotelId = restaurant.HotelId
                };
            }

            return result;
        }
    }
}