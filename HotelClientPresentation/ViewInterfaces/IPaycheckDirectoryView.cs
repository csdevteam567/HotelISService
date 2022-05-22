using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IPaycheckDirectoryView: IView
    {
        List<DishInfo> DishesDataSource { set; }
        List<ApartmentPaycheck> ApartmentsDataSource { set; }

        string CountryName { set; }
        string CityName { set; }
        string HotelName { set; }
        double TotalPrice { set; }

        event Action LoadPaycheck;

        void ShowError(string errorMessage);
    }
}
