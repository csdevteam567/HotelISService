using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class CityDto
    {
        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string CountryName { get; set; }
    }
}
