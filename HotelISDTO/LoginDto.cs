using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class LoginDto
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
