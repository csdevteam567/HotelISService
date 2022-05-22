using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace HotelClientModel
{
    public class ParentChildRelationsModel
    {
        public List<ParentChild> ParentChildRelationsTable { get; set; }
        public List<Guest> Childs { get; set; }
        public List<Guest> Parents { get; set; }
        public Guest CurrentChild { get; set; }
        public Guest CurrentParent { get; set; }

        public ParentChild CurrentRelation { get; set; }

        public string CustomerLastname { get; set; }
        public string CustomerFirstname { get; set; }
        public string CustomerPassportNumber { get; set; }
        public string CustomerFamily { get; set; }
    }
}
