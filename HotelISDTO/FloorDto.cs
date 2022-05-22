using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class FloorDto
    {
        [DataMember]
        public int FloorId { get; set; }

        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public int FloorNum { get; set; }

        [DataMember]
        public int MaxApartments { get; set; }

        [DataMember]
        public string HotelName { get; set; }
    }
}