using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IMenuDirectoryView: IView
    {
        List<Menu> MenuDataSource { get; set; }
        int TableRowCount { get; }
        
        Menu CurrentDish { get; }

        string RestaurantName { get; set; }
        string DishName { get; set; }
        float DishPrice { get; set; }
        bool AdminControls { set; }

        event Action AddDish;
        event Action DeleteDish;
        event Action UpdateDish;
        event Action LoadMenu;

        void ShowError(string errorMessage);
    }
}
