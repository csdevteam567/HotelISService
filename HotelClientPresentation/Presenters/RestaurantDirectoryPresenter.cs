using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class RestaurantDirectoryPresenter : BasePresener<IRestaurantDirectoryView, Hotel, LoginResult>
    {
        private readonly IRestaurantDataService _service;
        private Hotel currentHotel;
        private LoginResult currentUser;

        public RestaurantDirectoryPresenter(IApplicationController controller, IRestaurantDirectoryView view, IRestaurantDataService service)
            : base(controller, view)
        {
            _service = service;
            View.AddRestaurant += () => AddRestaurant();
            View.DeleteRestaurant += () => DeleteRestaurant();
            View.UpdateRestaurant += () => UpdateRestaurant();
            View.LoadRestaurants += () => LoadRestaurants();
            View.EditMenu += () => EditMenu();

        }

        public override void Run(Hotel hotel, LoginResult user)
        {
            currentHotel = hotel;
            currentUser = user;
            View.Show();
            View.HotelName = string.Format(hotel.HotelName + " - ({0})", hotel.CountryName );
            View.AdminControls = currentUser.UserRole == 1 ? true : false;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddRestaurant()
        {
            if (!string.IsNullOrEmpty(View.RestaurantName))
            {
                Restaurant restaurant = new Restaurant()
                {
                    HotelId = currentHotel.HotelId,
                    Name = View.RestaurantName
                };

                var result = _service.InsertRestaurant(restaurant);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadRestaurants();
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
        private void DeleteRestaurant()
        {
            if (View.CurrentRestaurant != null)
            {
                ServiceResponce result = _service.DeleteRestaurant(View.CurrentRestaurant);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadRestaurants();
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
        private void UpdateRestaurant()
        {
            if (View.CurrentRestaurant != null)
            {
                ServiceResponce result = _service.UpdateRestaurant(View.CurrentRestaurant);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadRestaurants();
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
        private void LoadRestaurants()
        {
            Restaurant restaurant = new Restaurant()
            {
                HotelId = currentHotel.HotelId
            };
            _service.RestaurantsList = _service.GetRestaurants(restaurant);
            View.RestaurantsDataSource = _service.RestaurantsList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void EditMenu()
        {
            if (View.CurrentRestaurant != null)
            {
                Controller.Run<MenuDirectoryPresenter, Restaurant, LoginResult>(View.CurrentRestaurant, currentUser);
            }
            else
            {
                View.ShowError("You should select restaurant first");
            }
        }
    }
}
