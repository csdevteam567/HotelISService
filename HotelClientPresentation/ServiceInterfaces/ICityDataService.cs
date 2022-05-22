using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface ICityDataService
    {
        List<City> CitiesList { get; set; }
        List<Country> CountriesList { get; set; }

        List<City> GetCities(City city);

        ServiceResponce InsertCity(City city);

        ServiceResponce DeleteCity(City city);

        ServiceResponce UpdateCity(City city);
    }
}
