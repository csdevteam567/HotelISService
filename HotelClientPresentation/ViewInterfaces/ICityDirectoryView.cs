using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface ICityDirectoryView : IView
    {
        List<City> CitiesDataSource { get; set; }
        List<Country> CountriesDataSource { set; }

        City CurrentCity { get; }
        Country CurrentCountry { get; }

        int TableRowCount { get; }

        string CityName { get; set; }

        bool AdminControls { set; }

        event Action AddCity;
        event Action DeleteCity;
        event Action UpdateCity;
        event Action LoadCities;
        event Action LoadCountries;
        event Action OpenCountriesDirectory;

        void ShowError(string errorMessage);
    }
}
