using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    public class OrderDtoValidator
    {
        public ServiceResponceDto ValidationResult { get; private set; }

        public Order Validate(OrderDto order)
        {
            Order result = null;
            ValidationResult.IsOperationSuccessful = true;

            try
            {
                if (order.HotelId < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "Order must be bound to the hotel.";
                }

                if (order.GuestId < 1)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Order must be bound to the guest ordered it.";
                }

                if (!Regex.IsMatch(order.UserLogin, "^[A-Z]{1}[a-z]+[0-9]+$"))
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message += Environment.NewLine + "Order must be bound to the user created it.";
                }
            }
            catch (Exception ex)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Some data fields are missing: " + ex.Message;
            }
            
            if(ValidationResult.IsOperationSuccessful)
            {
                int idU = int.Parse(Regex.Match(order.UserLogin, "[0-9]+").Value);
                result = new Order()
                {
                    HotelId = order.HotelId,
                    GuestId = order.GuestId,
                    Id = order.Id,
                    UserId = idU,
                    OrderDate = order.OrderDate,
                };
            }

            return result;
        }
    }
}