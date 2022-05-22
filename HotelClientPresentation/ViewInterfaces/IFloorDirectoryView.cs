using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IFloorDirectoryView: IView
    {
        List<Floor> FloorsDataSource { get; set; }

        Floor CurrentFloor { get; }

        int TableRowCount { get; }
        int MaxApartmentsCount { get; set; }
        int FloorNumber { get; set; }
        string HotelName { get; set; }
        bool AdminControls { set; }

        event Action AddFloor;
        event Action DeleteFloor;
        event Action UpdateFloor;
        event Action LoadFloors;
        event Action AddApartments;

        void ShowError(string errorMessage);
    }
}
