using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IRestaurantDirectoryView: IView
    {
        List<Restaurant> RestaurantsDataSource { get; set; }
        int TableRowCount { get; }

        Restaurant CurrentRestaurant { get; }

        string RestaurantName { get; set; }
        string HotelName { get; set; }

        bool AdminControls { set; }

        event Action AddRestaurant;
        event Action DeleteRestaurant;
        event Action UpdateRestaurant;
        event Action LoadRestaurants;
        event Action EditMenu;

        void ShowError(string errorMessage);
    }
}
