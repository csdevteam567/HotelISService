using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class PaycheckDirectoryPresenter : BasePresener<IPaycheckDirectoryView, Order>
    {
        private readonly IOrderDataService _service;
        private Order currentOrder;

        public PaycheckDirectoryPresenter(IApplicationController controller, IPaycheckDirectoryView view, IOrderDataService service)
            : base(controller, view)
        {
            _service = service;
            View.LoadPaycheck+= () => LoadPaycheck();
        }

        public override void Run(Order argument)
        {
            currentOrder = argument;
            View.Show();
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadPaycheck()
        {
            _service.OrderPaycheck = _service.CheckoutOrder(currentOrder);
            View.DishesDataSource = _service.OrderPaycheck.OrderedDishes;
            View.ApartmentsDataSource = _service.OrderPaycheck.OrderedApartments;
            View.CityName = _service.OrderPaycheck.CityName;
            View.CountryName = _service.OrderPaycheck.CountryName;
            View.HotelName = _service.OrderPaycheck.HotelName;
            View.TotalPrice = _service.OrderPaycheck.TotalPrice;
        }
    }
}
