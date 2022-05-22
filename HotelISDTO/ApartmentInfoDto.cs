using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class ApartmentInfoDto
    {
        [DataMember]
        public int ApartmentId { get; set; }

        [DataMember]
        public int ApartmentNumber { get; set; }

        [DataMember]
        public bool IsVIP { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}
