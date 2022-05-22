using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class HotelDataService : IHotelDataService
    {
        public List<Hotel> GetHotels(Hotel hotel)
        {
            List<Hotel> result = new List<Hotel>();

            try
            {
                if (hotel == null)
                {
                    hotel = new Hotel()
                    {
                    };
                }

                var dtoResult = HotelService.Client.GetHotels(new HotelDto()
                {
                    CityId = hotel.CityId,
                    CityName = hotel.CityName,
                    CountryId = hotel.CountryId,
                    CountryName = hotel.CountryName,
                    HotelId = hotel.HotelId,
                    MaxFloorsCount = hotel.MaxFloorsCount,
                    Name = hotel.HotelName,
                    Rating = hotel.Rating
                });

                foreach(var ho in dtoResult)
                {
                    result.Add(new Hotel() 
                    {
                        CityId = ho.CityId,
                        CityName = ho.CityName,
                        CountryId = ho.CountryId,
                        CountryName = ho.CountryName,
                        HotelId = ho.HotelId,
                        HotelName = ho.Name,
                        MaxFloorsCount = ho.MaxFloorsCount,
                        Rating = ho.Rating
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertHotel(Hotel hotel)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertHotel(new HotelDto()
                {
                    CityId = hotel.CityId,
                    CityName = hotel.CityName,
                    CountryId = hotel.CountryId,
                    CountryName = hotel.CountryName,
                    HotelId = hotel.HotelId,
                    MaxFloorsCount = hotel.MaxFloorsCount,
                    Name = hotel.HotelName,
                    Rating = hotel.Rating
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

        public ServiceResponce DeleteHotel(Hotel hotel)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteHotel(new HotelDto()
                {
                    HotelId = hotel.HotelId
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

        public ServiceResponce UpdateHotel(Hotel hotel)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateHotel(new HotelDto()
                {
                    HotelId = hotel.HotelId,
                    CityId = hotel.CityId,
                    MaxFloorsCount = hotel.MaxFloorsCount,
                    Name = hotel.HotelName,
                    Rating = hotel.Rating
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

        public List<Hotel> HotelsList { get; set; }
        public List<City> CitiesList { get; set; }
        public List<Country> CountriesList { get; set; }
    }
}
