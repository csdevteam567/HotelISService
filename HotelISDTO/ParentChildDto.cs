using System;
using System.Runtime.Serialization;

namespace HotelISDTO
{
    [DataContract]
    public class ParentChildDto
    {
        [DataMember]
        public int ChildId { get; set; }

        [DataMember]
        public int ParentId { get; set; }

        [DataMember]
        public string ChildFirstname { get; set; }

        [DataMember]
        public string ChildLastname { get; set; }

        [DataMember]
        public string ChildPassport{ get; set; }

        [DataMember]
        public string ParentFirstname { get; set; }

        [DataMember]
        public string ParentLastname { get; set; }

        [DataMember]
        public string ParentPassport { get; set; }
    }
}
