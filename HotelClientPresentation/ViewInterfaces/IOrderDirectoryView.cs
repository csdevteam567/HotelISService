using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IOrderDirectoryView: IView
    {
        List<Apartment> AvailableApartmentsDataSource { get; set; }
        Apartment CurrentApartment { get; }
        DateTime DepartureDate { get; }

        List<Order> OrdersDataSource { get; set; }
        List<Country> CountriesDataSource { get; set; }
        List<City> CitiesDataSource { get; set; }
        List<Hotel> HotelsDataSource { get; set; }
        List<Guest> CustomersDataSource { get; set; }

        Order CurrentOrder { get; }
        Country CurrentCountry { get; }
        City CurrentCity { get; }
        Hotel CurrentHotel { get; }
        Guest CurrentCustomer { get; set; }
        string CustomerLastname { get; }
        string CustomerFirstname { get; }
        string CustomerPassportNumber { get; }
        string CustomerFamily { get; }

        event Action AddOrder;
        event Action DeleteOrder;
        event Action LoadOrders;
        event Action LoadCountries;
        event Action LoadCities;
        event Action LoadHotels;
        event Action LoadGuests;
        event Action OpenGuestsDirectory;

        event Action EditListOfGuests;
        event Action CheckOutOrder;
        event Action CalculatePrice;
        event Action LoadApartments;

        void ShowError(string errorMessage);
    }
}
