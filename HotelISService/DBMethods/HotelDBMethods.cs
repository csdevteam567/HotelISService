using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelISService
{
    public class HotelDBMethods
    {
        private HotelISService.HotelISDBContainer dbContainer;

        public HotelDBMethods()
        {
            dbContainer = new HotelISDBContainer();
        }

        public Hotel GetApartmentHotel(int apartmentId)
        {
            Hotel result = null;
            try
            {
                var query = from a in dbContainer.Apartments
                            join f in dbContainer.Floors on a.FloorId equals f.Id
                            join h in dbContainer.Hotels on f.HotelId equals h.Id
                            where a.Id == apartmentId
                            select h;
                result = query.First();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }
    }
}