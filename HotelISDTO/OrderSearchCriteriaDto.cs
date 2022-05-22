using System;
using System.Runtime.Serialization;


namespace HotelISDTO
{
    [DataContract]
    public class OrderSearchCriteriaDto
    {
        [DataMember]
        public string UserLogin { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public string GuestPassportNumber { get; set; }
    }
}
