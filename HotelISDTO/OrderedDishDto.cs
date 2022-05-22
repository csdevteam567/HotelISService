using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class OrderedDishDto
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public int MenuId { get; set; }
    }
}
