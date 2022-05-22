using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class CityDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public City Validate(CityDto city)
        {
            City result = null;
            ValidationResult.IsOperationSuccessful = true;

            try
            {
                if (!Regex.IsMatch(city.CityName, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Wrong city name! City name doesn`t match pattern.";
                }

                if (city.CountryId < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "City must be bound to the country";
                }

                if (ValidationResult.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {
                            var country = from c in db.Countries
                                          where c.Id == city.CountryId
                                          select c;
                            if (country.Count() < 1)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = "Country doesn`t exist";
                            }
                            else
                            {
                                var query = db.Cities.Where(c => c.Name == city.CityName && c.CountryId == city.CountryId && c.Id != city.CityId);
                                if (query.Count() > 0)
                                {
                                    ValidationResult.IsOperationSuccessful = false;
                                    ValidationResult.Message = "This city is already exist";
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
            }
            catch (Exception ex)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Some data fields are missing:" + ex.Message;
            }

            if(ValidationResult.IsOperationSuccessful)
            {
                result = new City()
                {
                    Id = city.CityId,
                    Name = city.CityName,
                    CountryId = city.CountryId
                };
            }

            return result;
        }
    }
}