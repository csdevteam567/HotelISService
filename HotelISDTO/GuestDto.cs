using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class GuestDto
    {
        [DataMember]
        public int GuestId { get; set; }

        [DataMember]
        public string PassportNumber { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FamilyName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public System.DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public bool StatusVip { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public double Discount { get; set; }
    }
}
