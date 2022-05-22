using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface ICountryDataService
    {
        List<Country> CountriesList { get; set; }
        List<Country> GetCountries(Country country);
        ServiceResponce InsertCountry(Country country);
        ServiceResponce DeleteCountry(Country country);
        ServiceResponce UpdateCountry(Country country);
    }
}
