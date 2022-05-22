using System;
using System.Collections.Generic;
using HotelClientModel;
using HotelClientPresentation.HotelServiceReference;

namespace HotelClientPresentation
{
    public class GuestDirectoryPresenter : BasePresener<IGuestDirectoryView>
    {
        private readonly IGuestDataService _service;
        private readonly ICountryDataService _countryService;
        private readonly ICityDataService _cityService;
        private readonly IHotelDataService _hotelService;

        public GuestDirectoryPresenter(IApplicationController controller, IGuestDirectoryView view, IGuestDataService service,
            ICountryDataService countryService, ICityDataService cityService, IHotelDataService hotelService)
            : base(controller, view)
        {
            _service = service;
            _countryService = countryService;
            _cityService = cityService;
            _hotelService = hotelService;
            View.AddGuest += () => AddGuest();
            View.DeleteGuest += () => DeleteGuest();
            View.UpdateGuest += () => UpdateGuest();
            View.LoadGuests += () => LoadGuests();
            View.LoadCountries += () => LoadCountries();
            View.LoadCities += () => LoadCities();
            View.LoadHotels += () => LoadHotels();
            View.EditChildParentRelations += () => OpenChildParentRelations();
            List<string> sex = new List<string>();
            sex.Add("Male");
            sex.Add("Female");
            View.SexEditDataSource = sex;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddGuest()
        {
            if (!string.IsNullOrEmpty(View.LastName))
            {
                Guest guest = new Guest()
                {
                    DateOfBirth = View.DateOfBirth,
                    Email = View.Email,
                    FirstName = View.FirstName,
                    LastName = View.LastName,
                    MiddleName = View.MiddleName,
                    PassportNumber = View.PassportNumber,
                    Phone = View.Phone,
                    Sex = View.Sex,
                };

                var result = _service.InsertGuest(guest);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    View.FirstName = "";
                    View.Email = "";
                    View.LastName = "";
                    View.PassportNumber = "";
                    View.Phone = "";
                    View.Sex = "";
                    View.MiddleName = "";
                    View.DateOfBirth = DateTime.Today;

                    LoadGuests();
                }
            }
            else
            {
                View.ShowError("Lastname required!");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteGuest()
        {
            if (View.CurrentGuest != null)
            {
                ServiceResponce result = _service.DeleteGuest(View.CurrentGuest);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadGuests();
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
        private void UpdateGuest()
        {
            if (View.CurrentGuest != null)
            {
                ServiceResponce result = _service.UpdateGuest(View.CurrentGuest);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadGuests();
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
        private void LoadGuests()
        {
            GuestSearchCriteriaDto guest = new GuestSearchCriteriaDto()
            {
                FirstName = View.FirstName,
                LastName = View.LastName,
                PassportNumber = View.PassportNumber,
            };
            if (View.CurrentCountry != null)
            {
                guest.Country = View.CurrentCountry.Name;
            }

            if(View.CurrentCity != null)
            {
                guest.City = View.CurrentCity.CityName;
            }

            if (View.CurrentHotel != null)
            {
                guest.Hotel = View.CurrentHotel.HotelName;
            }
            _service.GuestsList = _service.GetGuests(guest);
            View.GuestsDataSource = _service.GuestsList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadCountries()
        {
            _service.CountriesList = _countryService.GetCountries(null);
            View.CountryDataSource = _service.CountriesList;
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
            View.CityDataSource = _service.CitiesList;
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
                hotel.CountryId = View.CurrentCity.CountryId;
                hotel.CityId = View.CurrentCity.CityId;
            }
            _service.HotelsList = _hotelService.GetHotels(hotel);
            View.HotelDataSource = _service.HotelsList;
        }

         /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void OpenChildParentRelations()
        {
            if (View.CurrentGuest != null)
            {
                Controller.Run<ChildParentDirectoryPresenter, Guest>(View.CurrentGuest);
            }
            else
            {
                View.ShowError("You should select guest first");
            }
        }
    }
}
