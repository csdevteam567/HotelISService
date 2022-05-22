using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class RestaurantDto
    {
        [DataMember]
        public int RestaurantId { get; set; }

        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string HotelName { get; set; }
    }
}
