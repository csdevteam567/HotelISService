using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class FloorDataService: IFloorDataService
    {
        public List<Floor> GetFloors(Floor floor)
        {
            List<Floor> result = new List<Floor>();

            try
            {
                var dtoResult = HotelService.Client.GetFloors(new FloorDto()
                {
                    HotelId = floor.HotelId
                });

                foreach(var fl in dtoResult)
                {
                    result.Add(new Floor() 
                    {
                        FloorId = fl.FloorId,
                        FloorNum = fl.FloorNum,
                        HotelId = fl.HotelId,
                        HotelName = fl.HotelName,
                        MaxApartments = fl.MaxApartments
                    });
                }
            }
            catch(Exception ex)
            {
                
            }
            return result;
        }

        public ServiceResponce InsertFloor(Floor floor)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertFloor(new FloorDto()
                {
                    FloorNum = floor.FloorNum,
                    HotelId = floor.HotelId,
                    MaxApartments = floor.MaxApartments
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce DeleteFloor(Floor floor)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteFloor(new FloorDto()
                {
                    FloorId = floor.FloorId
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce UpdateFloor(Floor floor)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateFloor(new FloorDto()
                {
                    FloorId = floor.FloorId,
                    HotelId = floor.HotelId,
                    FloorNum = floor.FloorNum,
                    MaxApartments = floor.MaxApartments
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        List<Floor> IFloorDataService.FloorsList { get; set; }
    }
}
