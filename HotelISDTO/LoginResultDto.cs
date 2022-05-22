using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class LoginResultDto
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string UserLogin { get; set; }

        [DataMember]
        public int UserRole { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
