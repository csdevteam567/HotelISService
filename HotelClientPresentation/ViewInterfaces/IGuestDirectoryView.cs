using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IGuestDirectoryView: IView
    {
        List<Guest> GuestsDataSource { get; set; }
        List<String> SexEditDataSource { set; }

        List<Country> CountryDataSource { set; }
        List<City> CityDataSource { set; }
        List<Hotel> HotelDataSource { set; }

        Country CurrentCountry { get; }
        City CurrentCity { get; }
        Hotel CurrentHotel { get; }

        int TableRowCount { get; }

        Guest CurrentGuest { get; }

        string PassportNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }

        DateTime DateOfBirth { get; set; }
        string Sex { get; set; }
        string Phone { get; set; }
        string Email { get; set; }

        event Action AddGuest;
        event Action DeleteGuest;
        event Action UpdateGuest;
        event Action LoadGuests;

        event Action LoadCountries;
        event Action LoadCities;
        event Action LoadHotels;
        event Action EditChildParentRelations;

        void ShowError(string errorMessage);
    }
}
