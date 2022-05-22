using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class PaycheckDto
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public List<DishDto> OrderedDishes { get; set; }

        [DataMember]
        public List<ApartmentPaycheckDto> OrderedApartments { get; set; }

        [DataMember]
        public double TotalPrice { get; set; }
    }
}
