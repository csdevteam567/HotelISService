using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class ApartmentDtoValidator
    {
        private ServiceResponceDto validationResult;

        public ServiceResponceDto ValidationResult 
        {
            get
            {
                return validationResult;
            }
            private set
            {
                validationResult = value;
            }
        }

        public ApartmentDtoValidator()
        {
            validationResult = new ServiceResponceDto();
        }

        public bool ValidateFields(ApartmentDto apartment)
        {
            bool reslt = true;

            if (apartment.FloorNumber < 1)
            {
                //ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Wrong floor number!";
                reslt = false;
            }

            if (apartment.HasStatusVip && apartment.FloorNumber < 2)
            {
                //ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "VIP apartment can`t be on the first floor!";
                reslt = false;
            }

            if (apartment.RoomsNumber < 1)
            {
                //ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "Wrong rooms number!";
                reslt = false;
            }

            if (apartment.MaxCapacity < 1)
            {
                //ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "Wrong apartment max capacity!";
                reslt = false;
            }

            if (apartment.Price == 0)
            {
                //ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message += Environment.NewLine + "Wrong price! Price must be more than 0";
                reslt = false;
            }

            return reslt;
        }

        public Apartment Validate(ApartmentDto apartment)
        {
            Apartment result = null;
            ValidationResult.IsOperationSuccessful = ValidateFields(apartment);

            if (ValidationResult.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var floors = from f in db.Floors
                                     where f.Id == apartment.FloorId
                                     select f;
                        if (floors.Count() < 1)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "No such floor";
                        }
                        else
                        {
                            var checkQuery = from a in db.Apartments
                                             join f in db.Floors on a.FloorId equals f.Id
                                             where a.Number == apartment.Number &&
                                             a.Id != apartment.ApartmentId &&
                                             f.Id == apartment.FloorId
                                             select a;

                            if (checkQuery.Count() > 0)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = string.Format("Failed: The room with this number is already exist.");
                            }
                            else
                            {
                                var floor = db.Floors.Where(f => f.Id == apartment.FloorId).First();
                                var apts = db.Apartments.Where(ap => ap.FloorId == floor.Id && ap.Id != apartment.ApartmentId);

                                if (apts.Count() >= floor.MaxApartments)
                                {
                                    ValidationResult.IsOperationSuccessful = false;
                                    ValidationResult.Message = string.Format("This floor has reached its maximum capacity.");
                                }
                                else
                                {
                                    //var hotel = db.Hotels.Where(h => h.Id == apartment.HotelId).First();
                                    var hotel = (from h in db.Hotels
                                                 join f in db.Floors on h.Id equals f.HotelId
                                                 where f.Id == apartment.FloorId
                                                 select h).First();
                                    if (apartment.HasStatusVip && hotel.Rating < 5)
                                    {
                                        ValidationResult.IsOperationSuccessful = false;
                                        ValidationResult.Message = string.Format("Fail: The VIP room can`t be in the hotel less than 5 stars.");
                                    }
                                    else if (apartment.HasStatusVip)
                                    {
                                        var similarApartment = (from a in db.Apartments
                                                                join f in db.Floors on a.FloorId equals f.Id
                                                                where a.RoomsNumber == apartment.RoomsNumber &&
                                                                a.MaxCapacity == apartment.MaxCapacity &&
                                                                !a.TypeVip &&
                                                                f.Id == apartment.FloorId
                                                                select a).First();

                                        if (apartment.Price < similarApartment.Price + (similarApartment.Price * 0.4))
                                        {
                                            ValidationResult.IsOperationSuccessful = false;
                                            ValidationResult.Message = string.Format("Fail: The room with VIP status must have price higher than similar not VIP room.");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ValidationResult.IsOperationSuccessful = false;
                        ValidationResult.Message = "Error during query execution: " + ex.Message;
                    }
                }
            }
            
            if(ValidationResult.IsOperationSuccessful)
            {
                result = new Apartment()
                {
                    FloorId = apartment.FloorId,
                    Id = apartment.ApartmentId,
                    MaxCapacity = apartment.MaxCapacity,
                    Number = apartment.Number,
                    Price = apartment.Price,
                    RoomsNumber = apartment.RoomsNumber,
                    TypeVip = apartment.HasStatusVip
                };
            }

            return result;
        }
    }
}