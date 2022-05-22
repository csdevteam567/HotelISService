using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelISService
{
    public class OrdersDBMethods
    {
        private HotelISService.HotelISDBContainer dbContainer;

        public OrdersDBMethods()
        {
            dbContainer = new HotelISDBContainer();
        }

        public bool IsGuestCheckedIn(int guestId)
        {
            bool result = false;
            try
            {
                var query = from oa in dbContainer.OrderedApartments
                            where oa.GuestId == guestId &&
                            oa.ActualDepartureDate > DateTime.Now
                            select oa;
                if(query.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }

        public bool IsGuestCheckedInTheHotel(int guestId, int hotelId)
        {
            bool result = false;
            try
            {
                var query = from oa in dbContainer.OrderedApartments
                            join a in dbContainer.Apartments on oa.ApartmentId equals a.Id
                            join f in dbContainer.Floors on a.FloorId equals f.Id
                            where oa.GuestId == guestId &&
                            f.HotelId == hotelId &&
                            oa.ActualDepartureDate > DateTime.Now
                            select oa;
                if (query.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }

        public int GetVipCheckInsCount(int guestId)
        {
            int result = 0;

            try
            {
                var query = from oa in dbContainer.OrderedApartments
                            join a in dbContainer.Apartments on oa.ApartmentId equals a.Id
                            where oa.GuestId == guestId &&
                            a.TypeVip
                            select oa;
                result = query.Count();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }

            return result;
        }
    }
}