using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IOrderedApartmentDataService
    {
        List<Guest> GuestsList { get; set; }
        List<OrderedApartment> OrderedApartmentsList { get; set; }
        List<Apartment> AvailableApartmentsList { get; set; }

        ServiceResponce OrderApartment(OrderedApartment orderedApt);
        ServiceResponce CheckOutGuest(OrderedApartment orderedApt);
        List<OrderedApartment> GetOrderedApartments(OrderedApartment orderedApt);
        ServiceResponce DeleteOrderedApartment(OrderedApartment orderedApt);
    }
}
