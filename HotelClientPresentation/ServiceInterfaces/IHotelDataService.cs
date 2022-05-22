using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IHotelDataService
    {
        List<Hotel> HotelsList { get; set; }
        List<City> CitiesList { get; set; }
        List<Country> CountriesList { get; set; }

        List<Hotel> GetHotels(Hotel hotel);

        ServiceResponce InsertHotel(Hotel hotel);

        ServiceResponce DeleteHotel(Hotel hotel);

        ServiceResponce UpdateHotel(Hotel hotel);
    }
}
