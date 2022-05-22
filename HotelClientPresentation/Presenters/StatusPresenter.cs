using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class StatusPresenter : BasePresener<IStatusView>
    {
        private readonly IOrderedApartmentDataService _service;
        private readonly ICountryDataService _countryService;
        private readonly ICityDataService _cityService;
        private readonly IHotelDataService _hotelService;
        private readonly IFloorDataService _floorService;

        public StatusPresenter(IApplicationController controller, IStatusView view, IOrderedApartmentDataService service, 
            ICountryDataService countryService, ICityDataService cityService, IHotelDataService hotelService, IFloorDataService floorService)
            : base(controller, view)
        {
            _service = service;
            _countryService = countryService;
            _cityService = cityService;
            _hotelService = hotelService;
            _floorService = floorService;

            View.LoadStatus += () => LoadStatus();
            View.LoadCountries += () => LoadCountries();
            View.LoadCities += () => LoadCities();
            View.LoadHotels += () => LoadHotels();
            View.LoadFloors += () => LoadFloors();
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadStatus()
        {
            OrderedApartment order = new OrderedApartment();

            if (View.CurrentCountry != null)
            {
                order.CountryName = View.CurrentCountry.Name;
            }

            if (View.CurrentCity != null)
            {
                order.CityName = View.CurrentCity.CityName;
            }

            if (View.CurrentHotel != null)
            {
                order.CountryName = View.CurrentHotel.CountryName;
                order.CityName = View.CurrentHotel.CityName;
                order.HotelName = View.CurrentHotel.HotelName;
            }

            if (View.CurrentFloor != null)
            {
                order.FloorNumber = View.CurrentFloor.FloorNum;
            }

            View.StatusDataSource = _service.GetOrderedApartments(order);
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadCountries()
        {
            View.CountriesDataSource = _countryService.GetCountries(null);
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
            View.CitiesDataSource = _cityService.GetCities(city);
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
            View.HotelsDataSource = _hotelService.GetHotels(hotel);
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadFloors()
        {
            Floor floor = new Floor();

            if (View.CurrentHotel != null)
            {
                floor.HotelId = View.CurrentHotel.HotelId;
            }

            View.FloorsDataSource = _floorService.GetFloors(floor);
        }

    }
}
