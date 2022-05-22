using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class MenuDataService: IMenuDataService
    {
        public List<Menu> GetMenu(Menu menu)
        {
            List<Menu> result = new List<Menu>();

            try
            {
                var dtoResult = HotelService.Client.GetMenu(new MenuDto()
                {
                    RestaurantId = menu.RestaurantId
                });

                foreach(var mu in dtoResult)
                {
                    result.Add(new Menu() 
                    {
                        DishId = mu.DishId,
                        DishName = mu.DishName,
                        HotelName = mu.HotelName,
                        Price = mu.Price,
                        RestaurantId = mu.RestaurantId,
                        RestaurantName = mu.RestaurantName
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertDish(Menu menu)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertDish(new MenuDto()
                {
                    RestaurantId = menu.RestaurantId,
                    DishName = menu.DishName,
                    Price = menu.Price
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

        public ServiceResponce DeleteDish(Menu menu)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteDish(new MenuDto()
                {
                    DishId = menu.DishId
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

        public ServiceResponce UpdateDish(Menu menu)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateMenu(new MenuDto()
                {
                    RestaurantId = menu.RestaurantId,
                    DishId = menu.DishId,
                    DishName = menu.DishName,
                    Price = menu.Price
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

        public List<Menu> DishesList { get; set; }
    }
}
