using System;
using System.Collections.Generic;
using HotelClientModel;
using HotelClientPresentation.HotelServiceReference;

namespace HotelClientPresentation
{
    public class OrderDirectoryPresenter : BasePresener<IOrderDirectoryView, LoginResult>
    {
        private readonly IOrderDataService _service;
        private readonly ICountryDataService _countryService;
        private readonly ICityDataService _cityService;
        private readonly IHotelDataService _hotelService;
        private readonly IGuestDataService _guestService;
        private readonly IApartmentDataService _apartmentService;
        private readonly IOrderedApartmentDataService _orderedApartmentService;
        private LoginResult currentUser;

        public OrderDirectoryPresenter(IApplicationController controller, IOrderDirectoryView view, IOrderDataService service, 
            ICountryDataService countryService, ICityDataService cityService, IHotelDataService hotelService, IGuestDataService guestService, 
            IApartmentDataService apartmentService, IOrderedApartmentDataService orderedApartmentService)
            : base(controller, view)
        {
            _service = service;
            _countryService = countryService;
            _cityService = cityService;
            _hotelService = hotelService;
            _guestService = guestService;
            _apartmentService = apartmentService;
            _orderedApartmentService = orderedApartmentService;

            View.LoadOrders += () => LoadOrders(View.CurrentCountry, View.CurrentCity, View.CurrentHotel, View.CurrentCustomer);
            View.LoadCountries += () => LoadCountries();
            View.LoadCities += () => LoadCities();
            View.LoadHotels += () => LoadHotels();
            View.LoadGuests += () => LoadGuests();
            View.DeleteOrder += () => DeleteOrder();

            View.AddOrder += () => AddOrder();
            View.EditListOfGuests += () => OpenOrderedApartmentDirectory();
            View.OpenGuestsDirectory += () => OpenGuestsDirectory();
            View.CalculatePrice += () => CalculatePrice();
            View.CheckOutOrder += () => CheckOutOrder();
            View.LoadApartments += () => LoadApartments();
        }

        public override void Run(LoginResult argument)
        {
            currentUser = argument;
            View.Show();
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddOrder()
        {
            if (View.CurrentHotel != null)
            {
                if (View.CurrentCustomer != null)
                {
                    if (View.CurrentApartment != null)
                    {
                        Order order = new Order()
                        {
                            HotelId = View.CurrentHotel.HotelId,
                            GuestId = View.CurrentCustomer.GuestId,
                            OrderDate = DateTime.Today,
                            UserLogin = currentUser.UserLogin,
                            DepartureDate = View.DepartureDate,
                            ApartmentId = View.CurrentApartment.ApartmentId
                        };

                        var result = _service.InsertOrder(order);
                        if (!result.IsOperationSuccessful)
                        {
                            View.ShowError(result.Message);
                        }
                        else
                        {
                            LoadOrders(View.CurrentCountry, View.CurrentCity, View.CurrentHotel, null);
                        }
                    }
                    else
                    {
                        View.ShowError("You should select apartment first");
                    }
                }
                else
                {
                    View.ShowError("You should select customer first");
                }
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
        private ServiceResponce OrderApartment(int orderId)
        {
            ServiceResponce result = new ServiceResponce();
            if (View.CurrentApartment != null)
            {
                if (View.CurrentCustomer != null)
                {
                    OrderedApartment ordApt = new OrderedApartment()
                    {
                        ApartmentId = View.CurrentApartment.ApartmentId,
                        GuestPassportNumber = View.CurrentCustomer.PassportNumber,
                        OrderId = orderId,
                        ActualDepartureDate = View.DepartureDate,
                        CountryName = View.CurrentHotel.CountryName,
                        HotelName = View.CurrentHotel.HotelName
                    };

                    result = _orderedApartmentService.OrderApartment(ordApt);
                }
                else
                {
                    View.ShowError("You need to select guest");
                }
            }
            else
            {
                View.ShowError("You need to select apartment");
            }
            return result;
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteOrder()
        {
            if (View.CurrentOrder != null)
            {
                ServiceResponce result = _service.DeleteOrder(View.CurrentOrder);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadOrders(View.CurrentCountry, View.CurrentCity, View.CurrentHotel, null);
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
        private void CalculatePrice()
        {
            if (View.CurrentOrder != null)
            {
                ServiceResponce result = _service.CalculatePrice(View.CurrentOrder);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadOrders(View.CurrentCountry, View.CurrentCity, View.CurrentHotel, null);
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
        private void UpdateOrder()
        {
            if (View.CurrentOrder != null)
            {
                ServiceResponce result = _service.UpdateOrder(View.CurrentOrder);
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
        private void LoadOrders(Country country, City city, Hotel hotel, Guest guest)
        {
            OrderSearchCriteria order = new OrderSearchCriteria();

            if (country != null)
            {
                order.CountryName = country.Name;
            }

            if (city != null)
            {
                order.CityName = city.CityName;
            }

            if (hotel != null)
            {
                order.CountryName = hotel.CountryName;
                order.CityName = hotel.CityName;
                order.HotelName = hotel.HotelName;
            }

            if (guest != null)
            {
                guest.PassportNumber = guest.PassportNumber;
            }

            _service.OrdersList = _service.GetOrders(order);
            View.OrdersDataSource = _service.OrdersList;
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
        private void LoadGuests()
        {
            if (!string.IsNullOrEmpty(View.CustomerLastname) || !string.IsNullOrEmpty(View.CustomerPassportNumber))
            {
                GuestSearchCriteriaDto guest = new GuestSearchCriteriaDto()
                {
                    FirstName = View.CustomerFirstname,
                    LastName = View.CustomerLastname,
                    PassportNumber = View.CustomerPassportNumber
                };
                _service.GuestsList = _guestService.GetGuests(guest);
                View.CustomersDataSource = _service.GuestsList;
                if (_service.GuestsList.Count == 1)
                {
                    View.CurrentCustomer = _service.GuestsList[0];
                }
            }
            else
            {
                View.ShowError("Lastname or Passport number required");
            }
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
            View.HotelsDataSource = _service.HotelsList;
        }
        
        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        void OpenOrderedApartmentDirectory()
        {
            if (View.CurrentOrder != null)
            {
                Controller.Run<OrderedApartmentDirectoryPresenter, Order>(View.CurrentOrder);
            }
            else
            {
                View.ShowError("You should select order first");
            }
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        void OpenGuestsDirectory()
        {
            Controller.Run<GuestDirectoryPresenter>();
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        void CheckOutOrder()
        {
            if (View.CurrentOrder != null)
            {
                Controller.Run<PaycheckDirectoryPresenter, Order>(View.CurrentOrder);
            }
            else
            {
                View.ShowError("First you need to select order");
            }
        }

        private void LoadApartments()
        {
            Apartment apartment = new Apartment()
            {
                HotelId = View.CurrentHotel.HotelId,
                OnlyAvailable = true
            };
            View.AvailableApartmentsDataSource = _apartmentService.GetApartments(apartment);
        }
    }
}
