using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class FloorDirectoryPresenter : BasePresener<IFloorDirectoryView, Hotel, LoginResult>
    {
        private readonly IFloorDataService _service;
        private Hotel currentHotel;
        private LoginResult currentUser;

        public FloorDirectoryPresenter(IApplicationController controller, IFloorDirectoryView view, IFloorDataService service)
            : base(controller, view)
        {
            _service = service;
            View.AddFloor += () => AddFloor();
            View.DeleteFloor += () => DeleteFloor();
            View.UpdateFloor += () => UpdateFloor();
            View.LoadFloors += () => LoadFloors();
            View.AddApartments += () => AddApartments();
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
        private void AddFloor()
        {
            if (View.TableRowCount >= currentHotel.MaxFloorsCount)
            {
                View.ShowError("You can`t add any more floors!");
            }
            else
            {
                if (View.MaxApartmentsCount > 0 && View.FloorNumber > 0)
                {
                    Floor floor = new Floor()
                    {
                        HotelId = currentHotel.HotelId,
                        FloorNum = View.FloorNumber,
                        MaxApartments = View.MaxApartmentsCount
                    };

                    var result = _service.InsertFloor(floor);
                    if (!result.IsOperationSuccessful)
                    {
                        View.ShowError(result.Message);
                    }
                    else
                    {
                        LoadFloors();
                    }
                }
                else
                {
                    View.ShowError("Floor number or apartments count missing");
                }
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteFloor()
        {
            if (View.CurrentFloor != null)
            {
                ServiceResponce result = _service.DeleteFloor(View.CurrentFloor);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadFloors();
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
        private void UpdateFloor()
        {
            if (View.CurrentFloor != null)
            {
                ServiceResponce result = _service.UpdateFloor(View.CurrentFloor);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadFloors();
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
        private void LoadFloors()
        {
            Floor floor = new Floor()
            {
                HotelId = currentHotel.HotelId
            };
            _service.FloorsList = _service.GetFloors(floor);
            View.FloorsDataSource = _service.FloorsList;
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void AddApartments()
        {
            if (View.CurrentFloor != null)
            {
                Controller.Run<ApartmentDirectoryPresenter, Floor, LoginResult>(View.CurrentFloor, currentUser);
            }
            else
            {
                View.ShowError("You should select floor first");
            }
        }
    }
}
