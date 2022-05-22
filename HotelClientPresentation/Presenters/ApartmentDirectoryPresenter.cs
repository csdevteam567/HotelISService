using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class ApartmentDirectoryPresenter : BasePresener<IApartmentDirectoryView, Floor, LoginResult>
    {
        private readonly IApartmentDataService _service;
        private Floor currentFloor;
        private LoginResult currentUser;

        public ApartmentDirectoryPresenter(IApplicationController controller, IApartmentDirectoryView view, IApartmentDataService service)
            : base(controller, view)
        {
            _service = service;
            View.AddApartment += () => AddApartment();
            View.DeleteApartment += () => DeleteApartment();
            View.UpdateApartment += () => UpdateApartment();
            View.LoadApartments += () => LoadApartments();
        }

        public override void Run(Floor floor, LoginResult user)
        {

            currentFloor = floor;
            currentUser = user;
            View.Show();
            View.HotelName = string.Format(floor.HotelName + " - (Floor: {0})", floor.FloorNum );
            View.AdminControls = currentUser.UserRole == 1 ? true : false;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddApartment()
        {
            if (View.ApartmentNumber > 0 && View.ApartmentPrice > 0 )
            {
                Apartment apartment = new Apartment()
                {
                    FloorId = currentFloor.FloorId,
                    FloorNumber = currentFloor.FloorNum,
                    HasStatusVip = View.HasStatusVip,
                    MaxCapacity = View.MaxCapacity,
                    Number = View.ApartmentNumber,
                    Price = View.ApartmentPrice,
                    RoomsNumber = View.RoomsNumber
                };

                var result = _service.InsertApartment(apartment);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadApartments();
                }
            }
            else
            {
                View.ShowError("Some data fields are missing");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteApartment()
        {
            if (View.CurrentApartment != null)
            {
                ServiceResponce result = _service.DeleteApartment(View.CurrentApartment);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadApartments();
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
        private void UpdateApartment()
        {
            if (View.CurrentApartment != null)
            {
                ServiceResponce result = _service.UpdateApartment(View.CurrentApartment);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadApartments();
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
        private void LoadApartments()
        {
            Apartment apartment = new Apartment()
            {
                FloorId = currentFloor.FloorId
            };
            _service.ApartmentsList = _service.GetApartments(apartment);
            View.ApartmentDataSource = _service.ApartmentsList;
        }
    }
}
