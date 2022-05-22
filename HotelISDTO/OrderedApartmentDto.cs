using System;
using System.Runtime.Serialization;


namespace HotelISDTO
{
    [DataContract]
    public class OrderedApartmentDto
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public int ApartmentId { get; set; }

        [DataMember]
        public string GuestPassportNumber { get; set; }

        [DataMember]
        public string GuestFirstName { get; set; }

        [DataMember]
        public string GuestLastName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public int FloorNumber { get; set; }

        [DataMember]
        public int ApartmentNumber { get; set; }

        [DataMember]
        public DateTime ActualDepartureDate { get; set; }

        [DataMember]
        public double ApartmentPrice { get; set; }
    }
}
