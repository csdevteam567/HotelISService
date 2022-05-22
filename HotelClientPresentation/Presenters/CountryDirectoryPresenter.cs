using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class CountryDirectoryPresenter : BasePresener<ICountryDirectoryView, LoginResult>
    {
        private readonly ICountryDataService _service;
        private LoginResult currentUser;

        public CountryDirectoryPresenter(IApplicationController controller, ICountryDirectoryView view, ICountryDataService service)
            : base(controller, view)
        {
            _service = service;
            View.AddCountry += () => AddCountry();
            View.DeleteCountry += () => DeleteCountry();
            View.LoadCountries += () => LoadCountries();
            View.UpdateCountry += () => UpdateCountry();
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
        private void AddCountry()
        {
            if (!string.IsNullOrWhiteSpace(View.CountryName))
            {
                Country country = new Country()
                {
                    Name = View.CountryName
                };
                var result = _service.InsertCountry(country);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadCountries();
                    View.CountryName = "";
                }
            }
            else
            {
                View.ShowError("Field is empty");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteCountry()
        {
            if (View.CurrentCountry != null)
            {
                ServiceResponce result = _service.DeleteCountry(View.CurrentCountry);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadCountries();
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
        private void UpdateCountry()
        {
            if (View.CurrentCountry != null)
            {
                ServiceResponce result = _service.UpdateCountry(View.CurrentCountry);
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
        private void LoadCountries()
        {
            _service.CountriesList = _service.GetCountries(null);
            View.CountriesDataSource = _service.CountriesList;
        }
    }
}
