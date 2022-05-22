using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class DishDto
    {
        [DataMember]
        public int DishId { get; set; }

        [DataMember]
        public string DishName { get; set; }

        [DataMember]
        public double DishPrice { get; set; }
    }
}
