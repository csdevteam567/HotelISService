using System;

namespace HotelClientModel
{
    public class OrderSearchCriteria
    {
        public string UserLogin { get; set; }
        public string HotelName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string GuestPassportNumber { get; set; }
    }
}
