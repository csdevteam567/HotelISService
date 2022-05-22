#region Copyright SoftComputer Consultants 2006
// 
// This module is part of the Hotel Information System 
// Copyright (c) Soft Computer Consultants, Inc.  2006 
//    All Rights Reserved 
// This document contains unpublished, confidential and proprietary  
// information of Soft Computer Consultants, Inc. No disclosure or use of  
// any portion of the contents of these materials may be made without the  
// express written consent of Soft Computer Consultants, Inc. 
//  
// Author:       Dmytro Mykhalskyi
// Description:  Hotel Information System is intended to automatize hotel management and to store
// hotel management information.   
// 
// Caution: -      
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using HotelISDTO;

namespace HotelISService
{
    /// <summary> 
    /// Objects of this class validate Dto objects. 
    /// </summary> 
    /// <remarks>  
    /// </remarks>
    public class DtoValidator
    {
        /// <summary>
        /// Checks UserDto fields validation
        /// </summary>
        /// <param name="user"> user to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateUser(UserDto user)
        {
            ServiceResponceDto result = new ServiceResponceDto();

            result.IsOperationSuccessful = true;
            try
            {
                if (!Regex.IsMatch(user.FirstName, "^[A-Z]{1}[a-z]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Wrong first name! First name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(user.LastName, "^[A-Z]{1}[a-z]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong last name! Last name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(user.Password, "[0-9A-Za-z]{5,}"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong password! Password must be at least 8 characters long, must contain at least one number, at least one uppercase letter and at least one lowercase letter.";
                }

                if (!(user.Role == 1 || user.Role == 2))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong user role! Must be 1 or 2";
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing: " + ex.Message;
            }

            return result;
        }

        /// <summary>
        /// Checks GuestDto fields validation
        /// </summary>
        /// <param name="guest"> guest to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateGuest(GuestDto guest)
        {
            ServiceResponceDto result = new ServiceResponceDto();

            result.IsOperationSuccessful = true;

            try
            {
                if (!Regex.IsMatch(guest.FirstName, "^[A-Z]{1}[a-z]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Wrong first name! First name doesn`t match pattern.";
                }

                if (!Regex.IsMatch(guest.LastName, "^[A-Z]{1}[a-z]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong last name! Last name doesn`t match pattern.";
                }
                
                if (!string.IsNullOrEmpty(guest.MiddleName) && guest.MiddleName != "N/A" && !Regex.IsMatch(guest.MiddleName, "^[A-Z]{1}[a-z]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong middle name! Middle name doesn`t match pattern.";
                }
                
                if (!Regex.IsMatch(guest.Email, @"^[a-z]+@+[a-z]+\.+[a-z]{2,4}$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong email! Email doesn`t match pattern.";
                }
                
                if (!Regex.IsMatch(guest.Phone, @"^\+?[0-9\-]+[0-9]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong phone number! Phone contains forbidden symbols.";
                }
                
                if (guest.DateOfBirth >= System.DateTime.Today)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Date of birth can`t be in the future.";
                }
                
                if (string.IsNullOrEmpty(guest.PassportNumber))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong passport number";
                }

                if(result.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {
                            var query = db.Guests.Where(g => g.PassportNumber == guest.PassportNumber && g.Id != guest.GuestId);
                            if (query.Count() > 0)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "Guest with this passport id is already exist.";
                            }
                        }
                        catch (Exception ex)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "DB error: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing." + ex.Message;
            }

            if (string.IsNullOrEmpty(guest.MiddleName))
            {
                guest.MiddleName = "N/A";
            }

            return result;
        }

        /// <summary>
        /// Checks CountryDto fields validation
        /// </summary>
        /// <param name="country"> country to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateCountry(CountryDto country)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            if (!Regex.IsMatch(country.CountryName, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
            {
                result.IsOperationSuccessful = false;
                result.Message = "Wrong country name! Country name doesn`t match pattern.";
            }
            else
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query = db.Countries.Where(c => c.Name == country.CountryName && c.Id != country.CountryId);
                        if (query.Count() > 0)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "This country is already exist";
                        }
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Error during DB query execution" + ex.Message;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Checks CityDto fields validation
        /// </summary>
        /// <param name="city"> city to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateCity(CityDto city)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            try
            {
                if (!Regex.IsMatch(city.CityName, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Wrong city name! City name doesn`t match pattern.";
                }

                if (city.CountryId < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "City must be bound to the country";
                }
                
                if(result.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {
                            var country = from c in db.Countries
                                          where c.Id == city.CountryId
                                          select c;
                            if (country.Count() < 1)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "Country doesn`t exist";
                            }
                            else
                            {
                                var query = db.Cities.Where(c => c.Name == city.CityName && c.CountryId == city.CountryId && c.Id != city.CityId);
                                if (query.Count() > 0)
                                {
                                    result.IsOperationSuccessful = false;
                                    result.Message = "This city is already exist";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "Error during DB query execution" + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing:" + ex.Message;
            }

            return result;
        }

        /// <summary>
        /// Checks HotelDto fields validation
        /// </summary>
        /// <param name="hotel"> hotel to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateHotel(HotelDto hotel)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            if (!Regex.IsMatch(hotel.Name, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
            {
                result.IsOperationSuccessful = false;
                result.Message = "Wrong hotel name! Hotel name doesn`t match pattern.";
            }

            if (!(hotel.Rating >= 2 && hotel.Rating <=5))
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "Wrong rating value! Rating value must be between 2 and 5.";
            }

            if (hotel.MaxFloorsCount < 1)
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "Wrong floors number";
            }
            
            if(result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var city = from c in db.Cities
                                   where c.Id == hotel.CityId
                                   select c;
                        if (city.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = string.Format("No such city");
                        }
                        else
                        {
                            var checkQuery = from h in db.Hotels
                                             join ci in db.Cities on h.CityId equals ci.Id
                                             where h.Name == hotel.Name &&
                                             ci.CountryId == hotel.CountryId &&
                                             h.Id != hotel.HotelId
                                             select h;
                            if (checkQuery.Count() > 0)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = string.Format("Fail: hotel with the same name in the same country is exsisted.");
                            }
                            else
                            {
                                var restaurants = from r in db.Restaurants
                                                  where r.Hotel.Id == hotel.HotelId
                                                  select r;
                                if(hotel.Rating >= 4 && restaurants.Count() < 1)
                                {
                                    result.IsOperationSuccessful = false;
                                    result.Message = string.Format("Fail: hotel with rating more than 3 stars must have restaurant. Add restaurant first, than update rating");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Error during DB query execution" + ex.Message;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Checks ApartmentDto fields validation
        /// </summary>
        /// <param name="apartment"> apartment to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateApartment(ApartmentDto apartment)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            if (apartment.FloorNumber < 1)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Wrong floor number!";
            }

            if (apartment.HasStatusVip && apartment.FloorNumber < 2)
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "VIP apartment can`t be on the first floor!";
            }

            if (apartment.RoomsNumber < 1)
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "Wrong rooms number!";
            }

            if (apartment.MaxCapacity < 1)
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "Wrong apartment max capacity!";
            }

            if (apartment.Price == 0)
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "Wrong price! Price must be more than 0";
            }

            if (result.IsOperationSuccessful)
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
                            result.IsOperationSuccessful = false;
                            result.Message = "No such floor";
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
                                result.IsOperationSuccessful = false;
                                result.Message = string.Format("Failed: The room with this number is already exist.");
                            }
                            else
                            {
                                var floor = db.Floors.Where(f => f.Id == apartment.FloorId).First();
                                var apts = db.Apartments.Where(ap => ap.FloorId == floor.Id && ap.Id != apartment.ApartmentId);

                                if (apts.Count() >= floor.MaxApartments)
                                {
                                    result.IsOperationSuccessful = false;
                                    result.Message = string.Format("This floor has reached its maximum capacity.");
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
                                        result.IsOperationSuccessful = false;
                                        result.Message = string.Format("Fail: The VIP room can`t be in the hotel less than 5 stars.");
                                    }
                                    else if (apartment.HasStatusVip)
                                    {
                                        var similarApartment = (from a in db.Apartments
                                                                join f in db.Floors on a.FloorId equals f.Id
                                                                where a.RoomsNumber == apartment.RoomsNumber &&
                                                                a.MaxCapacity == apartment.MaxCapacity &&
                                                                !a.TypeVip &&
                                                                f.Id == apartment.FloorId &&
                                                                a.Id != apartment.ApartmentId
                                                                select a).First();

                                        if (apartment.Price < similarApartment.Price + (similarApartment.Price * 0.4))
                                        {
                                            result.IsOperationSuccessful = false;
                                            result.Message = string.Format("Fail: The room with VIP status must have price higher than similar not VIP room.");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Error during query execution: " + ex.Message;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Checks RestaurantDto fields validation
        /// </summary>
        /// <param name="restaurant"> restaurant to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateRestaurant(RestaurantDto restaurant)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            if (!Regex.IsMatch(restaurant.Name, @"^[A-Z]{1}\s*[A-Za-z\s]+$"))
            {
                result.IsOperationSuccessful = false;
                result.Message = "Wrong restaurant name! Restaurant name doesn`t match pattern.";
            }

            if (restaurant.HotelId < 1)
            {
                result.IsOperationSuccessful = false;
                result.Message += Environment.NewLine + "Restaurant must be bound to the hotel.";
            }

            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var hotel = db.Hotels.Where(h => h.Id == restaurant.HotelId);
                        if (hotel.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such hotel.";
                        }
                        else
                        {
                            var query = db.Restaurants.Where(r => r.Name == restaurant.Name && r.HotelId == restaurant.HotelId && r.Id != restaurant.RestaurantId);
                            if (query.Count() > 0)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "Restaurant with given name is already exist!";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "DB error: " + ex.Message;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Checks OrderDto fields validation
        /// </summary>
        /// <param name="order"> order to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateOrder(OrderDto order)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;
            try
            {
                if (order.HotelId < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Order must be bound to the hotel.";
                }

                if (order.GuestId < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Order must be bound to the guest ordered it.";
                }
                if (!Regex.IsMatch(order.UserLogin, "^[A-Z]{1}[a-z]+[0-9]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Order must be bound to the user created it.";
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing: " + ex.Message;
            }

            return result;
        }

        /// <summary>
        /// Checks MenuDto fields validation
        /// </summary>
        /// <param name="menu"> menu to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateMenu(MenuDto menu)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            try
            {
                if (!Regex.IsMatch(menu.DishName, @"^[A-Z]{1}\s*[A-Za-z0-9\s]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Wrong dish name! Dish name contains forbidden symbols.";
                }

                if (menu.Price == 0)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Price can`t be 0";
                }

                if (menu.RestaurantId < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Menu should be bound to the restaurant";
                }

                if (result.IsOperationSuccessful)
                {
                    using (var db = new HotelISDBContainer())
                    {
                        try
                        {
                            var restaurant = from r in db.Restaurants
                                             where r.Id == menu.RestaurantId
                                             select r;
                            if (restaurant.Count() < 1)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "No such restaurant.";
                            }
                            else
                            {
                                var query = db.Menus.Where(m => m.DishName == menu.DishName && m.RestaurantId == menu.RestaurantId && m.Id != menu.DishId);
                                if (query.Count() > 0)
                                {
                                    result.IsOperationSuccessful = false;
                                    result.Message = "This entry is already exist.";
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "Error during db query executing: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing." + ex.Message;
            }

            return result;
        }

        /// <summary>
        /// Checks OrderedDishDto fields validation
        /// </summary>
        /// <param name="orderedDish"> ordered dish to check validation </param>
        /// <returns> validation result as a server responce </returns>
        public ServiceResponceDto ValidateOrderedDish(OrderedDishDto orderedDish)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;

            if (orderedDish.OrderId < 1)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Restaurant order must be bound to the hotel order";
            }
            return result;
        }

        public ServiceResponceDto ValidateLogin(LoginDto login)
        {
            ServiceResponceDto result = new ServiceResponceDto();

            result.IsOperationSuccessful = true;
            try
            {
                if (!Regex.IsMatch(login.Login, "^[A-Z]{1}[a-z]+[0-9]+$"))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Wrong login! Login doesn`t match pattern.";
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing: " + ex.Message;
            }

            return result;
        }

        public ServiceResponceDto ValidateFloor(FloorDto floor)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result.IsOperationSuccessful = true;
            try
            {
                if (floor.HotelId < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Wrong Hotel!";
                }

                if (floor.FloorNum < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Wrong Floor number!";
                }

                if (floor.MaxApartments < 1)
                {
                    result.IsOperationSuccessful = false;
                    result.Message += Environment.NewLine + "Max apartment value cant be 0!";
                }

                if (result.IsOperationSuccessful)
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
                                result.IsOperationSuccessful = false;
                                result.Message = string.Format("No such hotel.");
                            }
                            else
                            {
                                var floors = from f in db.Floors
                                             where f.HotelId == floor.HotelId
                                             select f;
                                if (floors.Count() >= hotel.First().MaxFloorsCount)
                                {
                                    result.IsOperationSuccessful = false;
                                    result.Message = string.Format("Floors count reached its maximum value.");
                                }
                                else
                                {
                                    floors = from f in floors
                                             where f.FloorNum == floor.FloorNum
                                             select f;
                                    if (floors.Count() > 0)
                                    {
                                        result.IsOperationSuccessful = false;
                                        result.Message = string.Format("Floor is already exist.");
                                    }
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "DB error: " + ex.Message;
                        }
                     }
                }
            }
            catch (Exception ex)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Some data fields are missing: " + ex.Message;
            }

            return result;
        }

        public ServiceResponceDto ValidateOrderedApartment(OrderedApartmentDto orderedApartment)
        {
            ServiceResponceDto result = new ServiceResponceDto()
            {
                IsOperationSuccessful = true
            };

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var duplicate = from oa in db.OrderedApartments
                                    join g in db.Guests on oa.GuestId equals g.Id
                                    where oa.ApartmentId == orderedApartment.ApartmentId &&
                                    g.PassportNumber == orderedApartment.GuestPassportNumber &&
                                    oa.OrderId == orderedApartment.OrderId
                                    select oa;
                    if (duplicate.Count() > 0)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Guest is already checked-in.";
                    }
                    else
                    {
                        var occupiedAppartment = from oa in db.OrderedApartments
                                                 where oa.ApartmentId == orderedApartment.ApartmentId &&
                                                 oa.ActualDepartureDate > DateTime.Now &&
                                                 oa.OrderId != orderedApartment.OrderId
                                                 select oa;

                        if (occupiedAppartment.Count() > 0)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "This appartment is already occupied.";
                        }
                        else
                        {
                            var checkedIn = from oa in db.OrderedApartments
                                            join g in db.Guests on oa.GuestId equals g.Id
                                            where g.PassportNumber == orderedApartment.GuestPassportNumber &&
                                            oa.ActualDepartureDate >= DateTime.Now
                                            select oa;
                            if (checkedIn.Count() > 0)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "Guest is already checked-in.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Error during db query executing: " + ex.Message;
                }
            }

            return result;
        }
    }
}
