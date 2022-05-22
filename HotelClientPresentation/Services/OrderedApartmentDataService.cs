using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class OrderedApartmentDataService : IOrderedApartmentDataService
    {
        public ServiceResponce OrderApartment(OrderedApartment orderedApt)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.OrderApartment(new OrderedApartmentDto()
                {
                    ApartmentId = orderedApt.ApartmentId,
                    GuestPassportNumber = orderedApt.GuestPassportNumber,
                    OrderId = orderedApt.OrderId,
                    ActualDepartureDate = orderedApt.ActualDepartureDate,
                    CountryName = orderedApt.CountryName,
                    HotelName = orderedApt.HotelName
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
            }
            catch (Exception ex)
            {
                //Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce CheckOutGuest(OrderedApartment orderedApt)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.CheckOutGuest(new OrderedApartmentDto()
                {
                    ApartmentId = orderedApt.ApartmentId,
                    GuestPassportNumber = orderedApt.GuestPassportNumber,
                    OrderId = orderedApt.OrderId,
                    //ActualDepartureDate = orderedApt.ActualDepartureDate
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

        public List<OrderedApartment> GetOrderedApartments(OrderedApartment orderedApt)
        {
            List<OrderedApartment> result = new List<OrderedApartment>();

            try
            {
                var dtoResult = HotelService.Client.GetOrderedApartments(new OrderedApartmentDto()
                {
                    OrderId = orderedApt.OrderId,
                    CountryName = orderedApt.CountryName,
                    CityName = orderedApt.CityName,
                    HotelName = orderedApt.HotelName,
                    FloorNumber = orderedApt.FloorNumber
                });

                foreach (var oa in dtoResult)
                {
                    result.Add(new OrderedApartment()
                    {
                        ActualDepartureDate = oa.ActualDepartureDate,
                        ApartmentId = oa.ApartmentId,
                        ApartmentNumber = oa.ApartmentNumber,
                        CityName = oa.CityName,
                        CountryName = oa.CountryName,
                        FloorNumber = oa.FloorNumber,
                        GuestFirstName = oa.GuestFirstName,
                        GuestLastName = oa.GuestLastName,
                        GuestPassportNumber = oa.GuestPassportNumber,
                        HotelName = oa.HotelName,
                        OrderId = oa.OrderId
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }


        public ServiceResponce DeleteOrderedApartment(OrderedApartment orderedApt)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteOrderedApartment(new OrderedApartmentDto()
                {
                    ApartmentId = orderedApt.ApartmentId,
                    GuestPassportNumber = orderedApt.GuestPassportNumber,
                    OrderId = orderedApt.OrderId,
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

        public List<OrderedApartment> OrderedApartmentsList { get; set; }
        public List<Guest> GuestsList { get; set; }
        public List<Apartment> AvailableApartmentsList { get; set; }
    }
}
