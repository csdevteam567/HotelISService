using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class ApartmentDataService: IApartmentDataService
    {
        public List<Apartment> GetApartments(Apartment apartment)
        {
            List<Apartment> result = new List<Apartment>();

            try
            {
                var dtoResult = HotelService.Client.GetApartments(new ApartmentDto()
                {
                    FloorId = apartment.FloorId
                });

                foreach(var ap in dtoResult)
                {
                    result.Add(new Apartment() 
                    {
                        ApartmentId = ap.ApartmentId,
                        CityName = ap.CityName,
                        CountryName = ap.CountryName,
                        FloorId = ap.FloorId,
                        FloorNumber = ap.FloorNumber,
                        HasStatusVip = ap.HasStatusVip,
                        HotelId = ap.HotelId,
                        HotelName = ap.HotelName,
                        MaxCapacity = ap.MaxCapacity,
                        Number = ap.Number,
                        Price = ap.Price,
                        RoomsNumber = ap.RoomsNumber
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertApartment(Apartment apartment)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertApartment(new ApartmentDto()
                {
                    FloorId = apartment.FloorId,
                    FloorNumber = apartment.FloorNumber,
                    HasStatusVip = apartment.HasStatusVip,
                    MaxCapacity = apartment.MaxCapacity,
                    Number = apartment.Number,
                    Price = apartment.Price,
                    RoomsNumber = apartment.RoomsNumber
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

        public ServiceResponce DeleteApartment(Apartment apartment)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteApartment(new ApartmentDto()
                {
                    ApartmentId = apartment.ApartmentId
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

        public ServiceResponce UpdateApartment(Apartment apartment)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateApartment(new ApartmentDto()
                {
                    ApartmentId = apartment.ApartmentId,
                    FloorId = apartment.FloorId,
                    FloorNumber = apartment.FloorNumber,
                    HasStatusVip = apartment.HasStatusVip,
                    MaxCapacity = apartment.MaxCapacity,
                    Number = apartment.Number,
                    Price = apartment.Price,
                    RoomsNumber = apartment.RoomsNumber
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

        List<Apartment> IApartmentDataService.ApartmentsList { get; set; }
    }
}
