using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class OrderGuestDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int GuestPassportNumber { get; set; }
    }
}
