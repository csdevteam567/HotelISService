using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class ApartmentDto
    {
        [DataMember]
        public int ApartmentId { get; set; }

        [DataMember]
        public int FloorId { get; set; }

        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public bool HasStatusVip { get; set; }

        [DataMember]
        public int MaxCapacity { get; set; }

        [DataMember]
        public int RoomsNumber { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int FloorNumber { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public bool OnlyAvailable { get; set; }
    }
}
