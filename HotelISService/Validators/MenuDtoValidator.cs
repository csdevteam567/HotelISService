using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class MenuDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Menu Validate(MenuDto menu)
        {
            Menu result = null;
            ValidationResult.IsOperationSuccessful = true;

            try
            {
                if (!Regex.IsMatch(menu.DishName, @"^[A-Z]{1}\s*[A-Za-z0-9\s]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Wrong dish name! Dish name contains forbidden symbols.";
                }

                if (menu.Price == 0)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Price can`t be 0";
                }

                if (menu.RestaurantId < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Menu should be bound to the restaurant";
                }

                if (ValidationResult.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {
                            var restaurant = from r in db.Restaurants
                                             where r.Id == menu.RestaurantId
                                             select r;
                            if (restaurant.Count() < 1)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = "No such restaurant.";
                            }
                            else
                            {
                                var query = db.Menus.Where(m => m.DishName == menu.DishName && m.RestaurantId == menu.RestaurantId && m.Id != menu.DishId);
                                if (query.Count() > 0)
                                {
                                    ValidationResult.IsOperationSuccessful = false;
                                    ValidationResult.Message = "This entry is already exist.";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "Error during db query executing: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Some data fields are missing." + ex.Message;
            }

            if(ValidationResult.IsOperationSuccessful)
            {
                result = new Menu()
                {
                    Id = menu.DishId,
                    DishName = menu.DishName,
                    Price = menu.Price,
                    RestaurantId = menu.RestaurantId
                };
            }

            return result;
        }
    }
}