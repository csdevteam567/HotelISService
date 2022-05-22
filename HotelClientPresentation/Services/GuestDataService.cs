using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientPresentation.RelationsServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class GuestDataService: IGuestDataService
    {
        public List<Guest> GetGuests(GuestSearchCriteriaDto guest)
        {
            List<Guest> result = new List<Guest>();

            try
            {
                if (guest == null)
                {
                    guest = new GuestSearchCriteriaDto();
                }
                var dtoResult = HotelService.Client.GetGuests(guest);

                foreach(var gt in dtoResult)
                {
                    result.Add(new Guest() 
                    {
                        GuestId = gt.GuestId,
                        PassportNumber = gt.PassportNumber,
                        FirstName = gt.FirstName,
                        LastName = gt.LastName,
                        MiddleName = gt.MiddleName,
                        Sex = gt.Sex,
                        Phone = gt.Phone,
                        StatusVip = gt.StatusVip,
                        DateOfBirth = gt.DateOfBirth,
                        Email = gt.Email,
                        Discount = gt.Discount,
                        FamilyName = gt.FamilyName
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertGuest(Guest guest)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertGuest(new GuestDto()
                {
                    PassportNumber = guest.PassportNumber,
                    FirstName = guest.FirstName,
                    LastName = guest.LastName,
                    MiddleName = guest.MiddleName,
                    Sex = guest.Sex,
                    FamilyName = guest.FamilyName,
                    Phone = guest.Phone,
                    Email = guest.Email,
                    DateOfBirth = guest.DateOfBirth
                    //StatusVip = guest.StatusVip
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

        public ServiceResponce DeleteGuest(Guest guest)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteGuest(new GuestDto()
                {
                    GuestId = guest.GuestId,
                    PassportNumber = guest.PassportNumber
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

        public ServiceResponce UpdateGuest(Guest guest)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateGuest(new GuestDto()
                {
                    GuestId = guest.GuestId,
                    PassportNumber = guest.PassportNumber,
                    FirstName = guest.FirstName,
                    LastName = guest.LastName,
                    MiddleName = guest.MiddleName,
                    FamilyName = guest.FamilyName,
                    Sex = guest.Sex,
                    Phone = guest.Phone,
                    Email = guest.Email,
                    DateOfBirth = guest.DateOfBirth
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

        public List<Guest> GuestsList { get; set; }
        public List<Country> CountriesList { get; set; }
        public List<City> CitiesList { get; set; }
        public List<Hotel> HotelsList { get; set; }
    }
}
