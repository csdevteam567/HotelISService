using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class HotelDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Hotel Validate(HotelDto hotel)
        {
            Hotel result = null;
            ValidationResult.IsOperationSuccessful = true;

            if (!Regex.IsMatch(hotel.Name, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Wrong hotel name! Hotel name doesn`t match pattern.";
            }

            if (!(hotel.Rating >= 2 && hotel.Rating <= 5))
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "Wrong rating value! Rating value must be between 2 and 5.";
            }

            if (hotel.MaxFloorsCount < 1)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "Wrong floors number";
            }

            if (ValidationResult.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var city = from c in db.Cities
                                   where c.Id == hotel.CityId
                                   select c;
                        if (city.Count() < 1)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = string.Format("No such city");
                        }
                        else
                        {
                            var checkQuery = from h in db.Hotels
                                             join ci in db.Cities on h.CityId equals ci.Id
                                             where h.Name == hotel.Name &&
                                             ci.CountryId == hotel.CountryId &&
                                             h.Id != hotel.HotelId
                                             select h;
                            if (checkQuery.Count() > 0)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = string.Format("Fail: hotel with the same name in the same country is exsisted.");
                            }
                            else
                            {
                                var restaurants = from r in db.Restaurants
                                                  where r.Hotel.Id == hotel.HotelId
                                                  select r;
                                if (hotel.Rating >= 4 && restaurants.Count() < 1)
                                {
                                    ValidationResult.IsOperationSuccessful = false;
                                    ValidationResult.Message = string.Format("Fail: hotel with rating more than 3 stars must have restaurant. Add restaurant first, than update rating");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ValidationResult.IsOperationSuccessful = false;
                        ValidationResult.Message = "Error during DB query execution" + ex.Message;
                    }
                }
            }

            if(ValidationResult.IsOperationSuccessful)
            {
                result = new Hotel()
                {
                    Id = hotel.HotelId,
                    CityId = hotel.CityId,
                    MaxFloorsCount = hotel.MaxFloorsCount,
                    Name = hotel.Name,
                    Rating = hotel.Rating,
                };
            }

            return result;
        }
    }
}