using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IApartmentDirectoryView: IView
    {
        List<Apartment> ApartmentDataSource { get; set; }
        Apartment CurrentApartment { get; }

        int TableRowCount { get; }

        string HotelName { get; set; }
        int ApartmentNumber { get; set; }
        float ApartmentPrice { get; set; }
        bool HasStatusVip { get; set; }
        int MaxCapacity { get; set; }
        int RoomsNumber { get; set; }

        bool AdminControls { set; }

        event Action AddApartment;
        event Action DeleteApartment;
        event Action UpdateApartment;
        event Action LoadApartments;

        void ShowError(string errorMessage);
    }
}
