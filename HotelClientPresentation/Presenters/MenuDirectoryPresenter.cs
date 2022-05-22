using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class MenuDirectoryPresenter : BasePresener<IMenuDirectoryView, Restaurant, LoginResult>
    {
        private readonly IMenuDataService _service;
        private Restaurant currentRestaurant;
        private LoginResult currentUser;

        public MenuDirectoryPresenter(IApplicationController controller, IMenuDirectoryView view, IMenuDataService service)
            : base(controller, view)
        {
            _service = service;
            View.AddDish += () => AddDish();
            View.DeleteDish += () => DeleteDish();
            View.UpdateDish += () => UpdateDish();
            View.LoadMenu += () => LoadMenu();
        }

        public override void Run(Restaurant restaurant, LoginResult user)
        {
            currentRestaurant = restaurant;
            currentUser = user;
            View.Show();
            View.RestaurantName = string.Format(currentRestaurant.Name + " - ({0})", currentRestaurant.HotelName );
            View.AdminControls = currentUser.UserRole == 1 ? true : false;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddDish()
        {
            if (!string.IsNullOrEmpty(View.DishName))
            {
                Menu menu = new Menu()
                {
                    DishName = View.DishName,
                    Price = View.DishPrice,
                    RestaurantId = currentRestaurant.RestaurantId
                };

                var result = _service.InsertDish(menu);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadMenu();
                }
            }
            else
            {
                View.ShowError("Restaurant name is required!");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteDish()
        {
            if (View.CurrentDish != null)
            {
                ServiceResponce result = _service.DeleteDish(View.CurrentDish);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadMenu();
                }
            }
            else
            {
                View.ShowError("First you need to select record");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void UpdateDish()
        {
            if (View.CurrentDish != null)
            {
                ServiceResponce result = _service.UpdateDish(View.CurrentDish);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadMenu();
                }
            }
            else
            {
                View.ShowError("First you need to select record");
            }
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadMenu()
        {
            Menu menu = new Menu()
            {
                RestaurantId = currentRestaurant.RestaurantId
            };
            _service.DishesList = _service.GetMenu(menu);
            View.MenuDataSource = _service.DishesList;
        }
    }
}
