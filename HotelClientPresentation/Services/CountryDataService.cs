using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class CountryDataService : ICountryDataService
    {
        public List<Country> GetCountries(Country country)
        {
            List<Country> result = new List<Country>();

            try
            {
                if (country == null)
                {
                    country = new Country()
                    {
                        Name = ""
                    };
                }

                var dtoResult = HotelService.Client.GetCountries(new CountryDto()
                {
                    CountryName = country.Name
                });

                foreach(var co in dtoResult)
                {
                    result.Add(new Country() 
                    {
                        Id = co.CountryId,
                        Name = co.CountryName
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertCountry(Country country)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertCountry(new CountryDto()
                {
                    CountryName = country.Name
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

        public ServiceResponce DeleteCountry(Country country)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteCountry(new CountryDto()
                {
                    CountryId = country.Id,
                    CountryName = country.Name
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


        public ServiceResponce UpdateCountry(Country country)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateCountry(new CountryDto()
                {
                    CountryId = country.Id,
                    CountryName = country.Name
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

        public List<Country> CountriesList { get; set; }
    }
}
