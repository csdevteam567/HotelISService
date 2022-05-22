using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IOrderDataService
    {
        List<Country> CountriesList { get; set; }
        List<City> CitiesList { get; set; }
        List<Hotel> HotelsList { get; set; }
        List<Order> OrdersList { get; set; }
        List<Guest> GuestsList { get; set; }

        Paycheck OrderPaycheck { get; set; }
 
        List<Order> GetOrders(OrderSearchCriteria order);
        ServiceResponce InsertOrder(Order order);
        ServiceResponce DeleteOrder(Order order);
        ServiceResponce UpdateOrder(Order order);
        ServiceResponce CalculatePrice(Order order);
        Paycheck CheckoutOrder(Order order);
    }
}
