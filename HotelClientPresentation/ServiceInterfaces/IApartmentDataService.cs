using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IApartmentDataService
    {
        List<Apartment> ApartmentsList { get; set; }
        List<Apartment> GetApartments(Apartment apartment);
        ServiceResponce InsertApartment(Apartment apartment);
        ServiceResponce DeleteApartment(Apartment apartment);
        ServiceResponce UpdateApartment(Apartment apartment);
    }
}
