using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class CityDirectoryPresenter : BasePresener<ICityDirectoryView, LoginResult>
    {
        private readonly ICityDataService _service;
        private readonly ICountryDataService _countryService;
        private LoginResult currentUser;

        public CityDirectoryPresenter(IApplicationController controller, ICityDirectoryView view, ICityDataService service, ICountryDataService countryService)
            : base(controller, view)
        {
            _service = service;
            _countryService = countryService;
            View.AddCity += () => AddCity();
            View.DeleteCity += () => DeleteCity();
            View.LoadCities += () => LoadCities();
            View.LoadCountries += () => LoadCountries();
            View.UpdateCity += () => UpdateCity();
            View.OpenCountriesDirectory += () => OpenCountriesDirectory();
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
        private void AddCity()
        {
            if (View.CurrentCountry != null)
            {
                if (!string.IsNullOrWhiteSpace(View.CityName))
                {
                    City city = new City()
                    {
                        CountryId = View.CurrentCountry.Id,
                        CityName = View.CityName,
                    };

                    var result = _service.InsertCity(city);
                    if (!result.IsOperationSuccessful)
                    {
                        View.ShowError(result.Message);
                    }
                    else
                    {
                        View.CityName = "";
                        LoadCities();
                    }
                }
                else
                {
                    View.ShowError("Field is empty!");
                }
            }
            else
            {
                View.ShowError("Country is not selected!");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteCity()
        {
            if (View.CurrentCity != null)
            {
                ServiceResponce result = _service.DeleteCity(View.CurrentCity);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadCities();
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
        private void UpdateCity()
        {
            if (View.CurrentCity != null)
            {
                ServiceResponce result = _service.UpdateCity(View.CurrentCity);
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
        private void LoadCities()
        {
            City city = new City()
            {
                CityName = View.CityName,
                CountryName = View.CurrentCountry.Name
            };
            _service.CitiesList = _service.GetCities(city);
            View.CitiesDataSource = _service.CitiesList;
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

        private void OpenCountriesDirectory()
        {
            Controller.Run<CountryDirectoryPresenter, LoginResult>(currentUser);
        }
    }
}
