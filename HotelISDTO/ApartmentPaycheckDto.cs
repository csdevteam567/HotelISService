using System;
using System.Runtime.Serialization;


namespace HotelISDTO
{
    [DataContract]
    public class ApartmentPaycheckDto
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public int FloorNumber { get; set; }

        [DataMember]
        public int ApartmentNumber { get; set; }

        [DataMember]
        public DateTime ActualDepartureDate { get; set; }

        [DataMember]
        public double ApartmentPrice { get; set; }

        [DataMember]
        public int TotalDays { get; set; }
    }
}
