using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class OrderDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public int GuestId { get; set; }

        [DataMember]
        public int ApartmentId { get; set; }

        [DataMember]
        public string PassportNumber { get; set; }

        [DataMember]
        public string GuestFirstName { get; set; }

        [DataMember]
        public string GuestLastName { get; set; }

        [DataMember]
        public System.DateTime OrderDate { get; set; }

        [DataMember]
        public System.DateTime DepartureDate { get; set; }

        [DataMember]
        public string UserLogin { get; set; }

        [DataMember]
        public double Total { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string CountryName { get; set; }
    }
}
