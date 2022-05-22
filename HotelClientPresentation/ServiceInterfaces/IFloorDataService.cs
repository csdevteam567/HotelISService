using System;
using System.Collections.Generic;
using HotelClientModel;

namespace HotelClientPresentation
{
    public interface IFloorDataService
    {
        List<Floor> FloorsList { get; set; }
        List<Floor> GetFloors(Floor floor);
        ServiceResponce InsertFloor(Floor floor);
        ServiceResponce DeleteFloor(Floor floor);
        ServiceResponce UpdateFloor(Floor floor);
    }
}
