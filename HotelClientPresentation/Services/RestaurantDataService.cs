using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class RestaurantDataService: IRestaurantDataService
    {
        public List<Restaurant> GetRestaurants(Restaurant restaurant)
        {
            List<Restaurant> result = new List<Restaurant>();

            try
            {
                var dtoResult = HotelService.Client.GetRestaurants(new RestaurantDto()
                {
                    HotelId = restaurant.HotelId
                });

                foreach(var rt in dtoResult)
                {
                    result.Add(new Restaurant() 
                    {
                        HotelId = rt.HotelId,
                        HotelName = rt.HotelName,
                        Name = rt.Name,
                        RestaurantId = rt.RestaurantId
                    });
                }
            }
            catch(Exception ex)
            {
                
            }
            return result;
        }

        public ServiceResponce InsertRestaurant(Restaurant restaurant)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertRestaurant(new RestaurantDto()
                {
                    HotelId = restaurant.HotelId,
                    Name = restaurant.Name
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce DeleteRestaurant(Restaurant restaurant)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteRestaurant(new RestaurantDto()
                {
                    RestaurantId = restaurant.RestaurantId,
                    HotelId = restaurant.HotelId
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce UpdateRestaurant(Restaurant restaurant)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateRestaurant(new RestaurantDto()
                {
                    RestaurantId = restaurant.RestaurantId,
                    HotelId = restaurant.HotelId,
                    Name = restaurant.Name
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        List<Restaurant> IRestaurantDataService.RestaurantsList { get; set; }
    }
}
