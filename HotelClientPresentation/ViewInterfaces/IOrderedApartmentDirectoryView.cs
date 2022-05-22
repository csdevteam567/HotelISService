using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IOrderedApartmentDirectoryView: IView
    {
        List<Apartment> AvailableApartmentsDataSource { get; set; }
        List<Guest> GuestsDataSource { get; set; }
        List<OrderedApartment> OrderedApartmentsDataSource { get; set; }

        OrderedApartment CurrentOrderedApartment { get; }
        Apartment CurrentApartment { get; }
        Guest CurrentGuest { get; set; }

        string CustomerLastname { get; }
        string CustomerFirstname { get; }
        string CustomerPassportNumber { get; }
        string CustomerFamily { get; }
        DateTime DepartureDate { get; }

        event Action OrderApartment;
        event Action DeleteOrderedApartment;
        event Action LoadOrderedApartments;
        event Action LoadApartments;
        event Action LoadGuests;
        event Action OpenGuestsDirecory;

        event Action CheckOutGuest;

        void ShowError(string errorMessage);
    }
}
