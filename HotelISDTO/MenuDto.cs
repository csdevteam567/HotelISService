using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class MenuDto
    {
        [DataMember]
        public int DishId { get; set; }

        [DataMember]
        public int RestaurantId { get; set; }

        [DataMember]
        public string DishName { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public string RestaurantName { get; set; }

        [DataMember]
        public string HotelName { get; set; }
    }
}
