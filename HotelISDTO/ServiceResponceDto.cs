using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class ServiceResponceDto
    {
        [DataMember]
        public bool IsOperationSuccessful { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public int EntryId { get; set; }
    }
}
