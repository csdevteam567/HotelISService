using System;
using System.Collections.Generic;
using HotelClientModel;
using HotelClientPresentation.HotelServiceReference;

namespace HotelClientPresentation
{
    public class OrderedApartmentDirectoryPresenter : BasePresener<IOrderedApartmentDirectoryView, Order>
    {
        private readonly IOrderedApartmentDataService _service;
        private readonly IApartmentDataService _apartmentService;
        private readonly IGuestDataService _guestService;
        private Order currentOrder;

        public OrderedApartmentDirectoryPresenter(IApplicationController controller, IOrderedApartmentDirectoryView view, IOrderedApartmentDataService service, 
            IGuestDataService guestService, IApartmentDataService apartmentService)
            : base(controller, view)
        {
            _service = service;
            _guestService = guestService;
            _apartmentService = apartmentService;

            View.LoadOrderedApartments += () => LoadOrderedApartments();
            View.OrderApartment += () => OrderApartment();
            View.DeleteOrderedApartment += () => DeleteOrderedApartment();
            View.LoadApartments += () => LoadApartments();
            View.LoadGuests += () => LoadGuests();
            View.CheckOutGuest += () => CheckoutGuest();
            View.OpenGuestsDirecory += () => OpenGuestsDirectory();
        }

        public override void Run(Order argument)
        {
            currentOrder = argument;
            View.Show();
        }


        private void CheckoutGuest()
        {
            if(View.CurrentOrderedApartment != null)
            {
                ServiceResponce result = _service.CheckOutGuest(View.CurrentOrderedApartment);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadOrderedApartments();
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
        private void OrderApartment()
        {
            if (View.CurrentApartment != null)
            {
                if (View.CurrentGuest != null)
                {
                    OrderedApartment ordApt = new OrderedApartment()
                    {
                        ApartmentId = View.CurrentApartment.ApartmentId,
                        GuestPassportNumber = View.CurrentGuest.PassportNumber,
                        OrderId = currentOrder.Id,
                        ActualDepartureDate = View.DepartureDate
                    };

                    var responce = _service.OrderApartment(ordApt);
                    if (!responce.IsOperationSuccessful)
                    {
                        View.ShowError(responce.Message);
                    }
                    else
                    {
                        LoadOrderedApartments();
                    }
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
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteOrderedApartment()
        {
            if (View.CurrentOrderedApartment != null)
            {
                ServiceResponce result = _service.DeleteOrderedApartment(View.CurrentOrderedApartment);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadOrderedApartments();
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
        private void LoadOrderedApartments()
        {
            OrderedApartment ordApt = new OrderedApartment()
            {
                OrderId = currentOrder.Id
            };
            _service.OrderedApartmentsList = _service.GetOrderedApartments(ordApt);
            View.OrderedApartmentsDataSource = _service.OrderedApartmentsList;
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
                View.GuestsDataSource = _service.GuestsList;
                if (_service.GuestsList.Count == 1)
                {
                    View.CurrentGuest = _service.GuestsList[0];
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
        private void LoadApartments()
        {
            Apartment apartment = new Apartment()
            {
                HotelId = currentOrder.HotelId,
                OnlyAvailable = true
            };
            _service.AvailableApartmentsList = _apartmentService.GetApartments(apartment);
            View.AvailableApartmentsDataSource = _service.AvailableApartmentsList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        void OpenGuestsDirectory()
        {
            Controller.Run<GuestDirectoryPresenter>();
        }
    }
}
