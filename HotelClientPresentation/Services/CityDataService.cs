using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class CityDataService : ICityDataService
    {
        public List<City> GetCities(City city)
        {
            List<City> result = new List<City>();

            try
            {
                if (city == null)
                {
                    city = new City()
                    {
                        CityName = "",
                        CountryName = ""
                    };
                }

                var dtoResult = HotelService.Client.GetCities(new CityDto()
                {
                    CountryId = city.CountryId,
                    CityName = city.CityName,
                    CountryName = city.CountryName
                });

                foreach(var ci in dtoResult)
                {
                    result.Add(new City() 
                    {
                        CityId = ci.CityId,
                        CountryId = ci.CountryId,
                        CityName = ci.CityName,
                        CountryName = ci.CountryName
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertCity(City city)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertCity(new CityDto()
                {
                    CityName = city.CityName,
                    CountryId = city.CountryId
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

        public ServiceResponce DeleteCity(City city)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteCity(new CityDto()
                {
                    CityId = city.CityId
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

        public ServiceResponce UpdateCity(City city)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateCity(new CityDto()
                {
                    CityId = city.CityId,
                    CountryId = city.CountryId,
                    CityName = city.CityName
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

        List<City> ICityDataService.CitiesList { get; set; }
        List<Country> ICityDataService.CountriesList { get; set; }
    }
}
