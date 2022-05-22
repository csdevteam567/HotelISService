using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface ICountryDirectoryView : IView
    {
        List<Country> CountriesDataSource { get; set; }
        int TableRowCount { get; }

        Country CurrentCountry { get; }

        string CountryName { get; set; }
        bool AdminControls { set; }

        event Action AddCountry;
        event Action DeleteCountry;
        event Action LoadCountries;
        event Action UpdateCountry;
        void ShowError(string errorMessage);
    }
}
