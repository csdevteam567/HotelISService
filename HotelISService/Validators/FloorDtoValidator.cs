using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class FloorDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Floor Validate(FloorDto floor)
        {
            Floor result = null;
            ValidationResult.IsOperationSuccessful = true;

            try
            {
                if (floor.HotelId < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Wrong Hotel!";
                }

                if (floor.FloorNum < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Wrong Floor number!";
                }

                if (floor.MaxApartments < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Max apartment value cant be 0!";
                }

                if (ValidationResult.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {

                            var hotel = from h in db.Hotels
                                        where h.Id == floor.HotelId
                                        select h;
                            if (hotel.Count() < 1)
                            {
                                ValidationResult.IsOperationSuccessful = false;
                                ValidationResult.Message = string.Format("No such hotel.");
                            }
                            else
                            {
                                var floors = from f in db.Floors
                                             where f.HotelId == floor.HotelId
                                             select f;
                                if (floors.Count() >= hotel.First().MaxFloorsCount)
                                {
                                    ValidationResult.IsOperationSuccessful = false;
                                    ValidationResult.Message = string.Format("Floors count reached its maximum value.");
                                }
                                else
                                {
                                    floors = from f in floors
                                             where f.FloorNum == floor.FloorNum
                                             select f;
                                    if (floors.Count() > 0)
                                    {
                                        ValidationResult.IsOperationSuccessful = false;
                                        ValidationResult.Message = string.Format("Floor is already exist.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "DB error: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Some data fields are missing: " + ex.Message;
            }

            
            if(ValidationResult.IsOperationSuccessful)
            {
                result = new Floor()
                {
                    FloorNum = floor.FloorNum,
                    HotelId = floor.HotelId,
                    Id = floor.FloorId,
                    MaxApartments = floor.MaxApartments
                };
            }

            return result;
        }
    }
}