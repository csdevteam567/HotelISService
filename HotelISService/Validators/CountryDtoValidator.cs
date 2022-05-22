using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class CountryDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Country Validate(CountryDto country)
        {
            Country result = null;
            ValidationResult.IsOperationSuccessful = true;

            if (!Regex.IsMatch(country.CountryName, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Wrong country name! Country name doesn`t match pattern.";
            }
            else
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query = db.Countries.Where(c => c.Name == country.CountryName && c.Id != country.CountryId);
                        if (query.Count() > 0)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "This country is already exist";
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
                result = new Country()
                {
                    Id = country.CountryId,
                    Name = country.CountryName
                };
            }

            return result;
        }
    }
}