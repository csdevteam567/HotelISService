using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IRestaurantDataService
    {
        List<Restaurant> RestaurantsList { get; set; }
        List<Restaurant> GetRestaurants(Restaurant restaurant);
        ServiceResponce InsertRestaurant(Restaurant restaurant);
        ServiceResponce DeleteRestaurant(Restaurant restaurant);
        ServiceResponce UpdateRestaurant(Restaurant restaurant);
    }
}
