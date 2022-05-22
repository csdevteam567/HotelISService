using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace HotelISDTO
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int Role { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}