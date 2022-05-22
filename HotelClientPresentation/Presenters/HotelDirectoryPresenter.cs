using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class HotelDirectoryPresenter : BasePresener<IHotelDirectoryView, LoginResult>
    {
        private readonly IHotelDataService _service;
        private readonly ICountryDataService _countryService;
        private readonly ICityDataService _cityService;
        private LoginResult currentUser;

        public HotelDirectoryPresenter(IApplicationController controller, IHotelDirectoryView view, IHotelDataService service, ICountryDataService countryService, ICityDataService cityService)
            : base(controller, view)
        {
            _service = service;
            _countryService = countryService;
            _cityService = cityService;
            View.AddHotel += () => AddHotel();
            View.DeleteHotel += () => DeleteHotel();
            View.LoadHotels += () => LoadHotels();
            View.UpdateHotel += () => UpdateHotel();
            View.LoadCities += () => LoadCities();
            View.LoadCountries += () => LoadCountries();
            View.AddFloors += () => AddFloors();
            View.AddRestaurants += () => AddRestaurants();
        }

        public override void Run(LoginResult argument)
        {
            currentUser = argument;
            View.Show();
            View.AdminControls = currentUser.UserRole == 1 ? true : false;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddHotel()
        {
            if (View.CurrentCountry != null && View.CurrentCity != null)
            {
                if (!string.IsNullOrWhiteSpace(View.HotelName))
                {
                    Hotel hotel = new Hotel()
                    {
                        CityId = View.CurrentCity.CityId,
                        CountryId = View.CurrentCity.CountryId,
                        HotelName = View.HotelName,
                        MaxFloorsCount = View.HotelFloorsCount,
                        Rating = View.HotelRating
                    };

                    var result = _service.InsertHotel(hotel);
                    if (!result.IsOperationSuccessful)
                    {
                        View.ShowError(result.Message);
                    }
                    else
                    {
                        View.HotelName = "";
                        LoadHotels();
                    }
                }
                else
                {
                    View.ShowError("Field is empty!");
                }
            }
            else
            {
                View.ShowError("Select country and city");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteHotel()
        {
            if (View.CurrentHotel != null)
            {
                ServiceResponce result = _service.DeleteHotel(View.CurrentHotel);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadHotels();
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
        private void UpdateHotel()
        {
            if (View.CurrentHotel != null)
            {
                ServiceResponce result = _service.UpdateHotel(View.CurrentHotel);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
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
        private void LoadHotels()
        {
            Hotel hotel = new Hotel();
            if (View.CurrentCountry != null)
            {
                hotel.CountryId = View.CurrentCountry.Id;
            }

            if (View.CurrentCity != null)
            {
                hotel.CityId = View.CurrentCity.CityId;
            }
            _service.HotelsList = _service.GetHotels(hotel);
            View.HotelsDataSource = _service.HotelsList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadCountries()
        {
            _service.CountriesList = _countryService.GetCountries(null);
            View.CountriesDataSource = _service.CountriesList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadCities()
        {
            City city = new City();
            if (View.CurrentCountry != null)
            {
                city.CountryId = View.CurrentCountry.Id;
            }
            _service.CitiesList = _cityService.GetCities(city);
            View.CitiesDataSource = _service.CitiesList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddFloors()
        {
            if (View.CurrentHotel != null)
            {
                Controller.Run<FloorDirectoryPresenter, Hotel, LoginResult>(View.CurrentHotel, currentUser);
            }
            else
            {
                View.ShowError("You should select hotel first");
            }
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddRestaurants()
        {
            if (View.CurrentHotel != null)
            {
                Controller.Run<RestaurantDirectoryPresenter, Hotel, LoginResult>(View.CurrentHotel, currentUser);
            }
            else
            {
                View.ShowError("You should select hotel first");
            }
        }
    }
}
