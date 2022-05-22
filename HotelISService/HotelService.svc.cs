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
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using HotelISDTO;
using System.Data;

namespace HotelISService
{
    /// <summary> 
    /// Object of this class manage client requests. 
    /// </summary> 
    /// <remarks> 
    /// This class relies on the <see cref="IHotelService"/> Interface. 
    /// </remarks> 
    /// <seealso cref="IHotelService"/>
    public class HotelService : IHotelService
    {
        private const int adultAge = 18;

        public HotelService()
        {
            Logger.InitLogger();
            FirstLaunchInit();
        }

        #region Common Methods

        /// <summary>
        /// testing connection
        /// </summary>
        /// <returns> OK </returns>
        public ServiceResponceDto TestConnection()
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query =
                        from usr in db.Users
                        where usr.Id == 1
                        select new User()
                        {
                            Id = usr.Id,
                            FirstName = usr.FirstName,
                            LastName = usr.LastName,
                            Role = usr.Role,
                            Password = usr.Password
                        };
                    result.IsOperationSuccessful = true;
                    result.Message = "Connection OK.";
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Database error" + ex.Message;
                }
            }
            return result;
        }

        /// <summary>
        /// Initializes admin
        /// </summary>
        /// <returns> - </returns>
        private void FirstLaunchInit()
        {
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query = db.Users.Where(u => u.LastName == "Admin" && u.Role == 1);
                    if(query.Count() < 1)
                    {
                        var admin = new User()
                        {
                            FirstName = "Admin",
                            LastName = "Admin",
                            Role = 1,
                            Password = "admin"
                        };
                        db.Users.Add(admin);
                        db.SaveChanges();
                        Logger.Log.Info(string.Format("User created {0}{1}", admin.LastName, admin.Id));
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("Database error while creating admin user: " + ex.Message);
                }
            }
        }

        #endregion

        #region Users
        /// <summary>
        /// Checks user authorization
        /// </summary>
        /// <param name="user"> user to check authorization </param>
        /// <returns> LoginResult </returns>
        public LoginResultDto AuthorizeUzer(LoginDto login)
        {
            LoginResultDto result = new LoginResultDto();
            DtoValidator validator = new DtoValidator();
            var valResult = validator.ValidateLogin(login);
            if (valResult.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        int idU = int.Parse(Regex.Match(login.Login, "[0-9]+").Value);
                        string lastName = Regex.Match(login.Login, "[A-Za-z]+").Value;
                        Logger.Log.Info(string.Format("User id: {0}", idU));
                        List<User> query =
                            (from usr in db.Users
                             where usr.Id == idU &&
                             usr.LastName == lastName
                             select usr).ToList();
                        if (query.Count() < 1)
                        {
                            //result.IsLoginSuccessful = false;
                            result.UserId = 0;
                            result.Message = "No such user";
                            Logger.Log.Info(string.Format("Error during user {0} Log-in; password {1}: {2}", login.Login, login.Password, result.Message));
                        }
                        else
                        {
                            if (query.SingleOrDefault().Password == login.Password)
                            {
                                //result.IsLoginSuccessful = true;
                                result.UserId = query.Last().Id;
                                result.Message = "User successfuly logged-in";
                                result.UserLogin = string.Format(query.Last().LastName + query.Last().Id);
                                result.UserRole = query.Last().Role;
                                Logger.Log.Info("User Logged-in: " + result.Message);
                            }
                            else
                            {
                                //result.IsLoginSuccessful = false;
                                //result.UserId = query.Last().Id;
                                result.UserId = 0;
                                result.Message = "Incorrect password";
                                Logger.Log.Error(string.Format("Error during user {0} Log-in; password {1}: {2}", login.Login, login.Password, result.Message));
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        //result.IsLoginSuccessful = false;
                        result.UserId = 0;
                        result.Message = "DB error: " + ex.Message;
                        Logger.Log.Fatal(string.Format("Error during user {0} Log-in; password {1}: {2}", login.Login, login.Password, result.Message));
                    }
                }
            }
            else
            {
                result.UserId = 0;
                result.Message = valResult.Message;
            }
            return result;
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="checkUser"> user to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertUser(UserDto user)
        {
            UserDtoValidator validator = new UserDtoValidator();
            var entry = validator.Validate(user);
            var result = validator.ValidationResult;

            if (entry != null)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        db.Users.Add(entry);
                        db.SaveChanges();

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("User created: {0}{1}", entry.LastName, entry.Id);
                        Logger.Log.Info(result.Message);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }

            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Error("Error during user creation: " + result.Message);
            }

            return result;
        }

        /// <summary>
        /// Updates a user data
        /// </summary>
        /// <param name="user"> user to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateUser(UserDto user)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateUser(user);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        int idU = user.Id;
                        if (idU == 1 && user.Role != 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "You can`t do so";
                        }
                        else
                        {
                            var query =
                                from usr in db.Users
                                where usr.Id == idU
                                select usr;
                            if (query.Count() < 1)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "No such user";
                            }
                            else
                            {
                                User us = query.Single();
                                us.FirstName = user.FirstName;
                                us.LastName = user.LastName;
                                us.Password = user.Password;
                                us.Role = user.Role;
                                db.SaveChanges();
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
        /// Returns Users list
        /// </summary>
        /// <param name="filter">  filter dto with basic user information(Login) to find certain user </param>
        /// <returns> user records list </returns>
        public List<UserDto> GetUsers(UserDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<UserDto> result = new List<UserDto>();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<User> query = db.Users;

                    if (!string.IsNullOrEmpty(filter.FirstName))
                    {
                        query = from u in query
                                where u.FirstName == filter.FirstName
                                select u;
                    }

                    if (!string.IsNullOrEmpty(filter.LastName))
                    {
                        query = from u in query
                                where u.LastName.StartsWith(filter.LastName)
                                select u;
                    }

                    if (filter.Role > 0)
                    {
                        query = from u in query
                                where u.Role == filter.Role
                                select u;
                    }

                    if (filter.Id > 0)
                    {
                        query = from u in query
                                where u.Id == filter.Id
                                select u;
                    }

                    foreach (User u in query)
                    {
                        result.Add(new UserDto()
                        {
                            Id = u.Id,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Role = u.Role,
                            Password = u.Password
                        });
                    }
                }
                catch(Exception ex)
                {
                    Logger.Log.Info("An error occured during searching user entries: " + ex.Message);
                }
            }
            return result;
        }


        /// <summary>
        /// Deletes a user data
        /// </summary>
        /// <param name="user"> user to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteUser(UserDto user)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    int idU = user.Id;
                    var query =
                        from usr in db.Users
                        where usr.Id == idU
                        select usr;
                    if (idU != 1)
                    {
                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such user";
                        }
                        else
                        {
                            User us = query.Single();
                            db.Users.Remove(us);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "You can`t delete super Admin!";
                    }

                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region City
        /// <summary>
        /// Creates new City record
        /// </summary>
        /// <param name="city"> city to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertCity(CityDto city)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateCity(city);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new City()
                        {
                            CountryId = city.CountryId,
                            Name = city.CityName,
                        };
                        db.Cities.Add(entry);
                        db.SaveChanges();

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("City record created: {0}", entry.Name);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("City record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Cities list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Cities list </returns>
        public List<CityDto> GetCities(CityDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<CityDto> result = new List<CityDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<City> query = db.Cities;

                    if (!string.IsNullOrEmpty(filter.CountryName))
                    {
                        query = from c in query
                                join co in db.Countries on c.CountryId equals co.Id
                                where co.Name == filter.CountryName
                                select c;
                    }

                    if (!string.IsNullOrEmpty(filter.CityName))
                    {
                        query = from c in query
                                where c.Name.StartsWith(filter.CityName)
                                select c;
                    }

                    if (filter.CountryId > 0)
                    {
                        query = from c in query
                                where c.CountryId == filter.CountryId
                                select c;
                    }

                    if (filter.CityId > 0)
                    {
                        query = from c in query
                                where c.Id == filter.CityId
                                select c;
                    }

                    foreach (City ct in query)
                    {
                        Country country = db.Countries.Where(c => c.Id == ct.CountryId).First();
                        result.Add(
                            new CityDto()
                            {
                                CityId = ct.Id,
                                CountryName = country.Name,
                                CityName = ct.Name,
                                CountryId = ct.CountryId
                            });
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates city entry data
        /// </summary>
        /// <param name="city"> city entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateCity(CityDto city)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateCity(city);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query =
                            from c in db.Cities
                            where c.Id == city.CityId
                            select c;
                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such city entry";
                        }
                        else
                        {
                            City ct = query.First();
                            ct.Name = city.CityName;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "City entry succesfuly updated";
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
        /// Deletes city entry
        /// </summary>
        /// <param name="city"> city entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteCity(CityDto city)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query =
                        from c in db.Cities
                        where c.Id == city.CityId
                        select c;
                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        db.Cities.Remove(query.First());
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Country
        /// <summary>
        /// Creates new Country record
        /// </summary>
        /// <param name="country"> country to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertCountry(CountryDto country)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateCountry(country);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new Country()
                        {
                            Name = country.CountryName
                        };
                        db.Countries.Add(entry);
                        db.SaveChanges();
                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("Country record created: {0}", entry.Name);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("City record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Countries list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Countries list </returns>
        public List<CountryDto> GetCountries(CountryDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<CountryDto> result = new List<CountryDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Country> query = db.Countries;

                    if (!string.IsNullOrEmpty(filter.CountryName))
                    {
                        query = query.Where(c => c.Name.StartsWith(filter.CountryName));
                    }

                    if (filter.CountryId > 0)
                    {
                        query = query.Where(c => c.Id == filter.CountryId);
                    }

                    foreach (Country co in query)
                    {
                        result.Add(
                            new CountryDto()
                            {
                                CountryId = co.Id,
                                CountryName = co.Name
                            });
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching country entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates country entry data
        /// </summary>
        /// <param name="country"> country entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateCountry(CountryDto country)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateCountry(country);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query =
                            from c in db.Countries
                            where c.Id == country.CountryId
                            select c;
                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such country entry.";
                        }
                        else
                        {
                            Country co = query.Single();
                            co.Name = country.CountryName;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "Country entry succesfuly updated.";
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
        /// Deletes country entry
        /// </summary>
        /// <param name="country"> country entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteCountry(CountryDto country)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query =
                        from c in db.Countries
                        where c.Id == country.CountryId
                        select c;
                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        db.Countries.Remove(query.First());
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Hotel
        /// <summary>
        /// Creates new Country record
        /// </summary>
        /// <param name="hotel"> Hotel to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertHotel(HotelDto hotel)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";
            DtoValidator validator = new DtoValidator();
            result = validator.ValidateHotel(hotel);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new Hotel()
                        {
                            Name = hotel.Name,
                            CityId = hotel.CityId,
                            MaxFloorsCount = hotel.MaxFloorsCount,
                            Rating = hotel.Rating
                        };
                        db.Hotels.Add(entry);
                        db.SaveChanges();

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("Hotel record created: {0}", entry.Name);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during hotel record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("Hotel record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Hotelst list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Hotels list </returns>
        public List<HotelDto> GetHotels(HotelDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<HotelDto> result = new List<HotelDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Hotel> query = db.Hotels;

                    if (!string.IsNullOrEmpty(filter.CountryName))
                    {
                        query = from h in query
                                join ci in db.Cities on h.CityId equals ci.Id
                                join co in db.Countries on ci.CountryId equals co.Id
                                where co.Name == filter.CountryName
                                select h;
                    }

                    if (filter.CountryId > 0)
                    {
                        query = from h in query
                                join ci in db.Cities on h.CityId equals ci.Id
                                where ci.CountryId == filter.CountryId
                                select h;
                    }

                    if (!string.IsNullOrEmpty(filter.CityName))
                    {
                        query = from h in query
                                join ci in db.Cities on h.CityId equals ci.Id
                                where ci.Name == filter.CityName
                                select h;
                    }

                    if (filter.CityId > 0)
                    {
                        query = from h in query
                                where h.CityId == filter.CityId
                                select h;
                    }

                    if (!string.IsNullOrEmpty(filter.Name))
                    {
                        query = from h in query
                                where h.Name.StartsWith(filter.Name)
                                select h;
                    }

                    if (filter.HotelId > 0)
                    {
                        query = from h in query
                                where h.Id == filter.HotelId
                                select h;
                    }

                    if (filter.Rating > 0)
                    {
                        query = from h in query
                                where h.Rating == filter.Rating
                                select h;
                    }

                    foreach (Hotel ho in query)
                    {
                        //List<int> aptsPerFloor = (from f in db.Floors
                        //                         where f.HotelId == ho.Id
                        //                         orderby f.FloorNum ascending
                        //                         select f.MaxApartments).ToList();
                        var hotel = (from h in db.Hotels
                                    join ci in db.Cities on h.CityId equals ci.Id
                                    join co in db.Countries on ci.CountryId equals co.Id
                                    where h.Id == ho.Id
                                    select new HotelDto()
                                    {
                                        HotelId = h.Id,
                                        Name = h.Name,
                                        CityId = h.CityId,
                                        CountryId = co.Id,
                                        CityName = ci.Name,
                                        CountryName = co.Name,
                                        MaxFloorsCount = h.MaxFloorsCount,
                                        Rating = h.Rating,
                                        //RoomsByFloor = aptsPerFloor
                                    }).First();
                        result.Add(hotel);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching Hotel entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates hotel entry data
        /// </summary>
        /// <param name="hotel"> hotel entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateHotel(HotelDto hotel)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateHotel(hotel);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        //int idH = hotel.Id;
                        var query =
                            from h in db.Hotels
                            where h.Id == hotel.HotelId
                            select h;

                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such hotel entry";
                        }
                        else
                        {
                            Hotel ho = query.Single();
                            ho.Name = hotel.Name;
                            ho.MaxFloorsCount = hotel.MaxFloorsCount;
                            ho.Rating = hotel.Rating;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "Hotel entry succesfuly updated";
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
        /// Deletes hotel entry
        /// </summary>
        /// <param name="hotel"> hotel entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteHotel(HotelDto hotel)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query =
                        from h in db.Hotels
                        where h.Id == hotel.HotelId
                        select h;

                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        var hotelEntry = query.First();
                        IQueryable<Restaurant> restaurants = db.Restaurants;
                        restaurants = restaurants.Where(r => r.HotelId == hotelEntry.Id);

                        foreach (Restaurant re in restaurants)
                        {
                            db.Restaurants.Remove(re);
                        }

                        var apartments = from a in db.Apartments
                                         join f in db.Floors on a.FloorId equals f.Id
                                         where f.HotelId == hotelEntry.Id
                                         select a;

                        foreach (var ap in apartments)
                        {
                            db.Apartments.Remove(ap);
                        }

                        IQueryable<Floor> floors = db.Floors;
                        floors = floors.Where(f => f.HotelId == hotelEntry.Id);

                        foreach (Floor fl in floors)
                        {
                            db.Floors.Remove(fl);
                        }

                        db.Hotels.Remove(hotelEntry);
                        db.SaveChanges();
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Apartment
        /// <summary>
        /// Creates new Apartment record
        /// </summary>
        /// <param name="apartment"> Apartment to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertApartment(ApartmentDto apartment)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";
            DtoValidator validator = new DtoValidator();
            result = validator.ValidateApartment(apartment);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new Apartment()
                        { 
                            FloorId = apartment.FloorId,
                            MaxCapacity = apartment.MaxCapacity,
                            Number = apartment.Number,
                            Price = apartment.Price,
                            RoomsNumber = apartment.RoomsNumber,
                            TypeVip = apartment.HasStatusVip,
                        };
                        db.Apartments.Add(entry);
                        db.SaveChanges();
                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("Apartment record created: {0}{1}", entry.Number, entry.Id);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during hotel record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("Hotel record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Apartment list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Apartments list </returns>
        public List<ApartmentDto> GetApartments(ApartmentDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<ApartmentDto> result = new List<ApartmentDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Apartment> query = db.Apartments;

                    if (!string.IsNullOrEmpty(filter.CountryName))
                    {
                        query = from a in query
                                join f in db.Floors on a.FloorId equals f.Id
                                join h in db.Hotels on f.HotelId equals h.Id
                                join ci in db.Cities on h.CityId equals ci.Id
                                join co in db.Countries on ci.CountryId equals co.Id
                                where co.Name == filter.CountryName
                                select a;
                    }

                    if (!string.IsNullOrEmpty(filter.CityName))
                    {
                        query = from a in query
                                join f in db.Floors on a.FloorId equals f.Id
                                join h in db.Hotels on f.HotelId equals h.Id
                                join ci in db.Cities on h.CityId equals ci.Id
                                where ci.Name == filter.CityName
                                select a;
                    }

                    if (!string.IsNullOrEmpty(filter.HotelName))
                    {
                        query = from a in query
                                join f in db.Floors on a.FloorId equals f.Id
                                join h in db.Hotels on f.HotelId equals h.Id
                                where h.Name == filter.HotelName
                                select a;
                    }

                    if (filter.HotelId > 0)
                    {
                        query = from a in query
                                join f in db.Floors on a.FloorId equals f.Id
                                where f.HotelId == filter.HotelId
                                select a;
                    }

                    if (filter.FloorNumber > 0)
                    {
                        query = from a in query
                                join f in db.Floors on a.FloorId equals f.Id
                                where f.FloorNum == filter.FloorNumber
                                select a;
                    }

                    if (filter.FloorId > 0)
                    {
                        query = from a in query
                                where a.FloorId == filter.FloorId
                                select a;
                    }

                    if (filter.OnlyAvailable)
                    {
                        var orderedApartments = from a in query
                                                join oa in db.OrderedApartments on a.Id equals oa.ApartmentId
                                                where oa.ActualDepartureDate > DateTime.Today
                                                select a;
                        query = from a in query
                                join oa in db.OrderedApartments on a.Id equals oa.ApartmentId
                                join or in db.Orders on oa.OrderId equals or.Id
                                where !orderedApartments.Contains(a)
                                select a;
                    }

                    if (filter.MaxCapacity > 0)
                    {
                        query = from a in query
                                where a.MaxCapacity == filter.MaxCapacity
                                select a;
                    }

                    if (filter.Number > 0)
                    {
                        query = from a in query
                                where a.Number == filter.Number
                                select a;
                    }

                    if (filter.ApartmentId > 0)
                    {
                        query = from a in db.Apartments
                                where a.Id == filter.ApartmentId
                                select a;
                    }

                    foreach (Apartment ap in query)
                    {
                        var apartment = (from a in db.Apartments
                                        join f in db.Floors on a.FloorId equals f.Id
                                        join h in db.Hotels on f.HotelId equals h.Id
                                        join ct in db.Cities on h.CityId equals ct.Id
                                        join co in db.Countries on ct.CountryId equals co.Id
                                        where a.Id == ap.Id
                                        select new ApartmentDto()
                                        {
                                            ApartmentId = a.Id,
                                            Number = a.Number,
                                            HotelId = h.Id,
                                            HotelName = h.Name,
                                            FloorId = a.FloorId,
                                            FloorNumber = f.FloorNum,
                                            CityName = ct.Name,
                                            CountryName = co.Name,
                                            HasStatusVip = a.TypeVip,
                                            MaxCapacity = a.MaxCapacity,
                                            Price = a.Price,
                                            RoomsNumber = a.RoomsNumber,
                                        }).First();

                        result.Add(apartment);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching Hotel entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates apartment entry data
        /// </summary>
        /// <param name="apartment"> apartment entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateApartment(ApartmentDto apartment)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateApartment(apartment);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                         var query = from a in db.Apartments
                                    where a.Id == apartment.ApartmentId
                                    select a;
                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such apartment entry";
                        }
                        else
                        {
                            var floor = db.Floors.Where(f => f.Id == apartment.FloorId).First();
                            Apartment ap = query.First();

                            ap.Number = apartment.Number;
                            ap.FloorId = floor.Id;
                            ap.TypeVip = apartment.HasStatusVip;
                            ap.MaxCapacity = apartment.MaxCapacity;
                            ap.RoomsNumber = apartment.RoomsNumber;
                            ap.Price = apartment.Price;
                            db.SaveChanges();

                            result.IsOperationSuccessful = true;
                            result.Message = "Apartment entry succesfuly updated";
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
        /// Deletes apartment entry
        /// </summary>
        /// <param name="apartment"> apartment entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteApartment(ApartmentDto apartment)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query = from a in db.Apartments
                                where a.Id == apartment.ApartmentId
                                select a;

                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        db.Apartments.Remove(query.First());
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Menu
        /// <summary>
        /// Creates new dish record
        /// </summary>
        /// <param name="dish"> dish to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertDish(MenuDto dish)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateMenu(dish);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        if (dish.RestaurantId < 1)
                        {
                            var restaurant = from r in db.Restaurants
                                             where r.Id == dish.RestaurantId
                                             select r;
                            dish.RestaurantId = restaurant.First().Id;
                        }

                        var entry = new Menu()
                        {
                            DishName = dish.DishName,
                            RestaurantId = dish.RestaurantId,
                            Price = dish.Price
                        };
                        db.Menus.Add(entry);
                        db.SaveChanges();

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("Dish record created: {0}{1}", entry.DishName, entry.Id);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("City record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns menu according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Dishes list </returns>
        public List<MenuDto> GetMenu(MenuDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<MenuDto> result = new List<MenuDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Menu> query = db.Menus;

                    if (!string.IsNullOrEmpty(filter.HotelName))
                    {
                        query = from m in query
                                join r in db.Restaurants on m.RestaurantId equals r.Id
                                join h in db.Hotels on r.HotelId equals h.Id
                                where h.Name == filter.HotelName
                                select m;
                    }

                    if (!string.IsNullOrEmpty(filter.RestaurantName))
                    {
                        query = from m in query
                                join r in db.Restaurants on m.RestaurantId equals r.Id
                                where r.Name == filter.RestaurantName
                                select m;
                    }

                    if (filter.RestaurantId > 0)
                    {
                        query = from m in query
                                where m.RestaurantId == filter.RestaurantId
                                select m;
                    }

                    if (!string.IsNullOrEmpty(filter.DishName))
                    {
                        query = from m in query
                                where m.DishName == filter.DishName
                                select m;
                    }

                    if (filter.DishId > 0)
                    {
                        query = from m in query
                                where m.Id == filter.DishId
                                select m;
                    }

                    foreach (Menu mu in query)
                    {
                        var dish = (from m in db.Menus
                                    join r in db.Restaurants on m.RestaurantId equals r.Id
                                    join h in db.Hotels on r.HotelId equals h.Id
                                    where m.Id == mu.Id
                                    select new MenuDto()
                                    {
                                        DishId = m.Id,
                                        DishName = m.DishName,
                                        HotelName = h.Name,
                                        Price = m.Price,
                                        RestaurantId = m.RestaurantId,
                                        RestaurantName = r.Name
                                    }).First();
       
                        result.Add(dish);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates dish entry data
        /// </summary>
        /// <param name="dish"> dish entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateMenu(MenuDto dish)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateMenu(dish);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var menu = from m in db.Menus
                                   where m.Id == dish.DishId
                                   select m;
                        if (menu.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such dish entry";
                        }
                        else
                        {
                            Menu mu = menu.First();
                            mu.DishName = dish.DishName;
                            mu.Price = dish.Price;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "Dish entry succesfuly updated";
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
        /// Deletes dish entry
        /// </summary>
        /// <param name="dish"> dish entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteDish(MenuDto dish)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var menu = from m in db.Menus
                               where m.Id == dish.DishId
                               select m;
                    if (menu.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        db.Menus.Remove(menu.First());
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region OrderedDish
        /// <summary>
        /// Creates new dish order record
        /// </summary>
        /// <param name="dishOrder"> dishOrder to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertOrderedDishes(OrderedDishDto dishOrder)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateOrderedDish(dishOrder);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new OrderedDish()
                        {
                            MenuId = dishOrder.MenuId,
                            OrderId = dishOrder.OrderId
                        };
                        db.OrderedDishes.Add(entry);
                        db.SaveChanges();         
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("City record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns menu according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Dishes list </returns>
        public List<MenuDto> GetOrderedDishes(OrderedDishDto filter)
        {
            List<MenuDto> result = new List<MenuDto>();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var dishes = from m in db.Menus
                                 join od in db.OrderedDishes on m.Id equals od.MenuId
                                 join r in db.Restaurants on m.RestaurantId equals r.Id
                                 join h in db.Hotels on r.HotelId equals h.Id
                                 where od.OrderId == filter.OrderId
                                 select new MenuDto()
                                 {
                                     DishId = m.Id,
                                     DishName = m.DishName,
                                     Price = m.Price,
                                     RestaurantId = r.Id,
                                     RestaurantName = r.Name,
                                     HotelName = h.Name
                                 };

                    foreach (MenuDto m in dishes)
                    {
                        result.Add(m);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Deletes orderedDish entries specified in the List<MenuDto> OrderedDishes
        /// </summary>
        /// <param name="orderedDish"> orderedDish entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteOrderedDishes(OrderedDishDto orderedDish)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var entry = (from od in db.OrderedDishes
                                where od.OrderId == orderedDish.OrderId &&
                                od.MenuId == orderedDish.MenuId
                                select od).First();
                    db.OrderedDishes.Remove(entry);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Guests
        /// <summary>
        /// Creates new Guest record
        /// </summary>
        /// <param name="guest"> guest to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertGuest(GuestDto guest)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateGuest(guest);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new Guest()
                        {
                            PassportNumber = guest.PassportNumber,
                            FirstName = guest.FirstName,
                            MiddleName = guest.MiddleName,
                            LastName = guest.LastName,
                            DateOfBirth = guest.DateOfBirth,
                            Sex = guest.Sex,
                            Phone = guest.Phone,
                            Email = guest.Email,
                            StatusVip = false,
                            Discount = 0
                        };
                        db.Guests.Add(entry);
                        db.SaveChanges();

                        GuestDBMethods guestDb = new GuestDBMethods();
                        var relatives = guestDb.getGuestsByLastName(guest.LastName);
                        if (relatives.Count > 0)
                        {
                            FamilyDBMethods familyDb = new FamilyDBMethods();

                            foreach (var relative in relatives)
                            {
                                if (entry.Id != relative.Id)
                                {
                                    familyDb.InsertFamilyRelation(new FamilyRelation()
                                    {
                                        GuestId = entry.Id,
                                        RelativeId = relative.Id
                                    });
                                }
                            }
                        }

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("Guest record created: {0}{1}{2}", entry.FirstName, entry.LastName, entry.PassportNumber);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during guest record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("Guest record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Guests list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Guests list </returns>
        public List<GuestDto> GetGuests(GuestSearchCriteriaDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<GuestDto> result = new List<GuestDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Guest> query = db.Guests;

                    if (!string.IsNullOrEmpty(filter.PassportNumber))
                    {
                        query = from g in query
                                where g.PassportNumber == filter.PassportNumber
                                select g;
                    }
                    else
                    {
                        if (filter.IsChild)
                        {
                            DateTime threshold = DateTime.Today.AddDays(-(365 * 18));
                            query = from g in query
                                    where g.DateOfBirth > threshold
                                    select g;
                        }

                        if (filter.IsAdult)
                        {
                            DateTime threshold = DateTime.Today.AddDays(-(365 * 18));
                            query = from g in query
                                    where g.DateOfBirth < threshold
                                    select g;
                        }

                        if (!string.IsNullOrEmpty(filter.FirstName))
                        {
                            query = from g in query
                                    where g.FirstName == filter.FirstName
                                    select g;
                        }

                        if (!string.IsNullOrEmpty(filter.LastName))
                        {
                            query = from g in query
                                    where g.LastName == filter.LastName
                                    select g;
                        }

                        if (filter.DateOfBirth != default(DateTime))
                        {
                            query = from g in query
                                    where g.DateOfBirth == filter.DateOfBirth
                                    select g;
                        }

                        if (!string.IsNullOrEmpty(filter.Country))
                        {
                            query = from oa in db.OrderedApartments
                                    join a in db.Apartments on oa.ApartmentId equals a.Id
                                    join f in db.Floors on a.FloorId equals f.Id
                                    join h in db.Hotels on f.HotelId equals h.Id
                                    join ci in db.Cities on h.CityId equals ci.Id
                                    join co in db.Countries on ci.CountryId equals co.Id
                                    join g in query on oa.GuestId equals g.Id
                                    where filter.Country == co.Name
                                    select g;
                        }

                        if (!string.IsNullOrEmpty(filter.City))
                        {
                            query = from oa in db.OrderedApartments
                                    join a in db.Apartments on oa.ApartmentId equals a.Id
                                    join f in db.Floors on a.FloorId equals f.Id
                                    join h in db.Hotels on f.HotelId equals h.Id
                                    join ci in db.Cities on h.CityId equals ci.Id
                                    join g in query on oa.GuestId equals g.Id
                                    where filter.City == ci.Name
                                    select g;
                        }

                        if (!string.IsNullOrEmpty(filter.Hotel))
                        {
                            query = from oa in db.OrderedApartments
                                    join a in db.Apartments on oa.ApartmentId equals a.Id
                                    join f in db.Floors on a.FloorId equals f.Id
                                    join h in db.Hotels on f.HotelId equals h.Id
                                    join g in query on oa.GuestId equals g.Id
                                    where filter.Hotel == h.Name
                                    select g;
                        }
                    }

                    foreach (Guest gt in query)
                    {

                        var dto = new GuestDto()
                            {
                                GuestId = gt.Id,
                                PassportNumber = gt.PassportNumber,
                                FirstName = gt.FirstName,
                                MiddleName = gt.MiddleName,
                                LastName = gt.LastName,
                                Sex = gt.Sex,
                                StatusVip = gt.StatusVip,
                                DateOfBirth = gt.DateOfBirth,
                                Phone = gt.Phone,
                                Email = gt.Email,
                                Discount = gt.Discount
                            };

                        result.Add(dto);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates Guest entry data
        /// </summary>
        /// <param name="guestDto"> guest entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateGuest(GuestDto guestDto)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateGuest(guestDto);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query =
                            from g in db.Guests
                            where g.Id == guestDto.GuestId
                            select g;
                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such city entry";
                        }
                        else
                        {
                            Guest guest = query.Single();
                            //gt.PassportNumber = guest.PassportNumber;
                            guest.FirstName = guestDto.FirstName;
                            guest.MiddleName = guestDto.MiddleName;

                            if (guestDto.LastName != guest.LastName)
                            {
                                FamilyDBMethods familyDb = new FamilyDBMethods();
                                guest.LastName = guestDto.LastName;
                                var familyRelations = familyDb.getFamilyRelations(query.First().Id);

                                foreach (var relation in familyRelations)
                                {
                                    familyDb.DeleteFamilyRelation(relation);
                                }

                                GuestDBMethods guestDb = new GuestDBMethods();
                                var relatives = guestDb.getGuestsByLastName(guestDto.LastName);
                                if(relatives.Count() > 0)
                                {
                                    foreach (var relative in relatives)
                                    {
                                        if (guest.Id != relative.Id)
                                        {
                                            familyDb.InsertFamilyRelation(new FamilyRelation()
                                            {
                                                GuestId = guest.Id,
                                                RelativeId = relative.Id
                                            });
                                        }
                                    }
                                }
                            }

                            //gt.Sex = guest.Sex;
                            guest.StatusVip = guestDto.StatusVip;
                            guest.Phone = guestDto.Phone;
                            guest.Email = guestDto.Email;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "Guest entry succesfuly updated";
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
        /// Deletes Guest entry
        /// </summary>
        /// <param name="guest"> guest entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteGuest(GuestDto guest)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query =
                        from g in db.Guests
                        where g.PassportNumber == guest.PassportNumber ||
                        g.Id == guest.GuestId
                        select g;
                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        FamilyDBMethods familyDb = new FamilyDBMethods();
                        var familyRelations = familyDb.getFamilyRelations(query.First().Id);

                        foreach (var relation in familyRelations)
                        {
                            familyDb.DeleteFamilyRelation(relation);
                        }

                        db.Guests.Remove(query.First());
                        
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }
        #endregion

        #region Floors
        /// <summary>
        /// Creates new floor record
        /// </summary>
        /// <param name="floor"> floor to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertFloor(FloorDto floor)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateFloor(floor);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new Floor()
                        {
                            FloorNum = floor.FloorNum,
                            MaxApartments = floor.MaxApartments,
                            HotelId = floor.HotelId
                        };
                        db.Floors.Add(entry);
                        db.SaveChanges();

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("Floor record created: {0}", entry.FloorNum);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("Floor record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns floor according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Floors list </returns>
        public List<FloorDto> GetFloors(FloorDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<FloorDto> result = new List<FloorDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Floor> query = db.Floors;

                    if (!string.IsNullOrEmpty(filter.HotelName))
                    {
                        query = from f in query
                                join h in db.Hotels on f.HotelId equals h.Id
                                where h.Name == filter.HotelName
                                select f;
                    }

                    if (filter.HotelId > 0)
                    {
                        query = from f in query
                                where f.HotelId == filter.HotelId
                                select f;
                    }

                    if (filter.FloorNum > 0)
                    {
                        query = from f in query
                                where f.FloorNum == filter.FloorNum
                                select f;
                    }

                    if (filter.FloorId > 0)
                    {
                        query = from f in db.Floors
                                where f.Id == filter.FloorId
                                select f;
                    }

                    foreach (Floor fl in query)
                    {
                        var hotel = (from f in db.Floors
                                    join h in db.Hotels on f.HotelId equals h.Id
                                    where f.Id == fl.Id
                                    select new FloorDto()
                                    {
                                        FloorId = f.Id,
                                        FloorNum = f.FloorNum,
                                        HotelId = h.Id,
                                        HotelName = h.Name,
                                        MaxApartments = f.MaxApartments
                                    }).First();
                        result.Add(hotel);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates floor entry data
        /// </summary>
        /// <param name="floor"> floor entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateFloor(FloorDto floor)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateFloor(floor);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query = db.Floors.Where(f => f.Id == floor.FloorId);

                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such dish entry";
                        }
                        else
                        {
                            Floor fl = query.Single();
                            fl.MaxApartments = floor.MaxApartments;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "Floor entry succesfuly updated";
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
        /// Deletes floor entry
        /// </summary>
        /// <param name="floor"> floor entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteFloor(FloorDto floor)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query = db.Floors.Where(f => f.Id == floor.FloorId);

                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {
                        db.Floors.Remove(query.First());
                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Restaurants
        /// <summary>
        /// Creates new City record
        /// </summary>
        /// <param name="city"> city to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertRestaurant(RestaurantDto restaurant)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateRestaurant(restaurant);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var entry = new Restaurant()
                        {
                            HotelId = restaurant.HotelId,
                            Name = restaurant.Name,
                        };

                        db.Restaurants.Add(entry);
                        //db.SaveChanges();

                        Hotel hotel = db.Hotels.Where(h => h.Id == restaurant.HotelId).First();
                        hotel.HasRestaurant = true;
                        db.SaveChanges();

                        result.IsOperationSuccessful = true;
                        result.Message = string.Format("City record created: {0}{1}", entry.Name, entry.Id);
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Info("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("City record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Restaurants list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Restaurants list </returns>
        public List<RestaurantDto> GetRestaurants(RestaurantDto filter)
        {
            //CommonFilter filter = new CommonFilter(filterDto);
            List<RestaurantDto> result = new List<RestaurantDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Restaurant> query = db.Restaurants;

                    if (!string.IsNullOrEmpty(filter.HotelName))
                    {
                        query = from r in query
                                join h in db.Hotels on r.HotelId equals h.Id
                                where h.Name == filter.HotelName
                                select r;
                    }

                    if (filter.HotelId > 0)
                    {
                        query = from r in query
                                where r.HotelId == filter.HotelId
                                select r;
                    }

                    if (!string.IsNullOrEmpty(filter.Name))
                    {
                        query = from r in query
                                where r.Name == filter.Name
                                select r;
                    }

                    if (filter.RestaurantId > 0)
                    {
                        query = from r in db.Restaurants
                                where r.Id == filter.RestaurantId
                                select r;
                    }


                    foreach (Restaurant rt in query)
                    {
                        var rest = (from r in db.Restaurants
                                   join h in db.Hotels on r.HotelId equals h.Id
                                   where r.Id == rt.Id
                                   select new RestaurantDto()
                                   {
                                       RestaurantId = r.Id,
                                       Name = r.Name,
                                       HotelId = h.Id,
                                       HotelName = h.Name
                                   }).First();
                        result.Add(rest);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates restaurant entry data
        /// </summary>
        /// <param name="restaurant"> restaurant entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateRestaurant(RestaurantDto restaurant)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            result = new DtoValidator().ValidateRestaurant(restaurant);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var query = db.Restaurants.Where(r => r.Id == restaurant.RestaurantId);
                        if (query.Count() < 1)
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such city entry";
                        }
                        else
                        {
                            Restaurant rt = query.First();
                            rt.Name = restaurant.Name;
                            db.SaveChanges();
                            result.IsOperationSuccessful = true;
                            result.Message = "City entry succesfuly updated";
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
        /// Deletes restaurant entry
        /// </summary>
        /// <param name="restaurant"> restaurant entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteRestaurant(RestaurantDto restaurant)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var query = db.Restaurants.Where(r => r.Id == restaurant.RestaurantId);
                    if (query.Count() < 1)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Entry not found";
                    }
                    else
                    {

                        db.Restaurants.Remove(query.First());
                        db.SaveChanges();
                        IQueryable<Restaurant> restaurantsQuery = db.Restaurants.Where(r => r.HotelId == restaurant.HotelId);
                        if (restaurantsQuery.Count() < 1)
                        {
                            Hotel hotel = db.Hotels.Where(h => h.Id == restaurant.HotelId).First();
                            hotel.HasRestaurant = false;
                            db.SaveChanges();
                        }

                        result.IsOperationSuccessful = true;
                        result.Message = "Entry successfuly deleted";
                    }
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }

        #endregion

        #region Orders
        /// <summary>
        /// Creates new Order record
        /// </summary>
        /// <param name="order"> order to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto InsertOrder(OrderDto order)
        {
            var result = new ServiceResponceDto();
            result.IsOperationSuccessful = false;
            result.Message = "Unknown exception";

            result = new DtoValidator().ValidateOrder(order);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        int userId = int.Parse(Regex.Match(order.UserLogin, "[0-9]+").Value);
                        var entry = new Order()
                        {
                            HotelId = order.HotelId,
                            GuestId = order.GuestId,
                            OrderDate = DateTime.Today,
                            //ActualDepartureDate = order.DepartureDate,
                            UserId = userId
                        };

                        db.Orders.Add(entry);
                        db.SaveChanges();

                        GuestDBMethods guestDb = new GuestDBMethods();
                        var guest = guestDb.getGuestById(order.GuestId);

                        result = OrderApartment(new OrderedApartmentDto()
                        {
                            ApartmentId = order.ApartmentId,
                            OrderId = entry.Id,
                            GuestPassportNumber = guest.PassportNumber,
                            ActualDepartureDate = order.DepartureDate
                        });

                        if (!result.IsOperationSuccessful)
                        {
                            db.Orders.Remove(entry);
                            db.SaveChanges();
                        }
                        else
                        {
                            result.IsOperationSuccessful = true;
                            result.EntryId = entry.Id;
                            result.Message = string.Format("Order record created: {0}{1}", entry.OrderDate, entry.Id);
                        }
                    }
                    catch (Exception ex)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = ex.Message;
                    }
                }
            }
            if (!result.IsOperationSuccessful)
            {
                Logger.Log.Error("Error during city record creation: " + result.Message);
            }
            else
            {
                Logger.Log.Info("City record successfuly created: " + result.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns Orders list according to FilterCriteria
        /// </summary>
        /// <param name="filter"> contains data field to filter result </param>
        /// <returns> Orders list </returns>
        public List<OrderDto> GetOrders(OrderSearchCriteriaDto filter)
        {
            List<OrderDto> result = new List<OrderDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Order> query = db.Orders;

                    if (!string.IsNullOrEmpty(filter.CountryName))
                    {
                        query = from o in query
                                join h in db.Hotels on o.HotelId equals h.Id
                                join ci in db.Cities on h.CityId equals ci.Id
                                join co in db.Countries on ci.CountryId equals co.Id
                                where co.Name == filter.CountryName
                                select o;
                    }

                    if (!string.IsNullOrEmpty(filter.CityName))
                    {
                        query = from o in query
                                join h in db.Hotels on o.HotelId equals h.Id
                                join ci in db.Cities on h.CityId equals ci.Id
                                where ci.Name == filter.CityName
                                select o;
                    }

                    if (!string.IsNullOrEmpty(filter.HotelName))
                    {
                        query = from o in query
                                join h in db.Hotels on o.HotelId equals h.Id
                                where h.Name == filter.HotelName
                                select o;
                    }

                    if (!string.IsNullOrEmpty(filter.GuestPassportNumber))
                    {
                        query = from o in query
                                join g in db.Guests on o.GuestId equals g.Id
                                where g.PassportNumber == filter.GuestPassportNumber
                                select o;
                    }

                    foreach (Order or in query)
                    {
                        var entry = (from o in db.Orders
                                     join h in db.Hotels on o.HotelId equals h.Id
                                     join ci in db.Cities on h.CityId equals ci.Id
                                     join co in db.Countries on ci.CountryId equals co.Id
                                     join g in db.Guests on o.GuestId equals g.Id
                                     join u in db.Users on o.UserId equals u.Id
                                     where o.Id == or.Id
                                         select new OrderDto()
                                         {
                                             Id = o.Id,
                                             HotelId = o.HotelId,
                                             GuestId = o.GuestId,
                                             GuestFirstName = g.FirstName,
                                             GuestLastName = g.LastName,
                                             PassportNumber = g.PassportNumber,
                                             CountryName = co.Name,
                                             CityName = ci.Name,
                                             HotelName = h.Name,
                                             OrderDate = o.OrderDate,
                                             Total = o.TotalPrice,
                                             //UserLogin = u.LastName + u.Id.ToString()
                                             
                                         }).First();
                        result.Add(entry);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Info("An error occured during searching city entries: " + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Updates order entry data
        /// </summary>
        /// <param name="order"> Order entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto UpdateOrder(OrderDto order)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            DtoValidator validator = new DtoValidator();
            result = validator.ValidateOrder(order);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        int idOrd = order.Id;
                        IQueryable<Order> orderQuery = db.Orders.Where(o => o.Id == order.Id);
                        if (orderQuery.Count() > 0)
                        {
                            var orderEntry = orderQuery.Last();
                            orderEntry.OrderDate = order.OrderDate;
                            orderEntry.UserId = int.Parse(Regex.Match(order.UserLogin, "[0-9]+").Value);
                            orderEntry.TotalPrice = order.Total;
                            db.SaveChanges();
                        }
                        else
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "No such order";
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
        /// Deletes order entry
        /// </summary>
        /// <param name="order"> order entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteOrder(OrderDto order)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Order> orderQuery = db.Orders.Where(o => o.Id == order.Id);
                    if (orderQuery.Count() > 0)
                    {
                        var orderEntry = orderQuery.First();
                        db.Orders.Remove(orderEntry);
                        db.SaveChanges();
                        result.IsOperationSuccessful = true;
                        result.Message = "Sucess";
                    }
                    else
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "No such order entry";
                    }
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }
            return result;
        }


        /// <summary>
        /// Checks out guests, cpecified in given order
        /// </summary>
        /// <param name="order"> order entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public PaycheckDto CheckOutOrder(OrderDto order)
        {
            PaycheckDto result = new PaycheckDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var opResult = CalculateOrderPrice(order);
                    if (opResult.IsOperationSuccessful)
                    {

                        result = (from o in db.Orders
                                   join h in db.Hotels on o.HotelId equals h.Id
                                   join ci in db.Cities on h.CityId equals ci.Id
                                   join co in db.Countries on ci.CountryId equals co.Id
                                   where o.Id == order.Id
                                   select new PaycheckDto()
                                   {
                                       OrderId = o.Id,
                                       CityName = ci.Name,
                                       CountryName = co.Name,
                                       HotelName = h.Name,
                                       TotalPrice = o.TotalPrice,
                                       OrderDate = o.OrderDate
                                   }).First();

                        var guest = (from g in db.Guests
                                    where g.Id == order.GuestId
                                    select g).First();

                        var orders = from o in db.Orders
                                     where o.GuestId == order.GuestId
                                     select o;

                        if (orders.Count() >= 3)
                        {
                            guest.Discount = result.TotalPrice * 0.02;
                            db.SaveChanges();
                        }
                        var orderedApartments = from oa in db.OrderedApartments
                                                where oa.OrderId == order.Id
                                                select oa;
                        var apartments = (from oa in orderedApartments
                                          select oa.ApartmentId).Distinct();

                        List<ApartmentPaycheckDto> orderedApartmentsList = new List<ApartmentPaycheckDto>();

                        foreach (var ap in apartments)
                        {
                            var maxStayTime = (from oa in orderedApartments
                                               where oa.ApartmentId == ap
                                               select oa.ActualDepartureDate).Max();
                            int totalDays = (maxStayTime - result.OrderDate).Days;
                            var orderedApartment = (from oa in db.OrderedApartments
                                                    join o in db.Orders on oa.OrderId equals o.Id
                                                    join a in db.Apartments on oa.ApartmentId equals a.Id
                                                    join f in db.Floors on a.FloorId equals f.Id
                                                    where oa.ApartmentId == ap &&
                                                    oa.OrderId == order.Id &&
                                                    oa.ActualDepartureDate == maxStayTime
                                                    select new ApartmentPaycheckDto()
                                                    {
                                                        ActualDepartureDate = maxStayTime,
                                                        ApartmentNumber = a.Number,
                                                        ApartmentPrice = a.Price,
                                                        FloorNumber = f.FloorNum,
                                                        TotalDays = totalDays
                                                   }).First();
                                                   
                            orderedApartmentsList.Add(orderedApartment);
                        }

                        result.OrderedApartments = orderedApartmentsList;

                        var orderedDishes = from od in db.OrderedDishes
                                            join m in db.Menus on od.MenuId equals m.Id
                                            where od.OrderId == order.Id
                                            select m;
                        List<DishDto> orderedDishesList = new List<DishDto>();
                        foreach (var od in orderedDishes)
                        {
                            DishDto dsh = new DishDto()
                            {
                                DishId = od.Id,
                                DishName = od.DishName,
                                DishPrice = od.Price
                            };
                            orderedDishesList.Add(dsh);
                        }

                        result.OrderedDishes = orderedDishesList;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Error(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Checks out guests, cpecified in given order
        /// </summary>
        /// <param name="order"> order entry to update </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto CalculateOrderPrice(OrderDto order)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var ord = db.Orders.Where(o => o.Id == order.Id).First();

                    var orderedApartments = from oa in db.OrderedApartments
                                            where oa.OrderId == order.Id
                                            select oa;
                    var apartments = (from oa in orderedApartments
                                      select oa.ApartmentId).Distinct();

                    FamilyDBMethods familyDB = new FamilyDBMethods();


                    double maxDiscount = familyDB.getFamilyMaxDiscount(order.GuestId);
                    GuestDBMethods guestDB = new GuestDBMethods();
                    var guest = guestDB.getGuestById(order.GuestId);

                    if(maxDiscount < guest.Discount)
                    {
                        maxDiscount = guest.Discount;
                    }

                    double totalPrice = 0;

                    foreach (var ap in apartments)
                    {
                        var apartment = db.Apartments.Where(a => a.Id == ap).First();
                        var maxStayTime = (from oa in orderedApartments
                                           where oa.ApartmentId == ap &&
                                           oa.OrderId == order.Id
                                           select oa.ActualDepartureDate).Max();
                        totalPrice += apartment.Price * (maxStayTime - ord.OrderDate).Days;
                    }

                    var orderedDishes = from od in db.OrderedDishes
                                         join m in db.Menus on od.MenuId equals m.Id
                                         where od.OrderId == order.Id
                                         select m;

                    foreach (var od in orderedDishes)
                    {
                        totalPrice += od.Price;
                    }

                    if(guest.DateOfBirth.DayOfYear == DateTime.Today.DayOfYear)
                    {
                        totalPrice -= totalPrice * 0.1;
                    }

                    if (maxDiscount <= totalPrice * 0.3)
                    {
                        totalPrice -= maxDiscount;
                    }
                    else
                    {
                        totalPrice -= totalPrice * 0.3;
                    }

                    ord.TotalPrice = totalPrice;
                    db.SaveChanges();
                    result.Message = "Success";
                    result.IsOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    Logger.Log.Error(ex.Message);
                }
            }
            return result;
        }
        #endregion

        #region OrderedApartment
        /// <summary>
        /// Binds order + guest and apartment (orders apartment)
        /// </summary>
        /// <param name="orderedApt"> new ordered apartment record </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto OrderApartment(OrderedApartmentDto orderedApt)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            DtoValidator validator = new DtoValidator();
            result = validator.ValidateOrderedApartment(orderedApt);
            if (result.IsOperationSuccessful)
            {
                using (var db = new HotelISDBContainer())
                {
                    try
                    {
                        var apartment = (db.Apartments.Where(a => a.Id == orderedApt.ApartmentId)).First();
                        var orderedApartments = from oa in db.OrderedApartments
                                                where oa.ApartmentId == orderedApt.ApartmentId &&
                                                oa.OrderId == orderedApt.OrderId
                                                select oa;
                        if (orderedApartments.Count() < apartment.MaxCapacity)
                        {
                            var guest = db.Guests.Where(g => g.PassportNumber == orderedApt.GuestPassportNumber).First();

                            if (guest.StatusVip && !apartment.TypeVip)
                            {
                                result.IsOperationSuccessful = false;
                                result.Message = "VIP guest can`t be checked-in in the not VIP room";
                            }
                            else
                            {
                                DateTime thresholdDob = DateTime.Today.AddYears(-adultAge);
                                if(guest.DateOfBirth > thresholdDob)
                                {
                                    result.IsOperationSuccessful = false;
                                    ParentChildDBMethods parentChildDB = new ParentChildDBMethods();
                                    var parents = parentChildDB.GetParents(guest.Id);
                                    HotelDBMethods hotelDB = new HotelDBMethods();

                                    var hotel = hotelDB.GetApartmentHotel(orderedApt.ApartmentId);

                                    foreach(var parent in parents)
                                    {
                                        OrdersDBMethods ordersDb = new OrdersDBMethods();
                                        if(ordersDb.IsGuestCheckedInTheHotel(parent.Id, hotel.Id))
                                        {
                                            result.IsOperationSuccessful = true;
                                        }
                                    }
                                }

                                if (result.IsOperationSuccessful)
                                {
                                    var order = db.Orders.Where(o => o.Id == orderedApt.OrderId).First();

                                    OrderedApartment oaEntry = new OrderedApartment()
                                    {
                                        OrderId = order.Id,
                                        ApartmentId = orderedApt.ApartmentId,
                                        GuestId = guest.Id,
                                        ActualDepartureDate = orderedApt.ActualDepartureDate
                                    };
                                    db.OrderedApartments.Add(oaEntry);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    result.Message = "Child can`t check-in without parents";
                                }
                            }
                        }
                        else
                        {
                            result.IsOperationSuccessful = false;
                            result.Message = "Apartment reached it`s max capacity";
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
        /// Binds order + guest and apartment (orders apartment)
        /// </summary>
        /// <param name="orderedApt"> new ordered apartment record </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto CheckOutGuest(OrderedApartmentDto orderedApt)
        {
            ServiceResponceDto result = new ServiceResponceDto();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var guest = db.Guests.Where(g => g.PassportNumber == orderedApt.GuestPassportNumber).First();
                    ParentChildDBMethods parentChildDB = new ParentChildDBMethods();
                    var childs = parentChildDB.GetChilds(guest.Id);

                    OrdersDBMethods ordersDb = new OrdersDBMethods();
                    bool isCheckedInChild = false;

                    foreach(var child in childs)
                    {
                        if(ordersDb.IsGuestCheckedIn(guest.Id))
                        {
                            isCheckedInChild = true;
                        }
                    }

                    if (isCheckedInChild)
                    {
                        result.IsOperationSuccessful = false;
                        result.Message = "Parent can`t leave child";
                    }
                    else
                    {

                        var orderedApartment = (from oa in db.OrderedApartments
                                                where oa.OrderId == orderedApt.OrderId &&
                                                oa.ApartmentId == orderedApt.ApartmentId &&
                                                oa.GuestId == guest.Id
                                                select oa).First();


                        orderedApartment.ActualDepartureDate = DateTime.Now;
                        

                        int vipCheckIns = ordersDb.GetVipCheckInsCount(guest.Id);
                        if(vipCheckIns >= 3)
                        {
                            guest.StatusVip = true;
                        }
                        db.SaveChanges();
                        result.IsOperationSuccessful = true;
                        result.Message = "Success";
                    }
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "DB error: " + ex.Message;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns list of ordered apartments
        /// </summary>
        /// <param name="filter"> entry search criteria </param>
        /// <returns> success or fail result with error description </returns>
        public List<OrderedApartmentDto> GetOrderedApartments(OrderedApartmentDto filter)
        {
            List<OrderedApartmentDto> result = new List<OrderedApartmentDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<OrderedApartmentDto> apartments = from a in db.Apartments
                        join oa in db.OrderedApartments on a.Id equals oa.ApartmentId
                        join g in db.Guests on oa.GuestId equals g.Id
                        join f in db.Floors on a.FloorId equals f.Id
                        join h in db.Hotels on f.HotelId equals h.Id
                        join ci in db.Cities on h.CityId equals ci.Id
                        join co in db.Countries on ci.CountryId equals co.Id
                        select new OrderedApartmentDto()
                        {
                            ApartmentId = a.Id,
                            ApartmentNumber = a.Number,
                            CityName = ci.Name,
                            CountryName = co.Name,
                            FloorNumber = f.FloorNum,
                            ActualDepartureDate = oa.ActualDepartureDate,
                            GuestFirstName = g.FirstName,
                            GuestLastName = g.LastName,
                            GuestPassportNumber = g.PassportNumber,
                            HotelName = h.Name,
                            OrderId = oa.OrderId
                         };

                    if (filter.OrderId > 0)
                    {
                        apartments = from a in apartments
                                     where a.OrderId == filter.OrderId
                                     select a;
                    }

                    if(!string.IsNullOrEmpty(filter.CountryName) && !string.IsNullOrEmpty(filter.HotelName))
                    {
                        apartments = from a in apartments
                                     where a.CountryName == filter.CountryName &&
                                     a.HotelName == filter.HotelName
                                     select a;
                    }

                    if(filter.FloorNumber > 0)
                    {
                        apartments = from a in apartments
                                     where a.FloorNumber == filter.FloorNumber
                                     select a;
                    }

                    foreach(OrderedApartmentDto oa in apartments)
                    {
                        result.Add(oa);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Error(ex.Message);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes ordered apartment record
        /// </summary>
        /// <param name="order"> order entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        public ServiceResponceDto DeleteOrderedApartment(OrderedApartmentDto orderApt)
        {
            ServiceResponceDto result = new ServiceResponceDto();
            using (var db = new HotelISDBContainer())
            {
                try
                {
                    var guest = db.Guests.Where(g => g.PassportNumber == orderApt.GuestPassportNumber).First();
                    var orderedApartment = db.OrderedApartments.Where(oa => oa.ApartmentId == orderApt.ApartmentId &&
                        oa.GuestId == guest.Id &&
                        oa.OrderId == orderApt.OrderId).First();
                    db.OrderedApartments.Remove(orderedApartment);
                    db.SaveChanges();
                    result.IsOperationSuccessful = true;
                    result.Message = "Entry successfully deleted";
                }
                catch (Exception ex)
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Database error";
                    Logger.Log.Error(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Returns list of guests according to order
        /// </summary>
        /// <param name="filter"> entry search criteria </param>
        /// <returns> List of guest DTO </returns>
        public List<GuestDto> GetGuestsByOrder(OrderedApartmentDto filter)
        {
            List<GuestDto> result = new List<GuestDto>();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                    IQueryable<Guest> query = db.Guests;
                    if (filter.OrderId > 0)
                    {
                        query = from g in query
                                join oa in db.OrderedApartments on g.Id equals oa.GuestId
                                where oa.OrderId == filter.OrderId
                                select g;
                    }

                    if (filter.ApartmentId > 0)
                    {
                        query = from g in query
                                join oa in db.OrderedApartments on g.Id equals oa.GuestId
                                where oa.ApartmentId == filter.ApartmentId
                                select g;
                    }

                    query = query.Distinct();

                    foreach (Guest gt in query)
                    {
                        result.Add(new GuestDto()
                        {
                            GuestId = gt.Id,
                            DateOfBirth = gt.DateOfBirth,
                            Discount = gt.Discount,
                            Email = gt.Email,
                            FirstName = gt.FirstName,
                            LastName = gt.LastName,
                            MiddleName = gt.MiddleName,
                            PassportNumber = gt.PassportNumber,
                            Phone = gt.Phone,
                            Sex = gt.Sex,
                            StatusVip = gt.StatusVip
                        });
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Error(ex.Message);
                }
            }

            return result;
        }

        public DataTable GetHotelStatus(HotelStatusFilterDto filter)
        {
            DataTable result = new DataTable();

            using (var db = new HotelISDBContainer())
            {
                try
                {
                     var query = from apartment in db.Apartments
                             join floor in db.Floors on apartment.FloorId equals floor.Id
                             join hotel in db.Hotels on floor.HotelId equals hotel.Id
                             join city in db.Cities on hotel.CityId equals city.Id
                             join country in db.Countries on city.CountryId equals country.Id
                             where hotel.Id == filter.HotelId
                             select new
                             {
                                 apartment.Id,
                                 apartment.Number
                             };
                    
                }
                catch (Exception ex)
                {
                    Logger.Log.Error(ex.Message);
                }
            }
            return result;
        }

        #endregion

        #region Relations

        public ServiceResponceDto AddParentChildRelation(ParentChildDto relation)
        {
            ParentChildDBMethods dbParentChild = new ParentChildDBMethods();
            ParentChildDtoValidator validator = new ParentChildDtoValidator();
            var entry = validator.Validate(relation);
            ServiceResponceDto result = validator.ValidationResult;

            if (result.IsOperationSuccessful)
            {
                if (!dbParentChild.InsertParentChild(new ChildParent()
                {
                    ChildId = relation.ChildId,
                    ParentId = relation.ParentId
                }))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Error during record creation";
                }
            }
            return result;
        }

        public ServiceResponceDto DeleteParentChildRelation(ParentChildDto relation)
        {

            ServiceResponceDto result = new ServiceResponceDto()
            {
                IsOperationSuccessful = true
            };
            ParentChildDBMethods dbParentChild = new ParentChildDBMethods();
            var relations = dbParentChild.getParentChilds(relation);
            if (relations.Count() != 1)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Record not found";
            }
            else
            {
                dbParentChild.DeleteParentChild(relations.First());
            }
            return result;
        }

        public List<ParentChildDto> GetParentChildRelations(ParentChildDto relation)
        {
            ParentChildDBMethods dbParentChild = new ParentChildDBMethods();
            GuestDBMethods dbGuests = new GuestDBMethods();
            List<ChildParent> rows = dbParentChild.getParentChilds(relation);
            List<ParentChildDto> result = new List<ParentChildDto>();

            foreach (var row in rows)
            {
                var parent = dbGuests.getGuestById(row.ParentId);
                var child = dbGuests.getGuestById(row.ChildId);
                ParentChildDto pcRecord = new ParentChildDto()
                {
                    ParentId = row.ParentId,
                    ChildId = row.ChildId,
                    ChildFirstname = child.FirstName,
                    ChildLastname = child.LastName,
                    ChildPassport = child.PassportNumber,
                    ParentFirstname = parent.FirstName,
                    ParentLastname = parent.LastName,
                    ParentPassport = parent.PassportNumber
                };
                result.Add(pcRecord);
            }

            return result;
        }

        #endregion
    }
}
