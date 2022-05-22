using System;
using System.Runtime.Serialization;


namespace HotelISDTO
{
    [DataContract]
    public class HotelStatusFilterDto
    {
        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public int FloorId { get; set; }

        [DataMember]
        public int ApartmentId { get; set; }

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
        public DateTime StartPeriod { get; set; }

        [DataMember]
        public DateTime EndPeriod { get; set; }
    }
}
