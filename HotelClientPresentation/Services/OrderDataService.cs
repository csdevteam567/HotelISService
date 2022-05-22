using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class OrderDataService: IOrderDataService
    {
        public List<Order> GetOrders(OrderSearchCriteria filter)
        {
            List<Order> result = new List<Order>();

            try
            {
                var dtoResult = HotelService.Client.GetOrders(new OrderSearchCriteriaDto()
                {
                    CityName = filter.CityName,
                    CountryName = filter.CountryName,
                    GuestPassportNumber = filter.GuestPassportNumber,
                    HotelName = filter.HotelName,
                    UserLogin = filter.UserLogin
                });

                foreach(var or in dtoResult)
                {
                    result.Add(new Order() 
                    {
                        GuestFirstName = or.GuestFirstName,
                        GuestLastName = or.GuestLastName,
                        GuestId = or.GuestId,
                        PassportNumber = or.PassportNumber,
                        CityName = or.CityName,
                        CountryName = or.CountryName,
                        HotelName = or.HotelName,
                        Id = or.Id,
                        OrderDate = or.OrderDate,
                        Total = or.Total,
                        UserLogin = or.UserLogin
                    });
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public ServiceResponce InsertOrder(Order order)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.InsertOrder(new OrderDto()
                {
                    OrderDate = order.OrderDate,
                    UserLogin = order.UserLogin,
                    HotelId = order.HotelId,
                    GuestId = order.GuestId,
                    ApartmentId = order.ApartmentId,
                    DepartureDate = order.DepartureDate 
                });

                result.IsOperationSuccessful = resultDto.IsOperationSuccessful;
                result.Message = resultDto.Message;
                result.EntryId = resultDto.EntryId;
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce DeleteOrder(Order order)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.DeleteOrder(new OrderDto()
                {
                    Id = order.Id
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

        public ServiceResponce UpdateOrder(Order order)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.UpdateOrder(new OrderDto()
                {
                    Id = order.Id,
                    OrderDate = order.OrderDate,
                    UserLogin = order.UserLogin
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

        public ServiceResponce CalculatePrice(Order order)
        {
            ServiceResponce result = new ServiceResponce();
            try
            {
                var resultDto = HotelService.Client.CalculateOrderPrice(new OrderDto()
                {
                    Id = order.Id,
                    OrderDate = order.OrderDate,
                    UserLogin = order.UserLogin,
                    GuestId = order.GuestId
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

        public Paycheck CheckoutOrder(Order order)
        {
            Paycheck result = new Paycheck();
            try
            {
                var resultDto = HotelService.Client.CheckOutOrder(new OrderDto()
                {
                    Id = order.Id,
                    GuestId = order.GuestId
                });

                result = new Paycheck()
                {
                    OrderDate = resultDto.OrderDate,
                    CityName = resultDto.CityName,
                    CountryName = resultDto.CountryName,
                    HotelName = resultDto.HotelName,
                    OrderId = resultDto.OrderId,
                    TotalPrice = resultDto.TotalPrice
                };

                List<ApartmentPaycheck> apartmentsInOrder = new List<ApartmentPaycheck>();
                foreach(var ap in resultDto.OrderedApartments)
                {
                    apartmentsInOrder.Add(
                        new ApartmentPaycheck()
                        {
                            ActualDepartureDate = ap.ActualDepartureDate,
                            ApartmentNumber = ap.ApartmentNumber,
                            ApartmentPrice = ap.ApartmentPrice,
                            FloorNumber = ap.FloorNumber,
                            TotalDays = ap.TotalDays,
                            OrderId = ap.OrderId
                        });
                }

                result.OrderedApartments = apartmentsInOrder;

                List<DishInfo> dishesInOrder = new List<DishInfo>();
                foreach (var m in resultDto.OrderedDishes)
                {
                    dishesInOrder.Add(
                        new DishInfo()
                        {
                            DishId = m.DishId,
                            DishName = m.DishName,
                            Price = m.DishPrice
                        });
                }

                result.OrderedDishes = dishesInOrder;

            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }
            return result;
        }

        public List<Country> CountriesList { get; set; }
        public List<City> CitiesList { get; set; }
        public List<Hotel> HotelsList { get; set; }
        public List<Guest> GuestsList { get; set; }
        List<Order> IOrderDataService.OrdersList { get; set; }
        public Paycheck OrderPaycheck { get; set;  }
    }
}
