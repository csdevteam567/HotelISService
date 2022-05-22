using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IStatusView: IView
    {
        List<OrderedApartment> StatusDataSource { get; set; }
        List<Country> CountriesDataSource { get; set; }
        List<City> CitiesDataSource { get; set; }
        List<Hotel> HotelsDataSource { get; set; }
        List<Floor> FloorsDataSource { get; set; }

        Country CurrentCountry { get; }
        City CurrentCity { get; }
        Hotel CurrentHotel { get; }
        Floor CurrentFloor { get; }

        event Action LoadStatus;
        event Action LoadCountries;
        event Action LoadCities;
        event Action LoadHotels;
        event Action LoadFloors;

        void ShowError(string errorMessage);
    }
}
