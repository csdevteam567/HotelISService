using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IMenuDataService
    {
        List<Menu> DishesList { get; set; }
        List<Menu> GetMenu(Menu menu);
        ServiceResponce InsertDish(Menu menu);
        ServiceResponce DeleteDish(Menu menu);
        ServiceResponce UpdateDish(Menu menu);
    }
}
