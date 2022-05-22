using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelISDTO;

namespace HotelISService
{
    public class GuestDBMethods
    {
        private HotelISService.HotelISDBContainer dbContainer;

        public GuestDBMethods()
        {
            dbContainer = new HotelISDBContainer();
        }

        public Guest getGuestById(int id)
        {
            Guest result = null;

            try
            {
                result = dbContainer.Guests.Where(g => g.Id == id).Single();
            }
            catch(Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
            }

            return result;
        }

        public Guest getGuestByPassport(string passportNumber)
        {
            Guest result = null;

            try
            {
                result = dbContainer.Guests.Where(g => g.PassportNumber == passportNumber).First();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
            }

            return result;
        }

        public List<Guest> getGuestsByLastName(string LastName)
        {
            List<Guest> result = new List<Guest>();
            try
            {
                var query = from g in dbContainer.Guests
                    where g.LastName == LastName
                    select g;
                    result = query.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }

        public List<Guest> getGuests(GuestSearchCriteriaDto filter)
        {
            List<Guest> result = new List<Guest>();
            try
            {
                IQueryable<Guest> query = dbContainer.Guests;
                if (!string.IsNullOrEmpty(filter.PassportNumber))
                {
                    query = from g in query
                            where g.PassportNumber == filter.PassportNumber
                            select g;
                    result = query.ToList();
                }
                else
                {
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
                        query = from oa in dbContainer.OrderedApartments
                                join a in dbContainer.Apartments on oa.ApartmentId equals a.Id
                                join f in dbContainer.Floors on a.FloorId equals f.Id
                                join h in dbContainer.Hotels on f.HotelId equals h.Id
                                join ci in dbContainer.Cities on h.CityId equals ci.Id
                                join co in dbContainer.Countries on ci.CountryId equals co.Id
                                join g in query on oa.GuestId equals g.Id
                                where filter.Country == co.Name
                                select g;
                    }

                    if (!string.IsNullOrEmpty(filter.City))
                    {
                        query = from oa in dbContainer.OrderedApartments
                                join a in dbContainer.Apartments on oa.ApartmentId equals a.Id
                                join f in dbContainer.Floors on a.FloorId equals f.Id
                                join h in dbContainer.Hotels on f.HotelId equals h.Id
                                join ci in dbContainer.Cities on h.CityId equals ci.Id
                                join g in query on oa.GuestId equals g.Id
                                where filter.City == ci.Name
                                select g;
                    }

                    if (!string.IsNullOrEmpty(filter.Hotel))
                    {
                        query = from oa in dbContainer.OrderedApartments
                                join a in dbContainer.Apartments on oa.ApartmentId equals a.Id
                                join f in dbContainer.Floors on a.FloorId equals f.Id
                                join h in dbContainer.Hotels on f.HotelId equals h.Id
                                join g in query on oa.GuestId equals g.Id
                                where filter.Hotel == h.Name
                                select g;
                    }

                    result = query.ToList();
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }

            return result;
        }
    }
}