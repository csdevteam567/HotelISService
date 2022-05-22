using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class HotelDto
    {
        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public int MaxFloorsCount { get; set; }
    }
}
