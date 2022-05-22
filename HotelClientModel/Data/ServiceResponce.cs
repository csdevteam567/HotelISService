using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelClientModel
{
    public class ServiceResponce
    {
        public bool IsOperationSuccessful { get; set; }
        public string Message { get; set; }
        public int EntryId { get; set; }
    }
}
