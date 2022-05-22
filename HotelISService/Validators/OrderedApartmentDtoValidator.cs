using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class OrderedApartmentDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public OrderedApartment Validate(OrderedApartmentDto orderedApartment)
        {
            OrderedApartment result = null;
            ValidationResult.IsOperationSuccessful = true;
            int guestId = 0;
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    guestId = (from g in db.Guests
                               where g.PassportNumber == orderedApartment.GuestPassportNumber
                               select g.Id).First();
                    var duplicate = from oa in db.OrderedApartments
                                    join g in db.Guests on oa.GuestId equals g.Id
                                    where oa.ApartmentId == orderedApartment.ApartmentId &&
                                    g.PassportNumber == orderedApartment.GuestPassportNumber &&
                                    oa.OrderId == orderedApartment.OrderId
                                    select oa;
                    if (duplicate.Count() > 0)
                    {
                        ValidationResult.IsOperationSuccessful = false;
                        ValidationResult.Message = "Guest is already checked-in.";
                    }
                    else
                    {
                        var occupiedAppartment = from oa in db.OrderedApartments
                                                 where oa.ApartmentId == orderedApartment.ApartmentId &&
                                                 oa.ActualDepartureDate > DateTime.Today &&
                                                 oa.OrderId != orderedApartment.OrderId
                                                 select oa;

                        if (occupiedAppartment.Count() > 0)
                        {
                            ValidationResult.IsOperationSuccessful = false;
                            ValidationResult.Message = "This appartment is already occupied.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Error during db query executing: " + ex.Message;
                }
            }

            if(ValidationResult.IsOperationSuccessful)
            {

                result = new OrderedApartment()
                {
                    GuestId = guestId,
                    OrderId = orderedApartment.OrderId,
                    ApartmentId = orderedApartment.ApartmentId,
                    ActualDepartureDate = orderedApartment.ActualDepartureDate
                };
            }

            return result;
        }
    }
}