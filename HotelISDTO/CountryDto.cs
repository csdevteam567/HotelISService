using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class CountryDto
    {
        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string CountryName { get; set; }
    }
}
