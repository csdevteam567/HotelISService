using HotelClientPresentation.HotelServiceReference;
using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IGuestDataService
    {
        List<Country> CountriesList { get; set; }
        List<City> CitiesList { get; set; }
        List<Hotel> HotelsList { get; set; }
        List<Guest> GuestsList { get; set; }
        List<Guest> GetGuests(GuestSearchCriteriaDto guest);
        ServiceResponce InsertGuest(Guest guest);
        ServiceResponce DeleteGuest(Guest guest);
        ServiceResponce UpdateGuest(Guest guest);
    }
}
