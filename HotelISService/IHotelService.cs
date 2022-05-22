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
    [ServiceContract]
    public interface IHotelService
    {
        #region Common Methods

        /// <summary>
        /// connection testing
        /// </summary>
        /// <returns> Service responce result </returns>
        [OperationContract]
        ServiceResponceDto TestConnection();

        #endregion

        #region Users
        /// <summary>
        /// Checks user authorization
        /// </summary>
        /// <param name="user"> user to check </param>
        /// <returns> authorized user </returns>
        [OperationContract]
        LoginResultDto AuthorizeUzer(LoginDto login);

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="user"> user to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertUser(UserDto user);

        /// <summary>
        /// Returns Users list
        /// </summary>
        /// <param name="filter">  filter dto with basic user information(Login) to find certain user </param>
        /// <returns> user records list </returns>
        [OperationContract]
        List<UserDto> GetUsers(UserDto filter);

        /// <summary>
        /// Updates a user data
        /// </summary>
        /// <param name="user"> user to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateUser(UserDto user);

        [OperationContract]
        ServiceResponceDto DeleteUser(UserDto user);
        #endregion

        #region City
        // <summary>
        /// Creates new City record
        /// </summary>
        /// <param name="city"> city to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertCity(CityDto city);

        /// <summary>
        /// Returns Cities list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Cities list </returns>
        [OperationContract]
        List<CityDto> GetCities(CityDto filter);

        /// <summary>
        /// Updates city entry data
        /// </summary>
        /// <param name="city"> city entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateCity(CityDto city);

        /// <summary>
        /// Deletes city entry
        /// </summary>
        /// <param name="city"> city entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteCity(CityDto city);
        #endregion

        #region Country
        // <summary>
        /// Creates new Country record
        /// </summary>
        /// <param name="country"> country to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertCountry(CountryDto country);

        /// <summary>
        /// Returns Countries list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Countries list </returns>
        [OperationContract]
        List<CountryDto> GetCountries(CountryDto filter);

        /// <summary>
        /// Updates country entry data
        /// </summary>
        /// <param name="country"> country entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateCountry(CountryDto country);

        /// <summary>
        /// Deletes country entry
        /// </summary>
        /// <param name="country"> country entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteCountry(CountryDto country);
        #endregion

        #region Hotel
        // <summary>
        /// Creates new Hotel record
        /// </summary>
        /// <param name="hotel"> hotel to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertHotel(HotelDto hotel);

        /// <summary>
        /// Returns Hotels list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Hotels list </returns>
        [OperationContract]
        List<HotelDto> GetHotels(HotelDto filter);

        /// <summary>
        /// Updates hotel entry data
        /// </summary>
        /// <param name="hotel"> hotel entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateHotel(HotelDto hotel);

        /// <summary>
        /// Deletes hotel entry
        /// </summary>
        /// <param name="hotel"> hotel entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteHotel(HotelDto hotel);
        #endregion

        #region Apartment
        /// <summary>
        /// Creates new Apartment record
        /// </summary>
        /// <param name="apartment"> Apartment to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertApartment(ApartmentDto apartment);

        /// <summary>
        /// Returns Apartment list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Apartments list </returns>
        [OperationContract]
        List<ApartmentDto> GetApartments(ApartmentDto filter);

        /// <summary>
        /// Updates apartment entry data
        /// </summary>
        /// <param name="apartment"> apartment entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateApartment(ApartmentDto apartment);

        /// <summary>
        /// Deletes apartment entry
        /// </summary>
        /// <param name="apartment"> apartment entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteApartment(ApartmentDto apartment);
        #endregion

        #region Menu
        // <summary>
        /// Creates new Menu record
        /// </summary>
        /// <param name="menu"> menu to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertDish(MenuDto dish);

        /// <summary>
        /// Returns Dishes list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Dishes list </returns>
        [OperationContract]
        List<MenuDto> GetMenu(MenuDto filter);

        /// <summary>
        /// Updates dish entry data
        /// </summary>
        /// <param name="dish"> dish entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateMenu(MenuDto dish);

        /// <summary>
        /// Deletes dish entry
        /// </summary>
        /// <param name="dish"> dish entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteDish(MenuDto dish);
        #endregion

        #region OrderedDishes
        /// <summary>
        /// Creates new dish order record
        /// </summary>
        /// <param name="dishOrder"> dishOrder to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        ServiceResponceDto InsertOrderedDishes(OrderedDishDto dishOrder);

        /// <summary>
        /// Returns menu according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Dishes list </returns>
        List<MenuDto> GetOrderedDishes(OrderedDishDto filter);

        /// <summary>
        /// Deletes orderedDish entries specified in the List<MenuDto> OrderedDishes
        /// </summary>
        /// <param name="orderedDish"> orderedDish entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        ServiceResponceDto DeleteOrderedDishes(OrderedDishDto orderedDish);
        #endregion

        #region Guest
        // <summary>
        /// Creates new Guest record
        /// </summary>
        /// <param name="guest"> guest to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertGuest(GuestDto guest);

        /// <summary>
        /// Returns Guests list according to FilterCriteria
        /// </summary>
        /// <param name="GuestDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Guests list </returns>
        [OperationContract]
        List<GuestDto> GetGuests(GuestSearchCriteriaDto filter);

        /// <summary>
        /// Updates guest entry data
        /// </summary>
        /// <param name="guest"> guest entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateGuest(GuestDto guest);

        /// <summary>
        /// Deletes guest entry
        /// </summary>
        /// <param name="guest"> guest entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteGuest(GuestDto guest);
        #endregion

        #region Floors
        // <summary>
        /// Creates new Floor record
        /// </summary>
        /// <param name="floor"> floor to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertFloor(FloorDto floor);

        /// <summary>
        /// Returns Floors list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Floors list </returns>
        [OperationContract]
        List<FloorDto> GetFloors(FloorDto filter);

        /// <summary>
        /// Updates floor entry data
        /// </summary>
        /// <param name="country"> floor entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateFloor(FloorDto floor);

        /// <summary>
        /// Deletes floor entry
        /// </summary>
        /// <param name="floor"> floor entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteFloor(FloorDto floor);
        #endregion

        #region Restaurants
        // <summary>
        /// Creates new Restaurant record
        /// </summary>
        /// <param name="restaurant"> restaurant to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertRestaurant(RestaurantDto restaurant);

        /// <summary>
        /// Returns Restaurants list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Restaurants list </returns>
        [OperationContract]
        List<RestaurantDto> GetRestaurants(RestaurantDto filter);

        /// <summary>
        /// Updates restaurant entry data
        /// </summary>
        /// <param name="restaurant"> restaurant entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateRestaurant(RestaurantDto restaurant);

        /// <summary>
        /// Deletes restaurant entry
        /// </summary>
        /// <param name="restaurant"> restaurant entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteRestaurant(RestaurantDto restaurant);
        #endregion

        #region Orders
        // <summary>
        /// Creates new Order record
        /// </summary>
        /// <param name="order"> order to insert to the database </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto InsertOrder(OrderDto order);

        /// <summary>
        /// Returns Orders list according to FilterCriteria
        /// </summary>
        /// <param name="filterDto"> FilterCriteriaDto, contains data field to filter result </param>
        /// <returns> Orders list </returns>
        [OperationContract]
        List<OrderDto> GetOrders(OrderSearchCriteriaDto filter);

        /// <summary>
        /// Updates order entry data
        /// </summary>
        /// <param name="order"> order entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto UpdateOrder(OrderDto order);

        /// <summary>
        /// Deletes Order entry
        /// </summary>
        /// <param name="Order"> Order entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteOrder(OrderDto order);

        /// <summary>
        /// Checks out guests, cpecified in given order
        /// </summary>
        /// <param name="order"> order entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        PaycheckDto CheckOutOrder(OrderDto order);

        /// <summary>
        /// Checks out guests, cpecified in given order
        /// </summary>
        /// <param name="order"> order entry to update </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto CalculateOrderPrice(OrderDto order);

        #endregion

        #region OrderedApartments

        /// <summary>
        /// Binds order + guest and apartment (orders apartment)
        /// </summary>
        /// <param name="orderedApt"> new ordered apartment record </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto OrderApartment(OrderedApartmentDto orderedApt);

        /// <summary>
        /// Binds order + guest and apartment (orders apartment)
        /// </summary>
        /// <param name="orderedApt"> new ordered apartment record </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto CheckOutGuest(OrderedApartmentDto orderedApt);

        /// <summary>
        /// Returns list of ordered apartments
        /// </summary>
        /// <param name="filter"> entry search criteria </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        List<OrderedApartmentDto> GetOrderedApartments(OrderedApartmentDto filter);

        /// <summary>
        /// Removes ordered apartment record
        /// </summary>
        /// <param name="order"> order entry to delete </param>
        /// <returns> success or fail result with error description </returns>
        [OperationContract]
        ServiceResponceDto DeleteOrderedApartment(OrderedApartmentDto orderApt);

        /// <summary>
        /// Returns list of guests according to order
        /// </summary>
        /// <param name="filter"> entry search criteria </param>
        /// <returns> List of guest DTO </returns>
        [OperationContract]
        List<GuestDto> GetGuestsByOrder(OrderedApartmentDto filter);

        [OperationContract]
        DataTable GetHotelStatus(HotelStatusFilterDto filter);

        #endregion

        #region Relations

        [OperationContract]
        ServiceResponceDto AddParentChildRelation(ParentChildDto relation);

        [OperationContract]
        ServiceResponceDto DeleteParentChildRelation(ParentChildDto relation);

        [OperationContract]
        List<ParentChildDto> GetParentChildRelations(ParentChildDto relation);

        #endregion
    }
}
