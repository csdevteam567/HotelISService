using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IHotelDirectoryView : IView
    {
        List<City> CitiesDataSource { set; } //Maybe i should add Country name to end of the string
        List<Country> CountriesDataSource { set; }
        List<Hotel> HotelsDataSource { get; set; }
        int TableRowCount { get; }

        Country CurrentCountry { get; }
        City CurrentCity { get; }
        Hotel CurrentHotel { get; }

        string HotelName { get; set; }
        int HotelRating { get; set; }
        int HotelFloorsCount { get; set; }

        bool AdminControls { set; }

        event Action AddHotel;
        event Action DeleteHotel;
        event Action UpdateHotel;
        event Action LoadHotels;
        event Action LoadCities;
        event Action LoadCountries;
        event Action AddFloors;
        event Action AddRestaurants;

        void ShowError(string errorMessage);
    }
}
